using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programlama_3HomeWork.UserInterface.Words
{
    public partial class WordsADD : UserControl
    {
        public WordsADD()
        {
            InitializeComponent();
        }
        Engine.Words words = Engine.Words.getInstance();
        private void BtnADD_Click(object sender, EventArgs e)
        {
         
            string text = txtADD.Text;
            if (!String.IsNullOrEmpty(text))
            {
                text = text.Trim().ToUpper();
                words.WordsAdd(text);

            }
            else
            {
                MessageBox.Show("boş Değer Girildi");
            }
           
         
            
        }

       
    }
}
