using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace discEmbedTest
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            do_the_do do_The_Do = new do_the_do(text_token.Text);
            do_The_Do.Show();
            this.Hide();
        }
    }
}