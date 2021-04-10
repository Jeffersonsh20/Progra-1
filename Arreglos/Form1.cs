using Arreglos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {

        private string[] ArregloNotas;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int[] Arreglos = new int [5];
            Arreglos[0] = 66;
            Arreglos[1] = 10;
            Arreglos[2] = 7;
            Arreglos[3] = 20;
            Arreglos[4] = 11;

            ClsArreglos ObjetoArreglo = new ClsArreglos(Arreglos);
            int[] resultado = ObjetoArreglo.MetodoBurbuja();


            foreach(int w in resultado)
            {
                listBoxResultado.Items.Add(w);
            }


        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ja = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Porfavor, Seleccionar tu Archivo plano";
            ofd.InitialDirectory = @"C:\Users\Jefferson Molina\OneDrive\Escritorio\Archivo\";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ja.LeerTodoArchivo(archivo);
                ArregloNotas = ja.LeerArchivo(archivo);
                textBoxResultado.Text = resultado;
            }
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                listBoxResultado.Items.Add(datosUnitarios[0]);
            }
        }

        private void buttonPromedioEstudiante_Click(object sender, EventArgs e)
        {
            int Primerlaboratorio;
            int segundolaboratio;
            int tercerlaboratorio;
            int Sumadelaboratoios;
            int promedioestudiante;
            int final;

            foreach (string otak in ArregloNotas)
            {
                string[] datosUnitarios = otak.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Primerlaboratorio = Convert.ToInt32(datosUnitarios[1]);
                segundolaboratio = Convert.ToInt32(datosUnitarios[2]);
                tercerlaboratorio = Convert.ToInt32(datosUnitarios[3]);

                Sumadelaboratoios = (Primerlaboratorio + segundolaboratio + tercerlaboratorio);
                promedioestudiante = Sumadelaboratoios / 3;
                final = promedioestudiante;

                listBoxResultado.Items.Add($"{datosUnitarios[1]} promedio de los parciales: {final}");
            }
        }

        private void buttonPromedioGeneral_Click(object sender, EventArgs e)
        {
            int Primerlaboratorio;
            int segundolaboratio;
            int tercerlaboratorio;
            int totalprimerlaboratorio = 0;
            int totalsegundolaboratorio = 0;
            int totaltercerlaboratorio = 0;
            int promedioprimerlaboratorio;
            int promediosegundolaboratorio;
            int promediotercerlaboratorio;

            foreach (string otak in ArregloNotas)
            {
                string[] datosUnitarios = otak.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Primerlaboratorio = Convert.ToInt32(datosUnitarios[1]);
                segundolaboratio = Convert.ToInt32(datosUnitarios[2]);
                tercerlaboratorio = Convert.ToInt32(datosUnitarios[3]);

                totalprimerlaboratorio += Primerlaboratorio;
                totalsegundolaboratorio += segundolaboratio;
                totaltercerlaboratorio += tercerlaboratorio;

            }

            promedioprimerlaboratorio = totalprimerlaboratorio / 60;
            promediosegundolaboratorio = totalsegundolaboratorio / 60;
            promediotercerlaboratorio = totaltercerlaboratorio / 60;


            listBoxResultado.Items.Add($" Promedio General del Primer Parcial:  {promedioprimerlaboratorio}");
            listBoxResultado.Items.Add($" Promedio General del Segundo Parcial: {promediosegundolaboratorio} ");
            listBoxResultado.Items.Add($"Promedio General del Tercer Parcial:  {promediotercerlaboratorio} ");


        }

        private void buttonNotaMaxNotaMin_Click(object sender, EventArgs e)
        {
            int Primerlaboratorio;
            int segundolaboratio;
            int tercerlaboratorio;
            int Sumadelaboratoios;
            int promedioestudiante;
            int final;
            int max = 0;
            int min = 20;

            foreach (string otak in ArregloNotas)
            {
                string[] datosUnitarios = otak.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Primerlaboratorio = Convert.ToInt32(datosUnitarios[1]);
                segundolaboratio = Convert.ToInt32(datosUnitarios[2]);
                tercerlaboratorio = Convert.ToInt32(datosUnitarios[3]);

                Sumadelaboratoios = (Primerlaboratorio + segundolaboratio + tercerlaboratorio);
                promedioestudiante = Sumadelaboratoios / 3;
                final = promedioestudiante;

                if (final !=0)
                {
                    if (final > max)
                    {
                        max = final;

                    }

                    if (final < min)
                    {
                        min = final;
                    }
                }

                else
                {
                    max = final;
                    min = final;
                }

            }

            listBoxResultado.Items.Add($"El Promedio Minimo de un Estudiante es: {min}, El promedio Maximo de un Estudiante es:  {max}");
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            string[] estudian = ArregloNotas;
            string fa;
            for (int lin = 1; lin <= estudian.Length; lin++)
            {
                for (int coloc = 0; coloc < estudian.Length - 1; coloc++)
                {
                    if (estudian[coloc].CompareTo(estudian[coloc + 1]) > 0)
                    {
                        fa = estudian[coloc];
                        estudian[coloc] = estudian[coloc + 1];
                        estudian[coloc + 1] = fa;
                    }
                }
            }
            foreach (string po in ArregloNotas)
            {
                string[] datosUnitarios = po.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                listBoxResultado.Items.Add(po);
            }
        }
    }
    
}
