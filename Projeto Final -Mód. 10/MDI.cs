using Projeto_Final__Mód._10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final__Mód._10
{
    public partial class MDI : Form
    {
        // Adicione um campo para controlar o estado do login
        private bool loggedIn = false;
        public MDI()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            /*int xOffset = pictureBox1.Width + 10; // Ajuste conforme necessário
            int yOffset = 0; // Ajuste conforme necessário

            foreach (Form mdiChild in MdiChildren)
            {
                mdiChild.Location = new Point(xOffset, yOffset);
                yOffset += mdiChild.Height + 10; // Ajuste conforme necessário
            }*/
        }

        private void toolStriplogin_Click(object sender, EventArgs e)
        {
            /*LoginForm2 form2 = new LoginForm2();
            form2.MdiParent = this;
            form2.Show();

            // Inscreve-se no evento de login bem-sucedido
            form2.LoginSuccess += LoginForm_LoginSuccess;*/

            LoginForm2 form2 = new LoginForm2();
            form2.MdiParent = this;
            form2.LoginSuccess += LoginForm_LoginSuccess;
            form2.Show();
        }
        private void LoginForm_LoginSuccess(object sender, EventArgs e)
        {
            // Handler para o evento de login bem-sucedido
            loggedIn = true;
            EnableAllFunctionality();
        }

        private void EnableAllFunctionality()
        {
            // Habilita todas as funcionalidades após o login bem-sucedido
            ToolStripProdutos.Enabled = true;
            ToolStripVendas.Enabled = true;
            ToolStripReparações.Enabled = true;

            // Limpa as mensagens de erro
            ClearErrorMessages();
        }

        private void ClearErrorMessages()
        {
            // Limpa as mensagens de erro
            // Você pode adicionar mais funcionalidades aqui, dependendo de como as mensagens de erro são exibidas
            // Por exemplo, MessageBox.Clear() ou definir o texto para vazio em um controle de exibição de erro
            // Isso depende de como você implementou as mensagens de erro na sua aplicação
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ListagemProdutosForm3 form3 = new ListagemProdutosForm3();
            form3.MdiParent = this;
            form3.Show();*/
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowLoginErrorMessage()
        {
            // Exibe uma mensagem de erro indicando que o usuário precisa fazer login
            MessageBox.Show("Faça login antes de acessar esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ToolStripProdutos_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                // Lógica para a funcionalidade de Produtos
                EnableAllFunctionality();
                ToolStripListagem.Visible=true;
                ToolStripNovo.Visible = true;
                ToolStripEditar.Visible = true;
                ToolStripApagar.Visible = true;
                ToolStripCategorias.Visible = true;
            }
            else
            {
                ShowLoginErrorMessage();
            }
        }

        private void ToolStripNovo_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripEditar_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripApagar_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripCategorias_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripVendas_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                // Lógica para a funcionalidade de Produtos
                EnableAllFunctionality();
                ToolStripRegistar.Visible = true;
                ToolStripConsultar.Visible = true;
                ToolStripVendasMensais.Visible = true;
            }
            else
            {
                ShowLoginErrorMessage();
            }
        }

        private void ToolStripRegistar_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripConsultar_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripVendasMensais_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripReparações_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                // Lógica para a funcionalidade de Produtos
                EnableAllFunctionality();
                ToolStripAvarias.Visible = true;
                ToolStripConsultaGeral.Visible = true;
            }
            else
            {
                ShowLoginErrorMessage();
            }
        }

        private void ToolStripAvarias_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripConsultaGeral_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem informando que esta aba ainda não está disponível
            MessageBox.Show("Esta funcionalidade ainda não está disponível.", "Funcionalidade Indisponível", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}