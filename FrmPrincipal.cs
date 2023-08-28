using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace prySosaSp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("MiArchivo", false);

                MessageBox.Show("Archivo Creado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear archivo");
                
            }
            
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            StreamReader srManejoDeArchivo = new StreamReader("MiArchivo");
            while (srManejoDeArchivo.EndOfStream == false)
            {
                TxtDatos.Text += srManejoDeArchivo.ReadLine() + Environment.NewLine;
            }
            srManejoDeArchivo.Close();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter("MiArchivo", true);
                swManejoArchivo.WriteLine(TxtDatos.Text);
                swManejoArchivo.Close();

                MessageBox.Show("Archivo Grabado");
                TxtDatos.Text = "";
                TxtDatos.Focus();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error Al grabar" + Ex.Message);
                TxtDatos.Text = "";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDatos.Clear();
        }
    }
}
