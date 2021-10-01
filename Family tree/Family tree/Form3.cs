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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void бракBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бракBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.family_tree1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "family_tree1DataSet.Брак". При необходимости она может быть перемещена или удалена.
            this.бракTableAdapter.Fill(this.family_tree1DataSet.Брак);

        }
    }
}
