namespace DosyaIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblBelgeYolu = new System.Windows.Forms.Label();
            this.lblBelgeAdi = new System.Windows.Forms.Label();
            this.txtBelgeYolu = new System.Windows.Forms.TextBox();
            this.txtBelgeAdi = new System.Windows.Forms.TextBox();
            this.btnKonumSec = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Folder Browser Dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(516, 65);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(217, 29);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(516, 100);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(217, 29);
            this.btnSaveFileDialog.TabIndex = 3;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // lblBelgeYolu
            // 
            this.lblBelgeYolu.AutoSize = true;
            this.lblBelgeYolu.Location = new System.Drawing.Point(28, 30);
            this.lblBelgeYolu.Name = "lblBelgeYolu";
            this.lblBelgeYolu.Size = new System.Drawing.Size(79, 20);
            this.lblBelgeYolu.TabIndex = 4;
            this.lblBelgeYolu.Text = "Belge Yolu";
            // 
            // lblBelgeAdi
            // 
            this.lblBelgeAdi.AutoSize = true;
            this.lblBelgeAdi.Location = new System.Drawing.Point(28, 69);
            this.lblBelgeAdi.Name = "lblBelgeAdi";
            this.lblBelgeAdi.Size = new System.Drawing.Size(74, 20);
            this.lblBelgeAdi.TabIndex = 5;
            this.lblBelgeAdi.Text = "Belge Adi";
            this.lblBelgeAdi.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBelgeYolu
            // 
            this.txtBelgeYolu.Location = new System.Drawing.Point(134, 31);
            this.txtBelgeYolu.Name = "txtBelgeYolu";
            this.txtBelgeYolu.Size = new System.Drawing.Size(200, 27);
            this.txtBelgeYolu.TabIndex = 6;
            // 
            // txtBelgeAdi
            // 
            this.txtBelgeAdi.Location = new System.Drawing.Point(138, 70);
            this.txtBelgeAdi.Name = "txtBelgeAdi";
            this.txtBelgeAdi.Size = new System.Drawing.Size(196, 27);
            this.txtBelgeAdi.TabIndex = 7;
            // 
            // btnKonumSec
            // 
            this.btnKonumSec.Location = new System.Drawing.Point(516, 135);
            this.btnKonumSec.Name = "btnKonumSec";
            this.btnKonumSec.Size = new System.Drawing.Size(217, 29);
            this.btnKonumSec.TabIndex = 8;
            this.btnKonumSec.Text = "Konum Seç";
            this.btnKonumSec.UseVisualStyleBackColor = true;
            this.btnKonumSec.Click += new System.EventHandler(this.btnKonumSec_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(516, 170);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(217, 29);
            this.btnOlustur.TabIndex = 9;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(139, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 244);
            this.listBox1.TabIndex = 10;
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(516, 205);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(217, 29);
            this.btnOku.TabIndex = 11;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnKonumSec);
            this.Controls.Add(this.txtBelgeAdi);
            this.Controls.Add(this.txtBelgeYolu);
            this.Controls.Add(this.lblBelgeAdi);
            this.Controls.Add(this.lblBelgeYolu);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnOpenFileDialog;
        private OpenFileDialog openFileDialog1;
        private Button btnSaveFileDialog;
        private SaveFileDialog saveFileDialog1;
        private Label lblBelgeYolu;
        private Label lblBelgeAdi;
        private TextBox txtBelgeYolu;
        private TextBox txtBelgeAdi;
        private Button btnKonumSec;
        private Button btnOlustur;
        private ListBox listBox1;
        private Button btnOku;
    }
}