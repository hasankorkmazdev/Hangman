using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programlama_3HomeWork.Engine
{
    class Words
    {
        private static Words instance;
        private Words()
        {
            WordsRead();
        }
        ~Words()
        {
            UpdateList();
        }
        public static Words getInstance()
        {
            if (instance == null)
            {
                instance = new Words();

            }
            return instance;
        }
        IO.InputOutput fileOperation = new IO.InputOutput(Application.StartupPath, "Words.txt");
        List<string> MyWords = new List<string>();
        public void WordsAdd(string word)
        {


            if (FindWord(word) != -1)
            {
                //Kelime Zaten Var veya Liste Boş
                MessageBox.Show("Kelime Zaten Var veya List Boş", "Succes Abort", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MyWords.Add(word);
                MessageBox.Show("Kelime Başarılı Bir Şekilde Eklendi", "Succes OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public int FindWord(string text)
        {

            if (MyWords.Count > 0)
            {
                return MyWords.IndexOf(text);
            }
            else
            {

                return -1;
            }

        }
        public string FindByLenght(int wordLenght)
        {
            foreach (var item in MyWords)
            {
                if (item.Length==wordLenght)
                {
                    return item;
                }
            }
            return null;
        }
        public void WordsDelete(string text)
        {
            int state = FindWord(text);
            if (state != -1)
            {
                MyWords.RemoveAt(state);
            }
        }
        public void WordsEdit(string find,string replace)
        {
            int state = FindWord(find);
            if (state != -1)
            {
                MyWords[state] = replace;
            }
        }
       public List<string> FindStartWidth(string text)
        {
            return MyWords.Where(x => x.StartsWith(text)).ToList();
        }
        public List<string> WordsList()
        {
            return MyWords;
        }

        #region Input Output
        public void UpdateList()
        {
            fileOperation.WriteAll(MyWords);
        }
        public void WordsWrite(string text)
        {
            fileOperation.Write(text);
        }
        public void WordsRead()
        {
           
            fileOperation.Read(ref MyWords);
            MyWords.Sort();
        }
        #endregion
    }
}
