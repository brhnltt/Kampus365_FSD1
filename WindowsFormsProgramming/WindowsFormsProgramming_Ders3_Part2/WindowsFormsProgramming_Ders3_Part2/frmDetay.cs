using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProgramming_Ders3_Part2
{
    public partial class frmDetay : Form
    {
        // field
        //private string LabelText;
        public string LabelText;
        public string TextboxText;

        public frmDetay()
        {
            InitializeComponent();
        }

        private void frmDetay_Load(object sender, EventArgs e)
        {
            label1.Text = LabelText;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            TextboxText = textBox2.Text;
            Close();
        }
    }
}
