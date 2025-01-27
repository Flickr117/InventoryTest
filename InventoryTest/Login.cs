using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTest
{
    public partial class Login : Form
    {
        private const string usernameAdmin = "admin";
        private const string passwordAdmin = "admin";
        private const string usernameUser = "user1";
        private const string passwordUser = "user1";

        string username;
        string password;

        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
        }

        private void Login_Load(object sender, EventArgs e) { }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {
            username = UsernameInput.Text;
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            password = PasswordInput.Text;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UsernameInput.Focused)
                {
                    PasswordInput.Focus();
                }
                else if (PasswordInput.Focused)
                {
                    Result();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Result()
        {
            if (username == usernameAdmin && password == passwordAdmin)
            {
                // Admin Mainpage
                AdminMainPage AdminMainPage = new AdminMainPage();
                AdminMainPage.Show();
                this.Hide();
            }
            else if (username == usernameUser && password == passwordUser)
            {
                // User Mainpage
                UserMainPage UserMainPage = new UserMainPage();
                UserMainPage.Show();
                this.Hide();
            }
            else
            {
                ResultLabel.Text = "Invalid Credentials!";
            }
        }



    }
}
