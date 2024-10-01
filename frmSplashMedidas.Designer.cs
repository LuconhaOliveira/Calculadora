namespace Calculadora
{
    partial class frmSplashMedidas
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
            components = new System.ComponentModel.Container();
            tmrLoading = new System.Windows.Forms.Timer(components);
            pgbLoading = new ProgressBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tmrLoading
            // 
            tmrLoading.Enabled = true;
            tmrLoading.Interval = 1000;
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // pgbLoading
            // 
            pgbLoading.Location = new Point(12, 12);
            pgbLoading.Maximum = 7;
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(776, 30);
            pgbLoading.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.y2mate_com___CHAVES_A_venda_da_VILA_PARTE_13_480p;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 160);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label2";
            // 
            // frmSplashMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pgbLoading);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplashMedidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplashMedidas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrLoading;
        private ProgressBar pgbLoading;
        private PictureBox pictureBox1;
        private Label label1;
    }
}