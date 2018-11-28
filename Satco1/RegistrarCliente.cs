using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Satco1
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void RegistrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            PRINCIPAL.SegRCliente = 0;
        }

        public static int clienteExistente(String id) {
            int esta = 0;
            MySqlCommand comando = new MySqlCommand("Select * from clientes where id_cliente='"+id+"'");
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.Read())
                {
                    MessageBox.Show("El cliente no existe ");

                }
                else
                {
                    MessageBox.Show("el cliente ya esta registrado");
                    esta = 1;
                }
            }


            return esta;
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            int a;
            a = clienteExistente(txtCedula.Text);
            if (a == 0)
            {
                if (txtCedula.Text.Equals(""))
                {
                    MessageBox.Show("el campo cedula esta vacio");
                }
                else
                {
                    if (txtNombre.Text.Equals(""))
                    {
                        MessageBox.Show("el campo cedula esta vacio");
                    }
                    else
                    {
                        if (txtApellido.Text.Equals(""))
                        {
                            MessageBox.Show("el campo cedula esta vacio");
                        } else
                        {
                            if (txtTelefono.Text.Equals(""))
                            {
                                MessageBox.Show("el campo cedula esta vacio");
                            }
                            else
                            {
                                if (txtCorreo.Text.Equals(""))
                                {
                                    MessageBox.Show("el campo cedula esta vacio");
                                }
                                else
                                {
                                    if (txtDireccion.Text.Equals(""))
                                    {
                                        MessageBox.Show("el campo cedula esta vacio");
                                    }
                                    else
                                    {
                                        bandera = 1;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (bandera == 1)
            {



                try
                {
                    MySqlCommand comando = new MySqlCommand("INGRESAR_CLIENTE", Conexion.CrearConexion()); //version con procedure.
                    comando.CommandType = CommandType.StoredProcedure;  //version con procedure 
                    comando.Parameters.AddWithValue("id", txtCedula.Text.ToUpper()); //version con procedure
                    comando.Parameters.AddWithValue("nombre", txtNombre.Text.ToUpper()); //version con procedure
                    comando.Parameters.AddWithValue("apellido", txtApellido.Text.ToUpper());  //version con procedure
                    comando.Parameters.AddWithValue("telefono", txtTelefono.Text.ToUpper());  //version con procedure
                    comando.Parameters.AddWithValue("correo", txtCorreo.Text.ToUpper());  //version con procedure
                    comando.Parameters.AddWithValue("direccion", txtDireccion.Text.ToUpper());  //version con procedure
                    comando.Parameters.AddWithValue("genero", comboGenero.SelectedItem.ToString());  //version con procedure
                    comando.Parameters.AddWithValue("estado", "ACTIVO");  //version con procedure
                    comando.ExecuteNonQuery();  //version con procedure
                    MessageBox.Show("Insercion exitosa"); // version con procedure

                    limpiarCajas();
                    // cajaNombre.Focus();
                }
                catch (MySqlException ex)
                {
                    // MessageBox.Show("Error en la coneccion");
                }

            }
        }

        private void limpiarCajas() {

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
