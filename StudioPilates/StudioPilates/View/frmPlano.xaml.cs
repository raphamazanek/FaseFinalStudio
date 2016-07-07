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
using System.Windows.Shapes;

namespace StudioPilates.View
{
    /// <summary>
    /// Interaction logic for frmPlano.xaml
    /// </summary>
    public partial class frmPlano : Window
    {

        private Plano p = new Plano();

        public frmPlano()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitarBotoes();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o registro?", "Cadastro de Plano",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.Yes)
            {
                if (PlanoDAO.RemoverPlnao(p))
                {
                    MessageBox.Show("Plano removido com sucesso", "Cadastra Plano", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Plano não removido!", "Cadastra Plano", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }

            txtNome.Clear();
            txtDescricao.Clear();
            txtBusca.Clear();

        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o registro?", "Cadastro de Aluno",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.Yes)
            {

                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;

                if (PlanoDAO.AlterarPlano(p))
                {
                    MessageBox.Show("Plano alterado com sucesso", "Cadastra Plano", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Plano não alterado!", "Cadastra Plano", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }

            txtNome.Clear();
            txtDescricao.Clear();
            txtBusca.Clear();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            p = new Plano();

            if (txtNome.Text != null && txtDescricao.Text != null)
            {

                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;

                if (PlanoDAO.AdicionarPlano(p))
                {
                    MessageBox.Show("Gravado com sucesso!", "Cadastro de Plano",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Não foi possível gravar!", "Cadastro de Plano",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }

                txtNome.Clear();
                txtDescricao.Clear();
            }
            else
            {
                MessageBox.Show("Não foi possível gravar, preencha todos os campos!", "Cadastro de Plano",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            p = new Plano();
            if (!string.IsNullOrEmpty(txtBusca.Text))
            {
                p.Nome = txtBusca.Text;
                p = PlanoDAO.VerificaPlanoPorNome(p);
                if (p != null)
                {
                    txtNome.Text = p.Nome;
                    txtDescricao.Text = p.Descricao;
                }
                else
                {
                    MessageBox.Show("Plano não encontrado!", "Cadastro de Plano",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Cadastro de Plano",
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
