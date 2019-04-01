using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_mail
{
    public partial class Form2 : Form
    {
        string login;
        string password;

        public Form2()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            login = loginLabel.Text;
            password = passwordLabel.Text;
            this.Hide();
            Form1 form = new Form1(login, password);
            form.ShowDialog();
            form.login = login;
            form.password = password;
           
        }
    }
}
