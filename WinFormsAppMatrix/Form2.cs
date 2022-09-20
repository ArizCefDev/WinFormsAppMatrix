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
    public partial class Form2 : Form
    {
        public Form1 _form1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public Form2(Form1 form1,User user)
        {
            InitializeComponent();
            _form1 = form1;
            label5.Text = " " + user.ID;
            label6.Text = " " + user.UserName;
            label7.Text = " " + user.Password;
        }
    }
}
