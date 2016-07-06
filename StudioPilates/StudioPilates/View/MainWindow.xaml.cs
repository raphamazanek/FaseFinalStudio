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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuCadastro_Click(object sender, RoutedEventArgs e)
        {
               
        }

        private void menuMatricula_Click(object sender, RoutedEventArgs e)
        {
            frmCadAluno frmCadAluno = new frmCadAluno();
            frmCadAluno.ShowDialog();
        }

        private void menuInstrutor_Click(object sender, RoutedEventArgs e)
        {
            frmCadInstrutor frmCadInstrutor = new frmCadInstrutor();
            frmCadInstrutor.ShowDialog();
        }

        private void menuAgenda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuCriarAgenda_Click(object sender, RoutedEventArgs e)
        {
            frmMontagemAgenda frmMontagemAgenda = new frmMontagemAgenda();
            frmMontagemAgenda.ShowDialog();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Saindo...",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuRelatorio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuPlano_Click(object sender, RoutedEventArgs e)
        {
            frmPlano frmPlano = new frmPlano();
            frmPlano.ShowDialog();
        }

        private void alunoAgenda_Click(object sender, RoutedEventArgs e)
        {
            frmAlunoAgenda frmAlunoAgenda = new frmAlunoAgenda();
            frmAlunoAgenda.ShowDialog();
        }
    }
}
