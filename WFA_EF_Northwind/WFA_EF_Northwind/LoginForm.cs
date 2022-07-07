using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Northwind
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();

        private void GirisYap()
        {
            List<User> users = db.Users.Where(x => x.UserName == txtUser.Text && x.Password == txtPassword.Text).ToList();

            foreach (User u in users)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Giris'e tiklandiginda, northwind'den gelen kullanici bilgileri kullanici adi ve sifreyle eslesiyorsa, form1 acilacak.
            //model1 silinecek. appConfigden de connectionstring kismi silinecek. boylece tekrar baglanti kuruldugunda connectionstringler cakismayacak.

            GirisYap();

        }
    }
}
