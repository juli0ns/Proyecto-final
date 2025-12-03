namespace Proyecto_final
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelTitulo = new Label();
            labelDistancia = new Label();
            pictureEstado = new PictureBox();
            btnPrender = new Button();
            btnApagar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            labelHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            btnVerdeManual = new Button();
            btnAmarilloManual = new Button();
            btnNaranjaManual = new Button();
            btnRojoManual = new Button();
            btnApagarManual = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            trackBar1 = new TrackBar();
            panel4 = new Panel();
            pictureBox8 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            labelValor = new Label();
            comboBoxCOM = new ComboBox();
            comboBoxBaud = new ComboBox();
            btnConectar = new Button();
            btnDesconectar = new Button();
            panel6 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureEstado).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AccessibleName = "labelTitulo";
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelTitulo.Location = new Point(26, 3);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(240, 30);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Sensor de proximidad";
            // 
            // labelDistancia
            // 
            labelDistancia.AccessibleName = "labelDistancia";
            labelDistancia.AutoSize = true;
            labelDistancia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDistancia.Location = new Point(26, 46);
            labelDistancia.Name = "labelDistancia";
            labelDistancia.Size = new Size(88, 23);
            labelDistancia.TabIndex = 1;
            labelDistancia.Text = "Distancia:";
            // 
            // pictureEstado
            // 
            pictureEstado.AccessibleName = "pictureEstado";
            pictureEstado.Location = new Point(26, 83);
            pictureEstado.Name = "pictureEstado";
            pictureEstado.Size = new Size(125, 62);
            pictureEstado.TabIndex = 2;
            pictureEstado.TabStop = false;
            // 
            // btnPrender
            // 
            btnPrender.AccessibleName = "btnPrender";
            btnPrender.Font = new Font("Segoe UI", 10F);
            btnPrender.Location = new Point(157, 83);
            btnPrender.Name = "btnPrender";
            btnPrender.Size = new Size(94, 29);
            btnPrender.TabIndex = 3;
            btnPrender.Text = "Prender";
            btnPrender.UseVisualStyleBackColor = true;
            btnPrender.Click += btnPrender_Click;
            // 
            // btnApagar
            // 
            btnApagar.AccessibleName = "btnApagar";
            btnApagar.Location = new Point(157, 118);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(94, 29);
            btnApagar.TabIndex = 4;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnApagar);
            panel1.Controls.Add(btnPrender);
            panel1.Controls.Add(pictureEstado);
            panel1.Controls.Add(labelDistancia);
            panel1.Controls.Add(labelTitulo);
            panel1.Location = new Point(280, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 155);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(119, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 124);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 8;
            label1.Text = "Julio Duran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.Location = new Point(110, 126);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 9;
            label2.Text = "Marvin Prianti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 10;
            label3.Text = "Admins";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(22, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 155);
            panel2.TabIndex = 11;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 16F);
            labelHora.Location = new Point(19, 10);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(90, 37);
            labelHora.TabIndex = 12;
            labelHora.Text = "label4";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(labelHora);
            panel3.Location = new Point(22, 325);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 61);
            panel3.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(171, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 146);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // btnVerdeManual
            // 
            btnVerdeManual.BackColor = Color.FromArgb(192, 255, 192);
            btnVerdeManual.Location = new Point(14, 97);
            btnVerdeManual.Name = "btnVerdeManual";
            btnVerdeManual.Size = new Size(72, 29);
            btnVerdeManual.TabIndex = 15;
            btnVerdeManual.Text = "led verde";
            btnVerdeManual.UseVisualStyleBackColor = false;
            btnVerdeManual.Click += btnVerdeManual_Click;
            // 
            // btnAmarilloManual
            // 
            btnAmarilloManual.BackColor = Color.FromArgb(255, 255, 128);
            btnAmarilloManual.Location = new Point(92, 97);
            btnAmarilloManual.Name = "btnAmarilloManual";
            btnAmarilloManual.Size = new Size(73, 29);
            btnAmarilloManual.TabIndex = 16;
            btnAmarilloManual.Text = "led amarillo";
            btnAmarilloManual.UseVisualStyleBackColor = false;
            btnAmarilloManual.Click += btnAmarilloManual_Click;
            // 
            // btnNaranjaManual
            // 
            btnNaranjaManual.BackColor = Color.FromArgb(255, 192, 128);
            btnNaranjaManual.Location = new Point(171, 97);
            btnNaranjaManual.Name = "btnNaranjaManual";
            btnNaranjaManual.Size = new Size(72, 29);
            btnNaranjaManual.TabIndex = 17;
            btnNaranjaManual.Text = "led naranja";
            btnNaranjaManual.UseVisualStyleBackColor = false;
            btnNaranjaManual.Click += btnNaranjaManual_Click;
            // 
            // btnRojoManual
            // 
            btnRojoManual.BackColor = Color.FromArgb(255, 128, 128);
            btnRojoManual.Location = new Point(249, 97);
            btnRojoManual.Name = "btnRojoManual";
            btnRojoManual.Size = new Size(66, 29);
            btnRojoManual.TabIndex = 18;
            btnRojoManual.Text = "led rojo";
            btnRojoManual.UseVisualStyleBackColor = false;
            btnRojoManual.Click += btnRojoManual_Click;
            // 
            // btnApagarManual
            // 
            btnApagarManual.BackColor = Color.FromArgb(128, 128, 255);
            btnApagarManual.Location = new Point(109, 132);
            btnApagarManual.Name = "btnApagarManual";
            btnApagarManual.Size = new Size(114, 29);
            btnApagarManual.TabIndex = 19;
            btnApagarManual.Text = "apagar todos";
            btnApagarManual.UseVisualStyleBackColor = false;
            btnApagarManual.Click += btnApagarManual_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(92, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 87);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(171, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(72, 87);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(249, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(65, 87);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.ActiveCaptionText;
            trackBar1.Location = new Point(11, 74);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(340, 56);
            trackBar1.TabIndex = 24;
            trackBar1.TickFrequency = 5;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 255;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(btnApagarManual);
            panel4.Controls.Add(btnRojoManual);
            panel4.Controls.Add(btnNaranjaManual);
            panel4.Controls.Add(btnAmarilloManual);
            panel4.Controls.Add(btnVerdeManual);
            panel4.Location = new Point(570, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 174);
            panel4.TabIndex = 25;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(9, 6);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(125, 62);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(123, 6);
            label4.Name = "label4";
            label4.Size = new Size(191, 37);
            label4.TabIndex = 27;
            label4.Text = "Control PWM";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(labelValor);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox8);
            panel5.Controls.Add(trackBar1);
            panel5.Location = new Point(570, 192);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 136);
            panel5.TabIndex = 28;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelValor.ForeColor = SystemColors.ButtonFace;
            labelValor.Location = new Point(140, 51);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(44, 20);
            labelValor.TabIndex = 28;
            labelValor.Text = "valor";
            // 
            // comboBoxCOM
            // 
            comboBoxCOM.BackColor = SystemColors.HighlightText;
            comboBoxCOM.FormattingEnabled = true;
            comboBoxCOM.Location = new Point(22, 7);
            comboBoxCOM.Name = "comboBoxCOM";
            comboBoxCOM.Size = new Size(151, 28);
            comboBoxCOM.TabIndex = 29;
            // 
            // comboBoxBaud
            // 
            comboBoxBaud.FormattingEnabled = true;
            comboBoxBaud.Location = new Point(22, 41);
            comboBoxBaud.Name = "comboBoxBaud";
            comboBoxBaud.Size = new Size(151, 28);
            comboBoxBaud.TabIndex = 30;
            // 
            // btnConectar
            // 
            btnConectar.Font = new Font("Segoe UI", 7F);
            btnConectar.Location = new Point(22, 75);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(74, 32);
            btnConectar.TabIndex = 31;
            btnConectar.Text = "conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Font = new Font("Segoe UI", 6F);
            btnDesconectar.Location = new Point(102, 78);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(71, 29);
            btnDesconectar.TabIndex = 32;
            btnDesconectar.Text = "desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(btnDesconectar);
            panel6.Controls.Add(btnConectar);
            panel6.Controls.Add(comboBoxBaud);
            panel6.Controls.Add(comboBoxCOM);
            panel6.Location = new Point(372, 192);
            panel6.Name = "panel6";
            panel6.Size = new Size(192, 116);
            panel6.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(2, 22);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 34;
            label5.Text = "Miguel VIllarreal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(2, 45);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 35;
            label6.Text = "David Orozco";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(2, 73);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 36;
            label7.Text = "Michelle Vazquez";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 3);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 37;
            label8.Text = "integrantes";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(20, 170);
            panel7.Name = "panel7";
            panel7.Size = new Size(136, 105);
            panel7.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(943, 394);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureEstado).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitulo;
        private Label labelDistancia;
        private PictureBox pictureEstado;
        private Button btnPrender;
        private Button btnApagar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Button btnVerdeManual;
        private Button btnAmarilloManual;
        private Button btnNaranjaManual;
        private Button btnRojoManual;
        private Button btnApagarManual;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private TrackBar trackBar1;
        private Panel panel4;
        private PictureBox pictureBox8;
        private Label label4;
        private Panel panel5;
        private Label labelValor;
        private ComboBox comboBoxCOM;
        private ComboBox comboBoxBaud;
        private Button btnConectar;
        private Button btnDesconectar;
        private Panel panel6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel7;
    }
}
