using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testosteron
{
    public partial class FormCheckState : Form
    {
        //TODO: wpisanie tego, co podaliśmy do FormListOfProducts
        public FormCheckState()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormListOfProducts f = new FormListOfProducts(textBoxCategory.Text, textBoxMin.Text, textBoxMax.Text, textBoxAmount.Text);
            f.ShowDialog();
        }
    }
}
