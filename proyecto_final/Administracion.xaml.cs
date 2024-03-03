using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
    /// Lógica de interacción para Administracion.xaml
    /// </summary>
    public partial class Administracion : Window
    {
        Clase_Docentes docente = new Clase_Docentes();
        MySqlConnection conectar;
        public Administracion()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

            //TABLA PERSONAS - PRIMARY KEY ID


            string insert = "insert into personas (id_personas, nombre,apellido,DNI, materia, dia, horario) values(@id_personas,@nombre,@apellido,@DNI,@materia,@dia, @horario)";

            MySqlCommand agregar = new MySqlCommand(insert, conectar);
            agregar.Parameters.Add(new MySqlParameter("@id_personas", id.Text));
            agregar.Parameters.Add(new MySqlParameter("@nombre", nombre.Text));
            agregar.Parameters.Add(new MySqlParameter("@apellido", apellido.Text));
            agregar.Parameters.Add(new MySqlParameter("@DNI", dni.Text));
            agregar.Parameters.Add(new MySqlParameter("@materia", materia.Text));
            agregar.Parameters.Add(new MySqlParameter("@dia", Dia.Text));
            agregar.Parameters.Add(new MySqlParameter("@horario", horario.Text));

            try
            {
                if (id.Text == "" || nombre.Text == "" || apellido.Text == "" || dni.Text == "" || Dia.Text == "" || horario.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
                else
                {
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Agregado exitosamente");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe un docente con ese ID");
            }

            //TABLA PERSONA - PRIMARY KEY HORARIO

            string insertar = "insert into persona (id_personas, nombre,apellido,DNI, materia, dia, horario) values(@id_personas,@nombre,@apellido,@DNI,@materia,@dia, @horario)";

            MySqlCommand agregar2 = new MySqlCommand(insertar, conectar);
            agregar2.Parameters.Add(new MySqlParameter("@id_personas", id.Text));
            agregar2.Parameters.Add(new MySqlParameter("@nombre", nombre.Text));
            agregar2.Parameters.Add(new MySqlParameter("@apellido", apellido.Text));
            agregar2.Parameters.Add(new MySqlParameter("@DNI", dni.Text));
            agregar2.Parameters.Add(new MySqlParameter("@materia", materia.Text));
            agregar2.Parameters.Add(new MySqlParameter("@dia", Dia.Text));
            agregar2.Parameters.Add(new MySqlParameter("@horario", horario.Text));

            try
            {
                if (id.Text == "" || nombre.Text == "" || apellido.Text == "" || dni.Text == "" || Dia.Text == "" || horario.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
                else
                {
                    agregar2.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

            }

            //TABLA HORARIOS

            string insertTime = "insert into horarios (id_personas,horario,llegada) values(@id_personas,@horario,@llegada)";

            MySqlCommand agregarHora = new MySqlCommand(insertTime, conectar);
            agregarHora.Parameters.Add(new MySqlParameter("@id_personas", id.Text));
            agregarHora.Parameters.Add(new MySqlParameter("@horario", horario.Text));
            agregarHora.Parameters.Add(new MySqlParameter("@llegada", 0));
            try
            {
                if (id.Text == "" || horario.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
                else
                {
                    agregarHora.ExecuteNonQuery();
                }


            }
            catch (Exception)
            {

            }

            id.Text = "";
            nombre.Text = "";
            apellido.Text = "";
            dni.Text = "";
            materia.Text = "";
            Dia.Text = "";
            horario.Text = "";

            conectar.Close();

        }

        private void id_mod_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void nomb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ape_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void hr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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

            //TABLA HORARIOS

            string modTime = "UPDATE horarios SET horario=@horario  WHERE id_personas = @idModificar";

            MySqlCommand modHora = new MySqlCommand(modTime, conectar);
            modHora.Parameters.Add(new MySqlParameter("@id_personas", id_mod.Text));
            modHora.Parameters.Add(new MySqlParameter("@horario", hr.Text));
            try
            {
                modHora.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }

            //-----------------------------------------------------------------------

            //TABLA PERSONAS - PRIMARY KEY ID

            string actualizar = " UPDATE personas SET nombre=@nombre, apellido=@apellido, materia=@materia, dia=@dias, horario=@horario  WHERE id_personas = @idModificar";
            MySqlCommand modificar = new MySqlCommand(actualizar, conectar);
            modificar.Parameters.Add(new MySqlParameter("@idModificar", id_mod.Text));
            modificar.Parameters.Add(new MySqlParameter("@nombre", nomb.Text));
            modificar.Parameters.Add(new MySqlParameter("@apellido", ape.Text));
            modificar.Parameters.Add(new MySqlParameter("@materia", mat.Text));
            modificar.Parameters.Add(new MySqlParameter("@dias", nuevoDia.Text));
            modificar.Parameters.Add(new MySqlParameter("@horario", hr.Text));
            modificar.ExecuteNonQuery();


            //TABLA PERSONA - PRIMARY KEY HORARIO

            string actualizar2 = " UPDATE persona SET nombre=@nombre, apellido=@apellido, materia=@materia, dia=@dias, horario=@horario  WHERE id_personas = @idModificar";
            MySqlCommand modificar2 = new MySqlCommand(actualizar2, conectar);
            modificar2.Parameters.Add(new MySqlParameter("@idModificar", id_mod.Text));
            modificar2.Parameters.Add(new MySqlParameter("@nombre", nomb.Text));
            modificar2.Parameters.Add(new MySqlParameter("@apellido", ape.Text));
            modificar2.Parameters.Add(new MySqlParameter("@materia", mat.Text));
            modificar2.Parameters.Add(new MySqlParameter("@dias", nuevoDia.Text));
            modificar2.Parameters.Add(new MySqlParameter("@horario", hr.Text));
            modificar2.ExecuteNonQuery();



            if (modificar.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("No existe docente con ese numero de ID.");

            }
            else
            {
                MessageBox.Show("Se modificaron los datos.");
                id_mod.Text = "";
                nomb.Text = "";
                ape.Text = "";
                mat.Text = "";
                nuevoDia.Text = "";
                hr.Text = "";
            }


            conectar.Close();


        }

        private void TextBox_TextChanged_7(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (id_borrar.Text == confirm_id.Text)
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

                //TABLA HORARIOS
                string borrarTime = "Delete from horarios where id_personas=@idBorrar";
                MySqlCommand borrarHora = new MySqlCommand(borrarTime, conectar);
                borrarHora.Parameters.Add(new MySqlParameter("@idBorrar", id_borrar.Text));
                borrarHora.ExecuteNonQuery();




                //TABLA PERSONAS - PRIMARY KEY ID

                string borrarUsuario = "Delete from personas where id_personas=@idBorrar";
                MySqlCommand borrar = new MySqlCommand(borrarUsuario, conectar);
                borrar.Parameters.Add(new MySqlParameter("@idBorrar", id_borrar.Text));
                borrar.ExecuteNonQuery();


                //TABLA PERSONA - PRIMARY KEY HORARIO

                string borrarUsuario2 = "Delete from persona where id_personas=@idBorrar";
                MySqlCommand borrar2 = new MySqlCommand(borrarUsuario2, conectar);
                borrar2.Parameters.Add(new MySqlParameter("@idBorrar", id_borrar.Text));
                borrar2.ExecuteNonQuery();


                MessageBox.Show("Ya no existe ningun docente con ese ID");
                id_borrar.Text = "";
                confirm_id.Text = "";
            }
            else
            {
                MessageBox.Show("Los campos deben ser iguales");
            }





            conectar.Close();
        }

        private void Add_Admin_Click(object sender, RoutedEventArgs e)
        {
            AgregarAdmin a = new AgregarAdmin();
            a.Show();
            this.Close();
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void verDocente_Click(object sender, RoutedEventArgs e)
        {
            Lista_de_Docentes lista = new Lista_de_Docentes();
            lista.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Dia_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
