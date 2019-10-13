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
    public partial class WordsLenght : UserControl
    {
        public WordsLenght()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            UserInterface.PanelRouting route = PanelRouting.getInstance();
            route.PanelAddControls(Program.f1.pnlMainContainer, new Game((int)numericWordLenght.Value));
        }
    }
}
