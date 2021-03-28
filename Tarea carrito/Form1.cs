using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_carrito.Class;

namespace Tarea_carrito
{
    public partial class Form1 : Form
    {
        ClsAutoMotor carrito;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("Audi", 130);
            carrito.color = "Blanco";

            buttonAcelerar.Visible = true;
            buttonAltoTotal.Visible = true;
            buttonEncender.Visible = true;
            buttonInicio.Visible = false;


            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");



        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {


                labelEstado.Text = $"El carrito {carrito.marca} : {carrito.encender()}";
            

        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {

            buttonAcelerar.Visible = carrito.cambios();

            if (carrito == null)
            {
                MessageBox.Show("Crea el Carro primero");
            }else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }

        }

        private void buttonBMW_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("BMW", 200, "Negro");

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void buttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha();

        }

        private void buttonCambioVelocidad_Click(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = carrito.cambios();
            buttonAcelerar.Show();
            labelCambios.Text = carrito.Xvelocidad();
        }

        private void labelCambios_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
