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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void братьяСестрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.братьяСестрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.family_tree1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "family_tree1DataSet.БратьяСестры". При необходимости она может быть перемещена или удалена.
            this.братьяСестрыTableAdapter.Fill(this.family_tree1DataSet.БратьяСестры);

        }
    }
}
