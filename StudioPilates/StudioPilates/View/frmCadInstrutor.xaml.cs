using StudioPilates.DAL;
using StudioPilates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudioPilates.View
{
    /// <summary>
    /// Interação lógica para frmCadAluno.xam
    /// </summary>
    public partial class frmCadInstrutor : Window
    {

        private Instrutor i = new Instrutor();

        public frmCadInstrutor()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitarBotoes();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o registro?", "Remover de Instrutor",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.Yes)
            {
                if (InstrutorDAO.RemoverInstrutor(i))
                {
                    MessageBox.Show("Instrutor removido com sucesso", "Remover Instrutor", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Instrutor não removido!", "Remover Instrutor", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }

            txtNome.Clear();
            txtSobrenome.Clear();
            txtCPF.Clear();
            DtNasc.Text = null;
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o registro?", "Alterar Instrutor",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.Yes)
            {

                i.Nome = txtNome.Text;
                i.Sobrenome = txtSobrenome.Text;
                i.CPF = txtCPF.Text;
                i.Celular = txtCelular.Text;
                i.Telefone = txtTelefone.Text;
                i.DtNasc = DtNasc.Text;
                i.Endereco = txtEndereco.Text;
                i.Email = txtEmail.Text;


                if (InstrutorDAO.AlterarInstrutor(i))
                {
                    MessageBox.Show("Instrutor alterado com sucesso", "Altera Instrutor", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Instrutor não alterado!", "Altera Instrutor", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }

            txtNome.Clear();
            txtSobrenome.Clear();
            txtCPF.Clear();
            DtNasc.Text = null;
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            i = new Instrutor();

            i.Nome = txtNome.Text;
            i.Sobrenome = txtSobrenome.Text;
            i.CPF = txtCPF.Text;
            i.Celular = txtCelular.Text;
            i.DtNasc = DtNasc.Text;
            i.Telefone = txtTelefone.Text;
            i.Email = txtEmail.Text;
            i.Endereco = txtEndereco.Text;

            if (InstrutorDAO.AdicionarInstrutor(i))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Instrutor",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Instrutor",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txtNome.Clear();
            txtSobrenome.Clear();
            txtCPF.Clear();
            DtNasc.Text = null;
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }

        private void btnBuscarCPFInstrutor_Click(object sender, RoutedEventArgs e)
        {
            i = new Instrutor();
            if (!string.IsNullOrEmpty(txtBuscarInstrutor.Text))
            {
                i.CPF = txtBuscarInstrutor.Text;
                i = InstrutorDAO.VerificaInstrutorPorCPF(i);
                if (i != null)
                {
                    txtNome.Text = i.Nome;
                    txtSobrenome.Text = i.Sobrenome;
                    txtCPF.Text = i.CPF;
                    txtCelular.Text = i.Celular;
                    DtNasc.Text = i.DtNasc;
                    txtTelefone.Text = i.Telefone;
                    txtEndereco.Text = i.Endereco;
                    txtEmail.Text = i.Email;
                    HabilitarBotoes();
                }
                else
                {
                    MessageBox.Show("Intrutor não encontrado!", "Busca Instrutor",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Busca Instrutor",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void HabilitarBotoes()
        {
            btnAlterar.IsEnabled = true;
            btnRemover.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnGravar.IsEnabled = false;
        }

        public void DesabilitarBotoes()
        {
            btnAlterar.IsEnabled = false;
            btnRemover.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnGravar.IsEnabled = true;

        }
    }
}
