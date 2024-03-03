using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace proyecto_final
{
    internal class Clase_admin
    {
        private string user { set; get; }
        private string password { set; get; }
        private string email { set; get; }


        public Clase_admin()
        {
        }

        public Clase_admin(string user, string password, string email)
        {
            this.user = user;
            this.password = password;
            this.email = email;

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


            string insert = "insert into administradores (usuario,contraseña,email) values(@user,@contr,@email)";

            MySqlCommand agregar = new MySqlCommand(insert, conectar);
            agregar.Parameters.Add(new MySqlParameter("@user", this.user));
            agregar.Parameters.Add(new MySqlParameter("@contr", this.password));
            agregar.Parameters.Add(new MySqlParameter("@email", this.email));

            try
            {
                agregar.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            conectar.Close();

        }
        public void Inicia_Sesion(string usuario, string contraseña)
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

            string consulta = "Select * From administradores where usuario=@user and contraseña=@passw";

            MySqlCommand Leer = new MySqlCommand(consulta, conectar);
            Leer.Parameters.AddWithValue("@user", usuario);
            Leer.Parameters.AddWithValue("@passw", contraseña);
            MySqlDataReader lectura = Leer.ExecuteReader();

            while (lectura.Read())
            {
                MessageBox.Show("Bienvenido " + lectura.GetString(1) + "!");


            }
            try
            {
                if (lectura.GetString(1) == usuario && lectura.GetString(2) == contraseña)
                {
                    Administracion v = new Administracion();
                    v.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña incorrectas.");
            }


            lectura.Close();

            conectar.Close();
        }
    }
}


