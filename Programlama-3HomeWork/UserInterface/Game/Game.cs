using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programlama_3HomeWork.UserInterface.Game
{
    public partial class Game : UserControl
    {
        Engine.Game MyGame;
        public Game(int wordLenght)
        {
            MyGame = new Engine.Game(wordLenght);
            InitializeComponent();

            lblHealth.Text = MyGame.Health.ToString();
        }

        private void BtnEntry_Click(object sender, EventArgs e)
        {
            MyGame.searchInWords(txtChar.Text.Trim().ToUpper());
            lblHealth.Text = MyGame.Health.ToString();
        }

        private void TxtChar_TextChanged(object sender, EventArgs e)
        {
            if (txtChar.Text.Length==2)
            {
                txtChar.Clear();
            }
        }
    }
}
