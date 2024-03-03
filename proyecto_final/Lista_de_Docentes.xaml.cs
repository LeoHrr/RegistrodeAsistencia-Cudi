using Microsoft.Win32;
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
using System.Windows.Shapes;
using System.IO;


namespace proyecto_final
{
    /// <summary>
    /// Lógica de interacción para Lista_de_Docentes.xaml
    /// </summary>
    public partial class Lista_de_Docentes : Window
    {
        Clase_Docentes docente = new Clase_Docentes();
        MySqlConnection conectar;
        public Lista_de_Docentes()
        {
            InitializeComponent();

            string datos = "DataSource = bhjwwwpvt8noxbjqn7cg-mysql.services.clever-cloud.com; Port = 3306 ; username = umap08lwcxnhecen; Password =5agrSyuI8ULxRO66OJl1 ;DataBase=bhjwwwpvt8noxbjqn7cg ";

            MySqlConnection conectar = new MySqlConnection(datos);
            try
            {
                conectar.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos");
            }

            string consulta = "SELECT p.*, h.llegada " +
                  "FROM personas as p " +
                  "LEFT JOIN horarios as h ON p.id_personas = h.Id_personas";

            MySqlCommand Leer = new MySqlCommand(consulta, conectar);
            MySqlDataReader lectura = Leer.ExecuteReader();

            List.Text = "ID".PadRight(4) + "\t" +
                        "Nombre".PadRight(15) + "\t" +
                        "Apellido".PadRight(15) + "\t" +
                        "DNI".PadRight(15) + "\t" +
                        "Materia".PadRight(15) + "\t" +
                        "días".PadRight(15) + "\t" +
                        "Horario".PadRight(15) + "\t" +
                        "Llegada\n";

            while (lectura.Read())
            {

                List.Text +=
                    lectura.GetInt32(0).ToString().PadRight(4) + "\t" +
                    lectura.GetString(1).PadRight(15) + "\t" +
                    lectura.GetString(2).PadRight(15) + "\t" +
                    lectura.GetString(3).PadRight(15) + "\t" +
                    lectura.GetString(4).PadRight(15) + "\t" +
                    lectura.GetString(5).PadRight(15) + "\t" +
                    lectura.GetTimeSpan(6).ToString().PadRight(15) + "\t" +
                 (lectura["llegada"] == DBNull.Value ? "" : lectura.GetTimeSpan("llegada").ToString()).PadRight(15) + "\n";

            }
            lectura.Close();
            conectar.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string contenido = List.Text;
            DescargarArchivo(contenido);
        }

        private void DescargarArchivo(string contenido)
        {
            try
            {

                string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");


                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto|*.txt";
                saveFileDialog.Title = "Guardar Contenido";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "Registro_" + fechaActual;

                if (saveFileDialog.ShowDialog() == true)
                {

                    File.WriteAllText(saveFileDialog.FileName, contenido);
                    MessageBox.Show("Contenido guardado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el contenido: " + ex.Message);
            }
        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            string datos = "DataSource = bhjwwwpvt8noxbjqn7cg-mysql.services.clever-cloud.com; Port = 3306 ; username = umap08lwcxnhecen; Password =5agrSyuI8ULxRO66OJl1 ;DataBase=bhjwwwpvt8noxbjqn7cg ";

            conectar = new MySqlConnection(datos);
            try
            {
                conectar.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar conectarse con base de datos");
            }
            string borrarTime = "Update horarios set llegada = NULL";
            MySqlCommand borrarHora = new MySqlCommand(borrarTime, conectar);
            borrarHora.ExecuteNonQuery();

            conectar.Close();

            MessageBox.Show("Se reiniciaron los horarios del dia.");
            this.Close();


        }
    }
}
