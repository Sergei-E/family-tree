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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void персонаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персонаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.family_tree1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "family_tree1DataSet.Персона". При необходимости она может быть перемещена или удалена.
            this.персонаTableAdapter.Fill(this.family_tree1DataSet.Персона);

        }
    }
}
