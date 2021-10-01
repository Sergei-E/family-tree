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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void связьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.связьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.family_tree1DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "family_tree1DataSet.Связь". При необходимости она может быть перемещена или удалена.
            this.связьTableAdapter.Fill(this.family_tree1DataSet.Связь);

        }
    }
}
