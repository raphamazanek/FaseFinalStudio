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
    public partial class frmAlunoAgenda : Window
    {

        private AlunoAgenda a = new AlunoAgenda();

        public frmAlunoAgenda()
        {
            InitializeComponent();
        }

        private void cmbAluno_Loaded(object sender, RoutedEventArgs e)
        {
            var lista = AlunoDAO.ReturnLista();
            cmbAluno.ItemsSource = lista;
        }

        private void cmbAula_Loaded(object sender, RoutedEventArgs e)
        {
            var lista = AgendaDAO.ReturnLista();
            cmbAula.ItemsSource = lista;
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            a = new AlunoAgenda();

            a.Agenda = (string)cmbAula.SelectedValue;
            a.Aluno = (string)cmbAluno.SelectedValue;

            if (AlunoAgendaDAO.AdicionarAlunoAgenda(a))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Agenda",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Agenda",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            var lista = AlunoAgendaDAO.ReturnLista();
            dataGrid.ItemsSource = lista;

            cmbAula.Text = null;
            cmbAluno.Text = null;
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            var a = ((Button)sender).DataContext as AlunoAgenda;
            if (AlunoAgendaDAO.RemoverAlunoAgenda(a))
            {
                MessageBox.Show("Removido com sucesso!", "Cadastro de Agenda",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Erro ao deletar!", "Cadastro de Agenda",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }

            var lista = AlunoAgendaDAO.ReturnLista();
            dataGrid.ItemsSource = lista;

        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var lista = AlunoAgendaDAO.ReturnLista();
            if (AlunoAgendaDAO.ReturnLista() != null)
            { 
                dataGrid.ItemsSource = lista;
            }
            else
            {
                MessageBox.Show("Não há dados!", "Cadastro de Agenda",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }            
        }
    }
}
