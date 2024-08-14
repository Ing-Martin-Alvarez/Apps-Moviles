namespace Contador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.btna = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contador";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numero.Location = new System.Drawing.Point(342, 113);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(88, 106);
            this.numero.TabIndex = 1;
            this.numero.Text = "0";
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(113, 290);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(94, 29);
            this.btna.TabIndex = 2;
            this.btna.Text = "Aumentar";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(313, 290);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(136, 29);
            this.btnd.TabIndex = 3;
            this.btnd.Text = "Decrementar";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnr
            // 
            this.btnr.Location = new System.Drawing.Point(554, 290);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(94, 29);
            this.btnr.TabIndex = 4;
            this.btnr.Text = "Reiniciar";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(677, 367);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 52);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contador Maravilloso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label numero;
        private Button btna;
        private Button btnd;
        private Button btnr;
        private Button btnsalir;
    }
}