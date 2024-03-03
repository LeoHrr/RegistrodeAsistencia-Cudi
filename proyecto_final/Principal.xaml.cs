using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Page
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();



        public Principal()
        {
            InitializeComponent();
            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            ActualizarFecha();

        }

        private void confirmar_Click(object sender, RoutedEventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Ingrese Numero de registro para confirmar");
            }
            else
            {
                string datos = "DataSource = bhjwwwpvt8noxbjqn7cg-mysql.services.clever-cloud.com; Port = 3306 ; username = umap08lwcxnhecen; Password =5agrSyuI8ULxRO66OJl1 ;DataBase=bhjwwwpvt8noxbjqn7cg ";

                MySqlConnection conectar = new MySqlConnection(datos);
                try
                {
                    conectar.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar conectarse con base de datos");
                }

                var datetime = DateTime.Now.ToString("HH:mm:ss");

                string actualizar = " UPDATE horarios SET llegada=@llegada  WHERE id_personas = @idModificar";
                MySqlCommand modificar = new MySqlCommand(actualizar, conectar);
                modificar.Parameters.Add(new MySqlParameter("@idModificar", ID.Text));
                modificar.Parameters.Add(new MySqlParameter("@llegada", datetime));

                modificar.ExecuteNonQuery();
                if (modificar.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("No existe docente con ese numero de Registro.");

                }
                else
                {
                    MessageBox.Show("Asistencia guardada!");
                    ID.Text = "";
                }
            }
        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Ingreso());

        }
        private void Timer_Click(object sender, EventArgs e)

        {

            DateTime d;
            d = DateTime.Now;

            horaActual.Content = d.Hour + " : " + d.Minute + " : " + d.Second;


        }

        private void ActualizarFecha()
        {

            DateTime fechaActual = DateTime.Now;


            string fechaFormateada = fechaActual.ToString("ddd d 'de' MMMM 'de' yyyy");


            fecha.Text = fechaFormateada;
        }


    }
}
