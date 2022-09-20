using DataAccessLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.LogIn(textBox1.Text, textBox2.Text))
            {
                var user = new User(textBox1.Text, textBox2.Text);
                var form = new Form2(this, user);
                form.Show();
                this.Hide();
            }
            else
            {
                //Context.RunExecute(@"INSERT INTO Cars VaLUES('Kia');");
                //Context.RunExecute(@"SELECT FROM Cars ID=4;");
                //Context.RunExecute(@"DELETE FROM Cars ID=6;");
                //Context.RunExecute(@"UPDATE Cars Marka='Cadillac' WHERE ID=3;");
                MessageBox.Show("incorrect password", "Error");
            }
        }
    }
}
