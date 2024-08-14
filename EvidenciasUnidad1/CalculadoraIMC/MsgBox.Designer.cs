namespace Msg
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.pL1 = new System.Windows.Forms.Panel();
            this.pL2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.pbWar = new System.Windows.Forms.PictureBox();
            this.pbQue = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).BeginInit();
            this.SuspendLayout();
            // 
            // pL1
            // 
            this.pL1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pL1.Location = new System.Drawing.Point(-1, 98);
            this.pL1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pL1.Name = "pL1";
            this.pL1.Size = new System.Drawing.Size(563, 6);
            this.pL1.TabIndex = 0;
            // 
            // pL2
            // 
            this.pL2.BackColor = System.Drawing.Color.Silver;
            this.pL2.Location = new System.Drawing.Point(-1, 238);
            this.pL2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pL2.Name = "pL2";
            this.pL2.Size = new System.Drawing.Size(563, 6);
            this.pL2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(91, 38);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label1";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.Location = new System.Drawing.Point(16, 123);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(528, 98);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "label1";
            // 
            // pbError
            // 
            this.pbError.Image = ((System.Drawing.Image)(resources.GetObject("pbError.Image")));
            this.pbError.Location = new System.Drawing.Point(16, 18);
            this.pbError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(67, 77);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbError.TabIndex = 6;
            this.pbError.TabStop = false;
            this.pbError.Visible = false;
            // 
            // pbWar
            // 
            this.pbWar.Image = ((System.Drawing.Image)(resources.GetObject("pbWar.Image")));
            this.pbWar.Location = new System.Drawing.Point(16, 18);
            this.pbWar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbWar.Name = "pbWar";
            this.pbWar.Size = new System.Drawing.Size(67, 77);
            this.pbWar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWar.TabIndex = 5;
            this.pbWar.TabStop = false;
            this.pbWar.Visible = false;
            // 
            // pbQue
            // 
            this.pbQue.Image = ((System.Drawing.Image)(resources.GetObject("pbQue.Image")));
            this.pbQue.Location = new System.Drawing.Point(16, 18);
            this.pbQue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbQue.Name = "pbQue";
            this.pbQue.Size = new System.Drawing.Size(67, 77);
            this.pbQue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQue.TabIndex = 4;
            this.pbQue.TabStop = false;
            this.pbQue.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Olive;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(230)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(420, 254);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 46);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 308);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbError);
            this.Controls.Add(this.pbWar);
            this.Controls.Add(this.pbQue);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pL2);
            this.Controls.Add(this.pL1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            this.Load += new System.EventHandler(this.MsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pL1;
        private System.Windows.Forms.Panel pL2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pbQue;
        private System.Windows.Forms.PictureBox pbWar;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.Button btnOk;
    }
}