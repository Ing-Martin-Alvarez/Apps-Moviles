namespace ControlDeslizante
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
            this.txtdelizante = new System.Windows.Forms.TextBox();
            this.tbrojo = new System.Windows.Forms.TrackBar();
            this.tbazul = new System.Windows.Forms.TrackBar();
            this.tbverde = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btncolor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbazul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbverde)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdelizante
            // 
            this.txtdelizante.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdelizante.Location = new System.Drawing.Point(199, 68);
            this.txtdelizante.Multiline = true;
            this.txtdelizante.Name = "txtdelizante";
            this.txtdelizante.Size = new System.Drawing.Size(413, 129);
            this.txtdelizante.TabIndex = 0;
            this.txtdelizante.Text = "0";
            this.txtdelizante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbrojo
            // 
            this.tbrojo.Location = new System.Drawing.Point(199, 233);
            this.tbrojo.Maximum = 255;
            this.tbrojo.Name = "tbrojo";
            this.tbrojo.Size = new System.Drawing.Size(421, 56);
            this.tbrojo.TabIndex = 1;
            this.tbrojo.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbazul
            // 
            this.tbazul.Location = new System.Drawing.Point(199, 283);
            this.tbazul.Maximum = 255;
            this.tbazul.Name = "tbazul";
            this.tbazul.Size = new System.Drawing.Size(421, 56);
            this.tbazul.TabIndex = 2;
            this.tbazul.Scroll += new System.EventHandler(this.tbazul_Scroll);
            // 
            // tbverde
            // 
            this.tbverde.Location = new System.Drawing.Point(199, 345);
            this.tbverde.Maximum = 255;
            this.tbverde.Name = "tbverde";
            this.tbverde.Size = new System.Drawing.Size(421, 56);
            this.tbverde.TabIndex = 3;
            this.tbverde.Scroll += new System.EventHandler(this.tbverde_Scroll);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(327, 407);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(125, 42);
            this.btncolor.TabIndex = 4;
            this.btncolor.Text = "Asignar Color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.tbverde);
            this.Controls.Add(this.tbazul);
            this.Controls.Add(this.tbrojo);
            this.Controls.Add(this.txtdelizante);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbrojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbazul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbverde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtdelizante;
        private TrackBar tbrojo;
        private TrackBar tbazul;
        private TrackBar tbverde;
        private ColorDialog colorDialog1;
        private Button btncolor;
    }
}