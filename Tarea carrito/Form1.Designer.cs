
namespace Tarea_carrito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonInicio = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonAltoTotal = new System.Windows.Forms.Button();
            this.buttonCambioVelocidad = new System.Windows.Forms.Button();
            this.labelCambios = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInicio.ForeColor = System.Drawing.Color.White;
            this.buttonInicio.Location = new System.Drawing.Point(470, 30);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(145, 52);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Crear Carro";
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(115, 111);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(46, 17);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "label1";
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEncender.ForeColor = System.Drawing.Color.White;
            this.buttonEncender.Location = new System.Drawing.Point(597, 200);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(91, 73);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender el Carro";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAcelerar.ForeColor = System.Drawing.Color.White;
            this.buttonAcelerar.Location = new System.Drawing.Point(597, 425);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(80, 58);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(115, 265);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(46, 17);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "label1";
            // 
            // buttonAltoTotal
            // 
            this.buttonAltoTotal.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAltoTotal.ForeColor = System.Drawing.Color.White;
            this.buttonAltoTotal.Location = new System.Drawing.Point(452, 440);
            this.buttonAltoTotal.Name = "buttonAltoTotal";
            this.buttonAltoTotal.Size = new System.Drawing.Size(82, 63);
            this.buttonAltoTotal.TabIndex = 6;
            this.buttonAltoTotal.Text = "Alto Total";
            this.buttonAltoTotal.UseVisualStyleBackColor = false;
            this.buttonAltoTotal.Visible = false;
            this.buttonAltoTotal.Click += new System.EventHandler(this.buttonAltoTotal_Click);
            // 
            // buttonCambioVelocidad
            // 
            this.buttonCambioVelocidad.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCambioVelocidad.ForeColor = System.Drawing.Color.White;
            this.buttonCambioVelocidad.Location = new System.Drawing.Point(725, 353);
            this.buttonCambioVelocidad.Name = "buttonCambioVelocidad";
            this.buttonCambioVelocidad.Size = new System.Drawing.Size(115, 119);
            this.buttonCambioVelocidad.TabIndex = 7;
            this.buttonCambioVelocidad.Text = "Cambio";
            this.buttonCambioVelocidad.UseVisualStyleBackColor = false;
            this.buttonCambioVelocidad.Click += new System.EventHandler(this.buttonCambioVelocidad_Click);
            // 
            // labelCambios
            // 
            this.labelCambios.AutoSize = true;
            this.labelCambios.Location = new System.Drawing.Point(115, 317);
            this.labelCambios.Name = "labelCambios";
            this.labelCambios.Size = new System.Drawing.Size(46, 17);
            this.labelCambios.TabIndex = 8;
            this.labelCambios.Text = "label1";
            this.labelCambios.Click += new System.EventHandler(this.labelCambios_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(694, 232);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(240, 50);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 557);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelCambios);
            this.Controls.Add(this.buttonCambioVelocidad);
            this.Controls.Add(this.buttonAltoTotal);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonAltoTotal;
        private System.Windows.Forms.Button buttonCambioVelocidad;
        private System.Windows.Forms.Label labelCambios;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

