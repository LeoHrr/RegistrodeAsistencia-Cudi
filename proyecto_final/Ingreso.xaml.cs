using MySql.Data.MySqlClient;
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

namespace proyecto_final
{
    /// <summary>
    /// Lógica de interacción para Ingreso.xaml
    /// </summary>
    public partial class Ingreso : Page
    {
        Clase_admin admin = new Clase_admin();


        public Ingreso()
        {
            InitializeComponent();
        }

        private void Ingreso_user_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Ingreso_pass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void iniciar_sesion_Click(object sender, RoutedEventArgs e)
        {
            admin.Inicia_Sesion(Ingreso_user.Text, passbox.Password);
            Ingreso_user.Text = "";
            passbox.Password = "";

        }



        private void frames_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Agregar_Admin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void volver_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Principal());
        }

    }
}
