namespace GoruntuislemeProgrami
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbIslenmemis = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbIslenmis = new System.Windows.Forms.PictureBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnIsle = new System.Windows.Forms.Button();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblDeger = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIslenmemis)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIslenmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbIslenmemis);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlenmemiş Fotoğraf";
            // 
            // pbIslenmemis
            // 
            this.pbIslenmemis.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbIslenmemis.Location = new System.Drawing.Point(12, 35);
            this.pbIslenmemis.Name = "pbIslenmemis";
            this.pbIslenmemis.Size = new System.Drawing.Size(611, 530);
            this.pbIslenmemis.TabIndex = 0;
            this.pbIslenmemis.TabStop = false;
            this.pbIslenmemis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbIslenmemis_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbIslenmis);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(671, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 571);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlenmiş Fotoğraf";
            // 
            // pbIslenmis
            // 
            this.pbIslenmis.Location = new System.Drawing.Point(6, 35);
            this.pbIslenmis.Name = "pbIslenmis";
            this.pbIslenmis.Size = new System.Drawing.Size(617, 530);
            this.pbIslenmis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIslenmis.TabIndex = 1;
            this.pbIslenmis.TabStop = false;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(12, 589);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(90, 37);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "YÜKLE";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnIsle
            // 
            this.btnIsle.Location = new System.Drawing.Point(1210, 589);
            this.btnIsle.Name = "btnIsle";
            this.btnIsle.Size = new System.Drawing.Size(90, 37);
            this.btnIsle.TabIndex = 3;
            this.btnIsle.Text = "İŞLE";
            this.btnIsle.UseVisualStyleBackColor = true;
            this.btnIsle.Click += new System.EventHandler(this.btnIsle_Click);
            // 
            // cmbIslem
            // 
            this.cmbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "Pixel Renk Okuma",
            "Negatif Alma",
            "Grileştirme",
            "Siyah Beyaz",
            "Parlaklık"});
            this.cmbIslem.Location = new System.Drawing.Point(108, 594);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(211, 33);
            this.cmbIslem.TabIndex = 4;
            this.cmbIslem.SelectedIndexChanged += new System.EventHandler(this.cmbIslem_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(325, 589);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = -50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(753, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger.Location = new System.Drawing.Point(1084, 593);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(27, 29);
            this.lblDeger.TabIndex = 6;
            this.lblDeger.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1312, 629);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.btnIsle);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü İşleme Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIslenmemis)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIslenmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbIslenmemis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbIslenmis;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnIsle;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblDeger;
    }
}

