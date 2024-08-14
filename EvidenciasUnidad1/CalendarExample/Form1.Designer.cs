namespace CalendarExample
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
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbformato = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(273, 69);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(250, 27);
            this.calendar.TabIndex = 0;
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(328, 133);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(125, 27);
            this.txtfecha.TabIndex = 1;
            // 
            // txthora
            // 
            this.txthora.Enabled = false;
            this.txthora.Location = new System.Drawing.Point(328, 197);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(125, 27);
            this.txthora.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona Fecha";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(342, 291);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 29);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Fecha";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora";
            // 
            // cbformato
            // 
            this.cbformato.AutoSize = true;
            this.cbformato.Location = new System.Drawing.Point(273, 248);
            this.cbformato.Name = "cbformato";
            this.cbformato.Size = new System.Drawing.Size(247, 24);
            this.cbformato.TabIndex = 8;
            this.cbformato.Text = "Formato de fecha dia, mes y año";
            this.cbformato.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbformato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.calendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker calendar;
        private TextBox txtfecha;
        private TextBox txthora;
        private Label label1;
        private Button btnConsultar;
        private Label label2;
        private Label label3;
        private CheckBox cbformato;
    }
}