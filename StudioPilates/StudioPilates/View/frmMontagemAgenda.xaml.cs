using StudioPilates.DAL;
using StudioPilates.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    public partial class frmMontagemAgenda : Window
    {
        private Agenda a = new Agenda();

        public frmMontagemAgenda()
        {
            InitializeComponent();
        }
                
        private void cmbInstrutor_Loaded(object sender, RoutedEventArgs e)
        {
            var lista = InstrutorDAO.ReturnLista();
            Instrutor instrutor = new Instrutor();

            cmbInstrutor.ItemsSource = lista;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitarBotoes();
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

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            a = new Agenda();

            a.Aula = txtNome.Text;
            a.DataInicio = DtInicial.Text;
            a.DataFinal = DtFinal.Text;

            a.Instrutor = (int)cmbInstrutor.SelectedValue;
            
            if (AgendaDAO.AdicionarAgenda(a))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Agenda",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Agenda",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txtNome.Clear();
            DtInicial.Text = null;
            DtFinal.Text = null;
            cmbInstrutor.Text = null;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            a = new Agenda();
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                a.Aula = txtNome.Text;
                a = AgendaDAO.VerificaAgendaPorNome(a);
                if (a != null)
                {
                    txtNome.Text = a.Aula;
                    DtInicial.Text = a.DataInicio;
                    DtFinal.Text = a.DataFinal;
                    cmbInstrutor.SelectedValue = a.Instrutor;
                    HabilitarBotoes();
                }
                else
                {
                    MessageBox.Show("Aula não encontrado!", "Busca Aula",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Busca Aula",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o registro?", "Alterar Instrutor",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.Yes)
            {

                a.Aula = txtNome.Text;
                a.DataInicio= DtInicial.Text;
                a.DataFinal = DtFinal.Text;
                a.Instrutor = (int)cmbInstrutor.SelectedValue;

                if (AgendaDAO.AlterarAgenda(a))
                {
                    MessageBox.Show("Aula alterada com sucesso", "Altera Aula", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Aula não alterado!", "Altera Aula", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }

            txtNome.Clear();
            DtInicial.Text = null;
            DtFinal.Text = null;
            cmbInstrutor.Text = null;
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o registro?", "Remover de Instrutor",
              MessageBoxButton.YesNo, MessageBoxImage.Question) ==
              MessageBoxResult.Yes)
            {
                if (AgendaDAO.RemoverAgenda(a))
                {
                    MessageBox.Show("Aula removido com sucesso", "Remover Aula", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Aula não removido!", "Remover Aula", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }

            txtNome.Clear();
            DtInicial.Text = null;
            DtFinal.Text = null;
            cmbInstrutor.Text = null;

        }
    }
}
