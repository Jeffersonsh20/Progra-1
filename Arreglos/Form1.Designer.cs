
namespace Arreglos
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonPromedioEstudiante = new System.Windows.Forms.Button();
            this.buttonPromedioGeneral = new System.Windows.Forms.Button();
            this.buttonNotaMaxNotaMin = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonArreglo.BackgroundImage")));
            this.buttonArreglo.ForeColor = System.Drawing.Color.White;
            this.buttonArreglo.Location = new System.Drawing.Point(862, 447);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(197, 58);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arreglo de Numeros";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(704, 66);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(563, 324);
            this.listBoxResultado.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(203, 37);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(441, 451);
            this.textBoxResultado.TabIndex = 2;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCargarArchivo.BackgroundImage")));
            this.buttonCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.buttonCargarArchivo.Location = new System.Drawing.Point(12, 37);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(142, 52);
            this.buttonCargarArchivo.TabIndex = 3;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // buttonNombres
            // 
            this.buttonNombres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNombres.BackgroundImage")));
            this.buttonNombres.ForeColor = System.Drawing.Color.White;
            this.buttonNombres.Location = new System.Drawing.Point(12, 117);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(142, 51);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonPromedioEstudiante
            // 
            this.buttonPromedioEstudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPromedioEstudiante.BackgroundImage")));
            this.buttonPromedioEstudiante.ForeColor = System.Drawing.Color.White;
            this.buttonPromedioEstudiante.Location = new System.Drawing.Point(12, 195);
            this.buttonPromedioEstudiante.Name = "buttonPromedioEstudiante";
            this.buttonPromedioEstudiante.Size = new System.Drawing.Size(159, 74);
            this.buttonPromedioEstudiante.TabIndex = 5;
            this.buttonPromedioEstudiante.Text = "Promedio de Estudiantes de Cada Parcial";
            this.buttonPromedioEstudiante.UseVisualStyleBackColor = true;
            this.buttonPromedioEstudiante.Click += new System.EventHandler(this.buttonPromedioEstudiante_Click);
            // 
            // buttonPromedioGeneral
            // 
            this.buttonPromedioGeneral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPromedioGeneral.BackgroundImage")));
            this.buttonPromedioGeneral.ForeColor = System.Drawing.Color.White;
            this.buttonPromedioGeneral.Location = new System.Drawing.Point(12, 295);
            this.buttonPromedioGeneral.Name = "buttonPromedioGeneral";
            this.buttonPromedioGeneral.Size = new System.Drawing.Size(153, 57);
            this.buttonPromedioGeneral.TabIndex = 6;
            this.buttonPromedioGeneral.Text = "Promedio General";
            this.buttonPromedioGeneral.UseVisualStyleBackColor = true;
            this.buttonPromedioGeneral.Click += new System.EventHandler(this.buttonPromedioGeneral_Click);
            // 
            // buttonNotaMaxNotaMin
            // 
            this.buttonNotaMaxNotaMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNotaMaxNotaMin.BackgroundImage")));
            this.buttonNotaMaxNotaMin.ForeColor = System.Drawing.Color.White;
            this.buttonNotaMaxNotaMin.Location = new System.Drawing.Point(12, 378);
            this.buttonNotaMaxNotaMin.Name = "buttonNotaMaxNotaMin";
            this.buttonNotaMaxNotaMin.Size = new System.Drawing.Size(153, 51);
            this.buttonNotaMaxNotaMin.TabIndex = 7;
            this.buttonNotaMaxNotaMin.Text = "Nota Maxima y Nota Minima";
            this.buttonNotaMaxNotaMin.UseVisualStyleBackColor = true;
            this.buttonNotaMaxNotaMin.Click += new System.EventHandler(this.buttonNotaMaxNotaMin_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOrdenar.BackgroundImage")));
            this.buttonOrdenar.ForeColor = System.Drawing.Color.White;
            this.buttonOrdenar.Location = new System.Drawing.Point(12, 455);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(159, 50);
            this.buttonOrdenar.TabIndex = 8;
            this.buttonOrdenar.Text = "Ordenar Alfabéticamente";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1325, 555);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonNotaMaxNotaMin);
            this.Controls.Add(this.buttonPromedioGeneral);
            this.Controls.Add(this.buttonPromedioEstudiante);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonPromedioEstudiante;
        private System.Windows.Forms.Button buttonPromedioGeneral;
        private System.Windows.Forms.Button buttonNotaMaxNotaMin;
        private System.Windows.Forms.Button buttonOrdenar;
    }
}

