
namespace ARAÇ_KİRALAMA_OTOMASYONU
{
    partial class KullanıcıAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıAnaSayfa));
            this.btnaraclar = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAracKiralama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaraclar
            // 
            this.btnaraclar.BackColor = System.Drawing.Color.White;
            this.btnaraclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaraclar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaraclar.ImageIndex = 1;
            this.btnaraclar.ImageList = this.ımageList1;
            this.btnaraclar.Location = new System.Drawing.Point(162, 190);
            this.btnaraclar.Name = "btnaraclar";
            this.btnaraclar.Size = new System.Drawing.Size(123, 85);
            this.btnaraclar.TabIndex = 0;
            this.btnaraclar.Text = "ARAÇLAR";
            this.btnaraclar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaraclar.UseVisualStyleBackColor = false;
            this.btnaraclar.Click += new System.EventHandler(this.btnaraclar_Click);
            this.btnaraclar.MouseHover += new System.EventHandler(this.btnaraclar_MouseHover);
            this.btnaraclar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnaraclar_MouseMove);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kiralama_takip_640x640-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(1, "araçlar-removebg-preview.png");
            // 
            // btnAracKiralama
            // 
            this.btnAracKiralama.BackColor = System.Drawing.Color.White;
            this.btnAracKiralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracKiralama.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAracKiralama.ImageIndex = 0;
            this.btnAracKiralama.ImageList = this.ımageList1;
            this.btnAracKiralama.Location = new System.Drawing.Point(355, 190);
            this.btnAracKiralama.Name = "btnAracKiralama";
            this.btnAracKiralama.Size = new System.Drawing.Size(136, 85);
            this.btnAracKiralama.TabIndex = 1;
            this.btnAracKiralama.Text = "ARAÇ KİRALAMA";
            this.btnAracKiralama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracKiralama.UseVisualStyleBackColor = false;
            this.btnAracKiralama.Click += new System.EventHandler(this.btnAracKiralama_Click);
            this.btnAracKiralama.MouseHover += new System.EventHandler(this.btnAracKiralama_MouseHover);
            this.btnAracKiralama.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAracKiralama_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMİR ARAÇ KİRALAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "                              HOŞGELDİNİZ\r\nİDEAL  ARACINIZI KOLAY BİR ŞEKİDE KİRA" +
    "LAYINIZ!";
            // 
            // KullanıcıAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ARAÇ_KİRALAMA_OTOMASYONU.Properties.Resources.pexels_kelly_lacy_2519392;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAracKiralama);
            this.Controls.Add(this.btnaraclar);
            this.MaximumSize = new System.Drawing.Size(640, 385);
            this.MinimumSize = new System.Drawing.Size(640, 385);
            this.Name = "KullanıcıAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaraclar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAracKiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}