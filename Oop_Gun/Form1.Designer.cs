
namespace Oop_Gun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpSarjor = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpAtesli = new System.Windows.Forms.GroupBox();
            this.btnUzaklastir = new System.Windows.Forms.Button();
            this.btnYakinlastir = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.grpKesici = new System.Windows.Forms.GroupBox();
            this.btnBileyle = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSarjor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpAtesli.SuspendLayout();
            this.grpKesici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSarjor
            // 
            this.grpSarjor.Controls.Add(this.pictureBox2);
            this.grpSarjor.Controls.Add(this.progressBar1);
            this.grpSarjor.Location = new System.Drawing.Point(480, 310);
            this.grpSarjor.Name = "grpSarjor";
            this.grpSarjor.Size = new System.Drawing.Size(150, 39);
            this.grpSarjor.TabIndex = 8;
            this.grpSarjor.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(114, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // grpAtesli
            // 
            this.grpAtesli.Controls.Add(this.btnUzaklastir);
            this.grpAtesli.Controls.Add(this.btnYakinlastir);
            this.grpAtesli.Controls.Add(this.btnReload);
            this.grpAtesli.Controls.Add(this.btnAtesEt);
            this.grpAtesli.Location = new System.Drawing.Point(301, 310);
            this.grpAtesli.Name = "grpAtesli";
            this.grpAtesli.Size = new System.Drawing.Size(173, 100);
            this.grpAtesli.TabIndex = 7;
            this.grpAtesli.TabStop = false;
            this.grpAtesli.Text = "Atesliler";
            // 
            // btnUzaklastir
            // 
            this.btnUzaklastir.Location = new System.Drawing.Point(88, 49);
            this.btnUzaklastir.Name = "btnUzaklastir";
            this.btnUzaklastir.Size = new System.Drawing.Size(75, 23);
            this.btnUzaklastir.TabIndex = 3;
            this.btnUzaklastir.Text = "Uzaklaştır";
            this.btnUzaklastir.UseVisualStyleBackColor = true;
            this.btnUzaklastir.Click += new System.EventHandler(this.btnUzaklastir_Click);
            // 
            // btnYakinlastir
            // 
            this.btnYakinlastir.Location = new System.Drawing.Point(88, 20);
            this.btnYakinlastir.Name = "btnYakinlastir";
            this.btnYakinlastir.Size = new System.Drawing.Size(75, 23);
            this.btnYakinlastir.TabIndex = 2;
            this.btnYakinlastir.Text = "Yakınlaştır";
            this.btnYakinlastir.UseVisualStyleBackColor = true;
            this.btnYakinlastir.Click += new System.EventHandler(this.btnYakinlastir_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(7, 50);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Location = new System.Drawing.Point(7, 20);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(75, 23);
            this.btnAtesEt.TabIndex = 0;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            // 
            // grpKesici
            // 
            this.grpKesici.Controls.Add(this.btnBileyle);
            this.grpKesici.Controls.Add(this.btnKes);
            this.grpKesici.Location = new System.Drawing.Point(186, 310);
            this.grpKesici.Name = "grpKesici";
            this.grpKesici.Size = new System.Drawing.Size(99, 100);
            this.grpKesici.TabIndex = 6;
            this.grpKesici.TabStop = false;
            this.grpKesici.Text = "Kesiciler";
            // 
            // btnBileyle
            // 
            this.btnBileyle.Location = new System.Drawing.Point(7, 58);
            this.btnBileyle.Name = "btnBileyle";
            this.btnBileyle.Size = new System.Drawing.Size(75, 23);
            this.btnBileyle.TabIndex = 1;
            this.btnBileyle.Text = "Bileyle";
            this.btnBileyle.UseVisualStyleBackColor = true;
            this.btnBileyle.Click += new System.EventHandler(this.btnBileyle_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(7, 29);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(75, 23);
            this.btnKes.TabIndex = 0;
            this.btnKes.Text = "Kes";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(170, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSarjor);
            this.Controls.Add(this.grpAtesli);
            this.Controls.Add(this.grpKesici);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.grpSarjor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpAtesli.ResumeLayout(false);
            this.grpKesici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSarjor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grpAtesli;
        private System.Windows.Forms.Button btnUzaklastir;
        private System.Windows.Forms.Button btnYakinlastir;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.GroupBox grpKesici;
        private System.Windows.Forms.Button btnBileyle;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

