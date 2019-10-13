using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programlama_3HomeWork.Engine
{
    class Game
    {
        //Define Variable
        int wordLenght;
        int health;
        Words wordsBook;
        string gameWord;

        public Game(int wordLenght)
        {
            //Default Option
            wordsBook = Words.getInstance();
            gameWord= wordsBook.FindByLenght(wordLenght);
            this.wordLenght = wordLenght;
            health =wordLenght+2 ;
        }
        public int Health { get => health;  }
        public bool searchInWords( string searchCharacter)
        {
            if (gameWord.Contains(searchCharacter))
            {
                return true;
            }
            else
            {
                if (health>1)
                {
                    health -= 1;
                }
                else if (health==1)
                {
                    System.Windows.Forms.MessageBox.Show("Sen Kaybettin Doğru Kelime"+gameWord);
                    health -= 1;
                }
                return false;
            }
        }
    }
}
