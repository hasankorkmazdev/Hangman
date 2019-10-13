using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programlama_3HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
         UserInterface.PanelRouting route = UserInterface.PanelRouting.getInstance();
        Engine.Words words = Engine.Words.getInstance();
        private void BtnWords_Click(object sender, EventArgs e)
        {
            route.PanelAddControls(pnlMainContainer, new UserInterface.Words.Words());
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            route.PanelAddControls(pnlMainContainer, new UserInterface.Game.WordsLenght());

        }

      
    }
}
