namespace AkilliLojistikSistemi
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
            lstLog = new ListBox();
            cmbRol = new ComboBox();
            label1 = new Label();
            btnStok = new Button();
            cmbKargo = new ComboBox();
            label2 = new Label();
            cmbOdeme = new ComboBox();
            label3 = new Label();
            btnSiparis = new Button();
            label4 = new Label();
            cmbUrun = new ComboBox();
            chkSigorta = new CheckBox();
            chkKirilacak = new CheckBox();
            lblStok = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnIptalIade = new Button();
            tabPage2 = new TabPage();
            btnDurumIlerlet = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(6, 44);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(766, 304);
            lstLog.TabIndex = 3;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(129, 6);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(137, 28);
            cmbRol.TabIndex = 4;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 5;
            label1.Text = "Giriş Yapan Rol:";
            // 
            // btnStok
            // 
            btnStok.Location = new Point(6, 9);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(151, 29);
            btnStok.TabIndex = 6;
            btnStok.Text = "Stok Güncelle (Proxy Testi)";
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // cmbKargo
            // 
            cmbKargo.FormattingEnabled = true;
            cmbKargo.Location = new Point(105, 48);
            cmbKargo.Name = "cmbKargo";
            cmbKargo.Size = new Size(151, 28);
            cmbKargo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "Kargo Seç:";
            // 
            // cmbOdeme
            // 
            cmbOdeme.FormattingEnabled = true;
            cmbOdeme.Location = new Point(105, 95);
            cmbOdeme.Name = "cmbOdeme";
            cmbOdeme.Size = new Size(151, 28);
            cmbOdeme.TabIndex = 9;
            cmbOdeme.SelectedIndexChanged += cmbOdeme_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 10;
            label3.Text = "Ödeme seç:";
            // 
            // btnSiparis
            // 
            btnSiparis.Location = new Point(6, 286);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(151, 29);
            btnSiparis.TabIndex = 11;
            btnSiparis.Text = "Siparişi Tamamla";
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 12);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Ürün Seç:";
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(88, 9);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(189, 28);
            cmbUrun.TabIndex = 13;
            cmbUrun.SelectedIndexChanged += cmbUrun_SelectedIndexChanged;
            // 
            // chkSigorta
            // 
            chkSigorta.AutoSize = true;
            chkSigorta.Location = new Point(6, 145);
            chkSigorta.Name = "chkSigorta";
            chkSigorta.Size = new Size(216, 24);
            chkSigorta.TabIndex = 14;
            chkSigorta.Text = "Sigortalı Gönderim (+50 TL)";
            chkSigorta.UseVisualStyleBackColor = true;
            // 
            // chkKirilacak
            // 
            chkKirilacak.AutoSize = true;
            chkKirilacak.Location = new Point(6, 184);
            chkKirilacak.Name = "chkKirilacak";
            chkKirilacak.Size = new Size(191, 24);
            chkKirilacak.TabIndex = 15;
            chkKirilacak.Text = "Kırılacak Eşya (+%20 TL)";
            chkKirilacak.UseVisualStyleBackColor = true;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(283, 12);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(51, 20);
            lblStok.TabIndex = 16;
            lblStok.Text = "Stok: -";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 398);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnIptalIade);
            tabPage1.Controls.Add(cmbUrun);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(chkKirilacak);
            tabPage1.Controls.Add(lblStok);
            tabPage1.Controls.Add(chkSigorta);
            tabPage1.Controls.Add(cmbKargo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cmbOdeme);
            tabPage1.Controls.Add(btnSiparis);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 365);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Müşteri Paneli";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnIptalIade
            // 
            btnIptalIade.Location = new Point(163, 286);
            btnIptalIade.Name = "btnIptalIade";
            btnIptalIade.Size = new Size(118, 29);
            btnIptalIade.TabIndex = 19;
            btnIptalIade.Text = "İptal / İade Et";
            btnIptalIade.UseVisualStyleBackColor = true;
            btnIptalIade.Click += btnIptalIade_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDurumIlerlet);
            tabPage2.Controls.Add(lstLog);
            tabPage2.Controls.Add(btnStok);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 365);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Yönetim ve Depo  Sorumlusu Paneli";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDurumIlerlet
            // 
            btnDurumIlerlet.Location = new Point(177, 9);
            btnDurumIlerlet.Name = "btnDurumIlerlet";
            btnDurumIlerlet.Size = new Size(159, 29);
            btnDurumIlerlet.TabIndex = 18;
            btnDurumIlerlet.Text = "Siparişi İlerlet";
            btnDurumIlerlet.UseVisualStyleBackColor = true;
            btnDurumIlerlet.Click += btnDurumuIlerlet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(cmbRol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRol;
        private Label label1;
        private Button btnStok;
        private ComboBox cmbKargo;
        private Label label2;
        private ComboBox cmbOdeme;
        private Label label3;
        private Button btnSiparis;
        private ListBox lstLog;
        private Label label4;
        private ComboBox cmbUrun;
        private CheckBox chkSigorta;
        private CheckBox chkKirilacak;
        private Label lblStok;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnDurumIlerlet;
        private Button btnIptalIade;
    }
}
