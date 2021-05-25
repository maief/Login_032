using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BelajarDataContext db = new BelajarDataContext();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = (from s in db.TB_M_USERs where s.username == TxtBoxUsername.Text select s).First();
            if (user.password == TxtBoxPassword.Text)
            {
                
                this.Hide();
                Form2 a = new Form2();
                a.Show();
            } else
            {
                MessageBox.Show("Password Error");
            }
        }
    }
}
