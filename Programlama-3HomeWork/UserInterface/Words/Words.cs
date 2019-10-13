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
    public partial class Words : UserControl
    {
        public Words()
        {
            InitializeComponent();
        }

        UserInterface.PanelRouting route = UserInterface.PanelRouting.getInstance();
       private void BtnWordsADD_Click(object sender, EventArgs e)
        {
            route.PanelAddControls(pnlMain, new WordsADD());
        }

        private void BtnWordsEdit_Click(object sender, EventArgs e)
        {
            route.PanelAddControls(pnlMain, new WordsEDIT());

        }


    }
}
