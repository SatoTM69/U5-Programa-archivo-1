using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Programa_archivo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                string frase1 = textBox1.Text;
                string frase2 = textBox2.Text;
                string frase3 = textBox3.Text;

                string rutaArchivo = "FicheroFinal.txt";

                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    writer.WriteLine(frase1);
                    writer.WriteLine(frase2);
                    writer.WriteLine(frase3);
                }

                MessageBox.Show("Documento generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start("notepad.exe", Path.GetFullPath(rutaArchivo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
