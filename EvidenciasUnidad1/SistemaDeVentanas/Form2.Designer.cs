namespace SistemaDeVentanas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnaccion = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnproceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(268, 126);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(279, 27);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnaccion
            // 
            this.btnaccion.Location = new System.Drawing.Point(325, 221);
            this.btnaccion.Name = "btnaccion";
            this.btnaccion.Size = new System.Drawing.Size(143, 29);
            this.btnaccion.TabIndex = 1;
            this.btnaccion.Text = "Ubicar Valor";
            this.btnaccion.UseVisualStyleBackColor = true;
            this.btnaccion.Click += new System.EventHandler(this.btnaccion_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 301);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(513, 44);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // btnproceso
            // 
            this.btnproceso.Location = new System.Drawing.Point(339, 366);
            this.btnproceso.Name = "btnproceso";
            this.btnproceso.Size = new System.Drawing.Size(94, 42);
            this.btnproceso.TabIndex = 3;
            this.btnproceso.Text = "proceso";
            this.btnproceso.UseVisualStyleBackColor = true;
            this.btnproceso.Click += new System.EventHandler(this.btnproceso_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnproceso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnaccion);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button btnaccion;
        private ProgressBar progressBar1;
        private Button btnproceso;
    }
}