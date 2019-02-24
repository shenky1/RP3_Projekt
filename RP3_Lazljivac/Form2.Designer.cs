namespace RP3_Lazljivac
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Lista_Karata_Igrac = new System.Windows.Forms.ImageList(this.components);
            this.Lista_Karata_Racunalo = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lista_Karata_Stol = new System.Windows.Forms.ImageList(this.components);
            this.btn_dalje = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lista_Karata = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lazljivacDataSet1 = new RP3_Lazljivac.LazljivacDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_Karata_Igrac
            // 
            this.Lista_Karata_Igrac.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.Lista_Karata_Igrac.ImageSize = new System.Drawing.Size(100, 80);
            this.Lista_Karata_Igrac.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Lista_Karata_Racunalo
            // 
            this.Lista_Karata_Racunalo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Lista_Karata_Racunalo.ImageSize = new System.Drawing.Size(100, 60);
            this.Lista_Karata_Racunalo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trenutno na redu:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(511, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Otkrij kartu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "label";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lista_Karata_Stol
            // 
            this.Lista_Karata_Stol.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Lista_Karata_Stol.ImageSize = new System.Drawing.Size(100, 60);
            this.Lista_Karata_Stol.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_dalje
            // 
            this.btn_dalje.BackColor = System.Drawing.Color.LightGray;
            this.btn_dalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dalje.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dalje.Location = new System.Drawing.Point(511, 269);
            this.btn_dalje.Name = "btn_dalje";
            this.btn_dalje.Size = new System.Drawing.Size(101, 35);
            this.btn_dalje.TabIndex = 13;
            this.btn_dalje.Text = "Dalje";
            this.btn_dalje.UseVisualStyleBackColor = false;
            this.btn_dalje.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(160, 107);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(332, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 134);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(216, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Lista_Karata
            // 
            this.Lista_Karata.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Lista_Karata.ImageStream")));
            this.Lista_Karata.TransparentColor = System.Drawing.Color.Transparent;
            this.Lista_Karata.Images.SetKeyName(0, "karo (1).png");
            this.Lista_Karata.Images.SetKeyName(1, "karo (2).png");
            this.Lista_Karata.Images.SetKeyName(2, "karo (3).png");
            this.Lista_Karata.Images.SetKeyName(3, "karo (4).png");
            this.Lista_Karata.Images.SetKeyName(4, "karo (5).png");
            this.Lista_Karata.Images.SetKeyName(5, "karo (6).png");
            this.Lista_Karata.Images.SetKeyName(6, "karo (7).png");
            this.Lista_Karata.Images.SetKeyName(7, "karo (8).png");
            this.Lista_Karata.Images.SetKeyName(8, "karo (9).png");
            this.Lista_Karata.Images.SetKeyName(9, "karo (10).png");
            this.Lista_Karata.Images.SetKeyName(10, "karo (11).png");
            this.Lista_Karata.Images.SetKeyName(11, "karo (12).png");
            this.Lista_Karata.Images.SetKeyName(12, "karo (13).png");
            this.Lista_Karata.Images.SetKeyName(13, "pik (1).png");
            this.Lista_Karata.Images.SetKeyName(14, "pik (2).png");
            this.Lista_Karata.Images.SetKeyName(15, "pik (3).png");
            this.Lista_Karata.Images.SetKeyName(16, "pik (4).png");
            this.Lista_Karata.Images.SetKeyName(17, "pik (5).png");
            this.Lista_Karata.Images.SetKeyName(18, "pik (6).png");
            this.Lista_Karata.Images.SetKeyName(19, "pik (7).png");
            this.Lista_Karata.Images.SetKeyName(20, "pik (8).png");
            this.Lista_Karata.Images.SetKeyName(21, "pik (9).png");
            this.Lista_Karata.Images.SetKeyName(22, "pik (10).png");
            this.Lista_Karata.Images.SetKeyName(23, "pik (11).png");
            this.Lista_Karata.Images.SetKeyName(24, "pik (12).png");
            this.Lista_Karata.Images.SetKeyName(25, "pik (13).png");
            this.Lista_Karata.Images.SetKeyName(26, "srce (1).png");
            this.Lista_Karata.Images.SetKeyName(27, "srce (2).png");
            this.Lista_Karata.Images.SetKeyName(28, "srce (3).png");
            this.Lista_Karata.Images.SetKeyName(29, "srce (4).png");
            this.Lista_Karata.Images.SetKeyName(30, "srce (5).png");
            this.Lista_Karata.Images.SetKeyName(31, "srce (6).png");
            this.Lista_Karata.Images.SetKeyName(32, "srce (7).png");
            this.Lista_Karata.Images.SetKeyName(33, "srce (8).png");
            this.Lista_Karata.Images.SetKeyName(34, "srce (9).png");
            this.Lista_Karata.Images.SetKeyName(35, "srce (10).png");
            this.Lista_Karata.Images.SetKeyName(36, "srce (11).png");
            this.Lista_Karata.Images.SetKeyName(37, "srce (12).png");
            this.Lista_Karata.Images.SetKeyName(38, "srce (13).png");
            this.Lista_Karata.Images.SetKeyName(39, "tref (1).png");
            this.Lista_Karata.Images.SetKeyName(40, "tref (2).png");
            this.Lista_Karata.Images.SetKeyName(41, "tref (3).png");
            this.Lista_Karata.Images.SetKeyName(42, "tref (4).png");
            this.Lista_Karata.Images.SetKeyName(43, "tref (5).png");
            this.Lista_Karata.Images.SetKeyName(44, "tref (6).png");
            this.Lista_Karata.Images.SetKeyName(45, "tref (7).png");
            this.Lista_Karata.Images.SetKeyName(46, "tref (8).png");
            this.Lista_Karata.Images.SetKeyName(47, "tref (9).png");
            this.Lista_Karata.Images.SetKeyName(48, "tref (10).png");
            this.Lista_Karata.Images.SetKeyName(49, "tref (11).png");
            this.Lista_Karata.Images.SetKeyName(50, "tref (12).png");
            this.Lista_Karata.Images.SetKeyName(51, "tref (13).png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Računalo";
            // 
            // lazljivacDataSet1
            // 
            this.lazljivacDataSet1.DataSetName = "LazljivacDataSet";
            this.lazljivacDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(511, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Završi igru";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(272, 274);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 134);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(507, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(37, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Broj karata ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(37, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(280, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(280, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(495, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(216, 354);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 52);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(388, 354);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 52);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(213, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::RP3_Lazljivac.Properties.Resources.dijeli;
            this.ClientSize = new System.Drawing.Size(642, 439);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dalje);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList Lista_Karata_Igrac;
        private System.Windows.Forms.ImageList Lista_Karata_Racunalo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ImageList Lista_Karata_Stol;
        private System.Windows.Forms.Button btn_dalje;
        private System.Windows.Forms.ImageList Lista_Karata;
        private System.Windows.Forms.Label label1;
        private LazljivacDataSet lazljivacDataSet1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
    }
}