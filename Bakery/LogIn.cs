using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string login = txtNLogin.Text;
            string password = txtPassword.Text;

            if (login == "admin" && password == "1234")
            {
                MessageBox.Show("Вы успешно вошли в систему как Администратор.\nДобро пожаловать!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.Context.MainForm = new ManagerMainForm();

                Close();

                Program.Context.MainForm.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
