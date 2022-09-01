using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpresorasUNNE
{
    public partial class Form1 : Form
    {
        private String versiontext = "3.0";
        private String version = "0c085700dcaa5782eb5599da77b4a3d7d5a92703";
        public static String conexionsqllast = "server=148.223.153.37,5314; database=InfEq;User ID=eordazs;Password=Corpame*2013; integrated security = false ; MultipleActiveResultSets=True";

        public static List<String[]> lista_impresoras = new List<String[]>();
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy != true)
            {
                buscar.Visible = false;
                dataGridView1.Visible = false;
                menuStrip1.Visible = false;
                label1.Visible = false;
                lista_impresoras.Clear();
                dataGridView1.Rows.Clear();
                pictureBox1.Enabled = true;
                pictureBox1.BringToFront();
                pictureBox1.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataGridView1.Columns["driver"].Index && e.RowIndex != -1)
            {
                Clipboard.SetText(dataGridView1.Rows[e.RowIndex].Cells["driverlink"].Value.ToString());
                MessageBox.Show("URL del driver\n\n" +
                    ""+ dataGridView1.Rows[e.RowIndex].Cells["marca"].Value.ToString()+" - " +
                    ""+ dataGridView1.Rows[e.RowIndex].Cells["modelo"].Value.ToString()+"" +
                    "\n\ncopiado al portapapeles.", "Impresoras UNNE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (!string.IsNullOrEmpty(buscar.Text))
            {
                foreach (String[] n in lista_impresoras)
                {
                    String nbase = n[2].ToString().ToUpper();
                    String ndepartamento = n[3].ToString().ToUpper();
                    if (nbase.Contains(buscar.Text.ToUpper()) || ndepartamento.Contains(buscar.Text))
                    {
                        dataGridView1.Rows.Add(n[8], n[9], n[2], n[3], n[4], n[5], "Copiar", n[10]);
                    }
                }
            }
            else
            {
                foreach (String[] n in lista_impresoras)
                {
                    dataGridView1.Rows.Add(n[8], n[9], n[2], n[3], n[4], n[5], "Copiar", n[10]);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Verificar version

            try
            {
                using (SqlConnection conexion2 = new SqlConnection(conexionsqllast))
                {
                    conexion2.Open();
                    String sql2 = "SELECT (SELECT valor FROM Configuracion WHERE nombre='Impresoras_Version') as version,valor FROM Configuracion WHERE nombre='Impresoras_hash'";
                    SqlCommand comm2 = new SqlCommand(sql2, conexion2);
                    SqlDataReader nwReader2 = comm2.ExecuteReader();
                    if (nwReader2.Read())
                    {
                        if (nwReader2["valor"].ToString() != version)
                        {
                            MessageBox.Show("No se puede inciar sesion porque hay una nueva version.\n\nNueva Version: " + nwReader2["version"].ToString() + "\nVersion actual: " + versiontext + "\n\nEl programa se cerrara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puedo verificar la version del programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validar la version del programa\n\nMensaje: " + ex.Message, "Información del Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            //Llenar lista de impresora
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionsqllast))
                {
                    conexion.Open();
                    SqlCommand comm = new SqlCommand("SELECT i.*, p.* FROM [InfEq].[dbo].[Impresoras] i INNER JOIN[InfEq].[dbo].[Impresoras_print] p ON i.impresora = p.pid", conexion);

                    SqlDataReader nwReader = comm.ExecuteReader();
                    while (nwReader.Read())
                    {
                        String[] n = new String[11];
                        n[0] = nwReader["id"].ToString();
                        n[1] = nwReader["impresora"].ToString();
                        n[2] = nwReader["base"].ToString();
                        n[3] = nwReader["departamento"].ToString();
                        n[4] = nwReader["ip"].ToString();
                        n[5] = nwReader["estatus"].ToString();
                        n[6] = nwReader["comentarios"].ToString();
                        n[7] = nwReader["pid"].ToString();
                        n[8] = nwReader["marca"].ToString();
                        n[9] = nwReader["modelo"].ToString();
                        n[10] = nwReader["driver"].ToString();
                        lista_impresoras.Add(n);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error en la busqueda\n\nMensaje: " + ex.Message, "Información del Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (lista_impresoras.Any())
            {
                foreach (String[] n in lista_impresoras)
                {
                    dataGridView1.Rows.Add(n[8], n[9], n[2], n[3], n[4], n[5], "Copiar", n[10]);
                }
            }
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            label1.Visible = true;
            menuStrip1.Visible = true;
            dataGridView1.Visible = true;
            buscar.Visible = true;
            buscar.Focus();
        }

    }
}
