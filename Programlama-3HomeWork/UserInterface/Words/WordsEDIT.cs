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
    public partial class WordsEDIT : UserControl
    {
        //TODO:Kelimeler Load Olduğunda Yüklensin
        Engine.Words words = Engine.Words.getInstance();
        public WordsEDIT()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Words", "Kelimeler");
            GridViewRefresh();
          
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEdit.Text))
            {
                words.WordsDelete(txtEdit.Text.Trim().ToUpper());
            }
            GridViewRefresh();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEdit.Text))
            {
                words.WordsEdit(dataGridView1.CurrentCell.Value.ToString(), txtEdit.Text.Trim().ToUpper());
            }
            GridViewRefresh();
        }

        private void TxtFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in words.FindStartWidth(txtFind.Text.Trim().ToUpper()))
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEdit.Text = dataGridView1.CurrentCell.Value.ToString();
        }
        private void GridViewRefresh()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in words.WordsList())
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}
