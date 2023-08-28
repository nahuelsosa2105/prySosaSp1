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
                StreamWriter sw = new StreamWriter("MiArchivo", false);

                MessageBox.Show("Archivo Creado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear archivo");
                
            }
            
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {

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
            catch (Exception)
            {

                MessageBox.Show("Error Al grabar");
            }
        }
    }
}
