using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpresorasUNNE
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Form1.conexionsqllast))
                {
                    conexion.Open();
                    SqlCommand comm = new SqlCommand("SELECT * FROM [InfEq].[dbo].[Impresoras_print]", conexion);
                    SqlDataReader nwReader = comm.ExecuteReader();
                    while (nwReader.Read())
                    {
                        Impresora.DisplayMember = "Text";
                        Impresora.ValueMember = "Value";
                        Impresora.Items.Add(new { Text = nwReader["marca"].ToString()+" - "+nwReader["modelo"].ToString(), Value = nwReader["pid"].ToString()});
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error en la busqueda de modelos de impresoras\n\nMensaje: " + ex.Message, "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Impresora.SelectedIndex = 0;
            estatus.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(basetxt.Text))
            {
                MessageBox.Show("Debes ingresar una base.", "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(String.IsNullOrEmpty(departamento.Text))
            {
                MessageBox.Show("Debes ingresar un departamento.", "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(String.IsNullOrEmpty(ip.Text))
            {
                MessageBox.Show("Debes ingresar una IP.", "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Convert.ToInt32((Impresora.SelectedItem as dynamic).Value) < 1)
            {
                MessageBox.Show("Debes ingresar una impresora.", "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                using (SqlConnection conexion2 = new SqlConnection(Form1.conexionsqllast))
                {
                    String insert = "INSERT INTO Impresoras VALUES (" + Convert.ToInt32((Impresora.SelectedItem as dynamic).Value) + ", '" + basetxt.Text + "', '" + departamento.Text + "', '" + ip.Text + "', '" + estatus.Text + "', '" + comentarios.Text + "')";
                    conexion2.Open();
                    SqlCommand comm2 = new SqlCommand(insert, conexion2);
                    comm2.ExecuteReader(); 
                    MessageBox.Show("Impresora guardada.", "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error al guardar la impresora\n\nMensaje: " + ex.Message, "Impresoras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
