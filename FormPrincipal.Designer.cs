namespace AsistenteDeReconocimiento
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureAuto = new System.Windows.Forms.PictureBox();
            this.pictureManu = new System.Windows.Forms.PictureBox();
            this.pictureSimple2 = new System.Windows.Forms.PictureBox();
            this.pictureSimpleOne = new System.Windows.Forms.PictureBox();
            this.btnSign = new AsistenteDeReconocimiento.BotonCircular();
            this.btnHelp = new AsistenteDeReconocimiento.BotonCircular();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureManu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimpleOne)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAuto
            // 
            this.pictureAuto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAuto.Image = ((System.Drawing.Image)(resources.GetObject("pictureAuto.Image")));
            this.pictureAuto.Location = new System.Drawing.Point(266, 46);
            this.pictureAuto.Name = "pictureAuto";
            this.pictureAuto.Size = new System.Drawing.Size(382, 565);
            this.pictureAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAuto.TabIndex = 0;
            this.pictureAuto.TabStop = false;
            // 
            // pictureManu
            // 
            this.pictureManu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureManu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureManu.Image = ((System.Drawing.Image)(resources.GetObject("pictureManu.Image")));
            this.pictureManu.Location = new System.Drawing.Point(774, 46);
            this.pictureManu.Name = "pictureManu";
            this.pictureManu.Size = new System.Drawing.Size(382, 565);
            this.pictureManu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureManu.TabIndex = 1;
            this.pictureManu.TabStop = false;
            // 
            // pictureSimple2
            // 
            this.pictureSimple2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureSimple2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureSimple2.Image = ((System.Drawing.Image)(resources.GetObject("pictureSimple2.Image")));
            this.pictureSimple2.Location = new System.Drawing.Point(1121, 617);
            this.pictureSimple2.Name = "pictureSimple2";
            this.pictureSimple2.Size = new System.Drawing.Size(35, 31);
            this.pictureSimple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSimple2.TabIndex = 5;
            this.pictureSimple2.TabStop = false;
            this.pictureSimple2.Visible = false;
            // 
            // pictureSimpleOne
            // 
            this.pictureSimpleOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureSimpleOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureSimpleOne.Image = ((System.Drawing.Image)(resources.GetObject("pictureSimpleOne.Image")));
            this.pictureSimpleOne.Location = new System.Drawing.Point(616, 617);
            this.pictureSimpleOne.Name = "pictureSimpleOne";
            this.pictureSimpleOne.Size = new System.Drawing.Size(32, 31);
            this.pictureSimpleOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSimpleOne.TabIndex = 6;
            this.pictureSimpleOne.TabStop = false;
            this.pictureSimpleOne.Visible = false;
            // 
            // btnSign
            // 
            this.btnSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSign.BackgroundImage")));
            this.btnSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Location = new System.Drawing.Point(1344, 587);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(39, 38);
            this.btnSign.TabIndex = 3;
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(1344, 631);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(39, 38);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 625);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 23);
            this.textBox1.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 681);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureSimpleOne);
            this.Controls.Add(this.pictureSimple2);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pictureManu);
            this.Controls.Add(this.pictureAuto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de Reconocimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureManu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimpleOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAuto;
        private System.Windows.Forms.PictureBox pictureManu;
        private BotonCircular btnHelp;
        private BotonCircular btnSign;
        private System.Windows.Forms.PictureBox pictureSimple2;
        private System.Windows.Forms.PictureBox pictureSimpleOne;
        private System.Windows.Forms.TextBox textBox1;
    }
}

