using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programlama_3HomeWork.IO
{
    class InputOutput
    {
        string filePath = "";
        public InputOutput(string filePath, string fileName)
        {
            this.filePath = filePath + @"\" + fileName;

        }
        public int Read(ref List<string> OutputText)
        {
            //Böyle Bir Dosya Yok
            if (!File.Exists(filePath))
            {
                return -1;
            }
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                OutputText.Add(yazi);
                yazi = sw.ReadLine();

            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
            return 1;
        }
        public int Write(string WritingText)
        {
            FileStream fs;
            if (!File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(WritingText);
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Flush();
            sw.Close();
            fs.Close();
            return 1;
        }
        public int WriteAll(List<string> Writetexts)
        {
            FileStream fs;
            fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var text in Writetexts)
            {
                sw.WriteLine(text);
            }
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Flush();
            sw.Close();
            fs.Close();
            return 1;
        }





    }
}
