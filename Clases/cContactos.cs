using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Final.Clases
{
    public class cContactos
    {
        private SqlConnection oConexion;
        private SqlCommand oComando;
        private SqlDataAdapter oAdaptador;
        private DataTable oData;
        private int _id;
        private string _nombre;
        private string _email;
        private string _direccion;
        private string _cumpleaños;
        private string _telefono;
        private int _celular;


        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Email { get => _email; set => _email = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Cumpleaños { get => _cumpleaños; set => _cumpleaños = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public int Celular { get => _celular; set => _celular = value; }
        public void Guardar()
        {
            using (oConexion = new SqlConnection(cConexion.CadenaConexion()))
            {
                string sql = "INSERT INTO tDatos (nombre,email,direccion,cumpleaños,telefono,celular)" +
                     "values('" + _nombre + "','" + _email + "','" + _direccion + "','" + _cumpleaños + "','" + _telefono + "','" + _celular + "')";

                try
                {
                    oConexion.Open();
                    oComando = new SqlCommand(sql, oConexion);
                    oComando.CommandType = CommandType.Text;
                    oComando.ExecuteNonQuery();
                    oConexion.Close();
                }
                catch
                {

                    oConexion.Close();
                }

            }
        }




        public void elimminarDato()
        {
            using (oConexion = new SqlConnection(cConexion.CadenaConexion()))
            {
                string sql = "DELETE FROM tDatos WHERE id='" + _id + "'";

                try
                {
                    oConexion.Open();
                    oComando = new SqlCommand(sql, oConexion);
                    oComando.CommandType = CommandType.Text;
                    oComando.ExecuteNonQuery();
                    oConexion.Close();

                }
                catch
                {
                    oConexion.Close();
                }
            }
        }


















        public void Consultar()
        {
            using (oConexion = new SqlConnection(cConexion.CadenaConexion()))
            {
                string sql = "select nombre from tdatos where nombre like 'L%'";

                try
                {
                    oConexion.Open();
                    oComando = new SqlCommand(sql, oConexion);
                    oComando.CommandType = CommandType.Text;
                    oComando.ExecuteNonQuery();
                    oConexion.Close();

                }
                catch
                {
                    oConexion.Close();

                }
            }

        }


        //SELECT "nombre_columna"FROM "nombre_tabla"[WHERE "condición"] ORDER BY "nombre_columna" [ASC, DESC];


        public DataTable Mostrar()
        {
            using (oConexion = new SqlConnection(cConexion.CadenaConexion()))
            {
                oData = new DataTable();
                string sql = "select * from tdatos order by nombre asc ";
                try
                {
                    oConexion.Open();
                    oComando = new SqlCommand(sql, oConexion);
                    oComando.CommandType = CommandType.Text;
                    oAdaptador = new SqlDataAdapter(oComando);
                    oAdaptador.Fill(oData);

                    oConexion.Close();
                }
                catch
                {
                    oConexion.Close();
                }
                return oData;
            }
        }
       





            public void Modificar()
            {

                using (oConexion = new SqlConnection(cConexion.CadenaConexion()))
                {
                    string sql = "UPDATE tDatos SET nombre='" + _nombre + "', email='" + _email + "', direccion='" + _direccion + "', cumpleaños='" + _cumpleaños + "', telefono='" + _telefono + "', celular='" + _celular + "' WHERE id='" + _id + "'";
                try
                    {
                        oConexion.Open();
                        oComando = new SqlCommand(sql, oConexion);
                        oComando.CommandType = CommandType.Text;
                        oComando.ExecuteNonQuery();
                        oConexion.Close();

                }
                    catch
                    {
                        oConexion.Close();
                    

                    }

                }


            } 
        }
    }



