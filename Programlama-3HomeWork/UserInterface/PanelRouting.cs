using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programlama_3HomeWork.UserInterface
{
   public class  PanelRouting
    {
        #region Singleton
        private static PanelRouting instance;
        private PanelRouting()
        {

        }
        public static PanelRouting getInstance()
        {
            if (instance==null)
            {
                instance = new PanelRouting();
            }
            return instance;
        }
        #endregion

        public int PanelAddControls(Control pnlContainer, UserControl AddingControl)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(AddingControl);
            return 1;
        }

    }
}
