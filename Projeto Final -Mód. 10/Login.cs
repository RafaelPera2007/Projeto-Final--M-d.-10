using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final__Mód._10
{
    public partial class LoginForm2 : Form
    {
        // Define um evento para notificar o sucesso do login
        public event EventHandler LoginSuccess;
        private const string Nome = "Rafael";
        private const string Utilizador = "Admin";
        private const string Password = "Admin";
        public LoginForm2()
        {
            InitializeComponent();
        }

        

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Método para acionar o evento de login bem-sucedido
        protected virtual void OnLoginSuccess()
        {
            LoginSuccess?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string utilizadorDigitado = txtNome.Text;
            string senhaDigitada = txtutilizador.Text;

            if (utilizadorDigitado == Nome && senhaDigitada == Password)
            {
                MessageBox.Show("Login bem-sucedido!");

                // Aciona o evento de login bem-sucedido
                OnLoginSuccess();

                // Adicione aqui o código para abrir o próximo formulário ou realizar a ação desejada após o login
                this.Close();
            }
            else
            {
                MessageBox.Show("Login falhou. Verifique suas credenciais.");
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
