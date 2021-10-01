using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_tree
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void детиРодителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.детиРодителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.family_tree1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "family_tree1DataSet.ДетиРодители". При необходимости она может быть перемещена или удалена.
            this.детиРодителиTableAdapter.Fill(this.family_tree1DataSet.ДетиРодители);

        }
    }
}
