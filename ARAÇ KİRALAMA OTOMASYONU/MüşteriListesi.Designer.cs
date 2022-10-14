
namespace ARAÇ_KİRALAMA_OTOMASYONU
{
    partial class MüşteriListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşteriListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnmüsteriliste = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnmüsterisil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(690, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(-289, 618);
            this.button1.MaximumSize = new System.Drawing.Size(94, 29);
            this.button1.MinimumSize = new System.Drawing.Size(94, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "LİSTELE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 41);
            this.label7.TabIndex = 11;
            this.label7.Text = "MÜŞTERİ LİSTESİ";
            // 
            // btnmüsteriliste
            // 
            this.btnmüsteriliste.BackColor = System.Drawing.Color.Silver;
            this.btnmüsteriliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmüsteriliste.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmüsteriliste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmüsteriliste.ImageIndex = 0;
            this.btnmüsteriliste.ImageList = this.ımageList1;
            this.btnmüsteriliste.Location = new System.Drawing.Point(29, 80);
            this.btnmüsteriliste.Name = "btnmüsteriliste";
            this.btnmüsteriliste.Size = new System.Drawing.Size(125, 72);
            this.btnmüsteriliste.TabIndex = 12;
            this.btnmüsteriliste.Text = "LİSTELE";
            this.btnmüsteriliste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmüsteriliste.UseVisualStyleBackColor = false;
            this.btnmüsteriliste.Click += new System.EventHandler(this.btnmüsteriliste_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "müşteri_listeleme-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(1, "güncelle.png");
            this.ımageList1.Images.SetKeyName(2, "Sil-removebg-preview.png");
            // 
            // btnmüsterisil
            // 
            this.btnmüsterisil.BackColor = System.Drawing.Color.Red;
            this.btnmüsterisil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmüsterisil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmüsterisil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmüsterisil.ImageIndex = 2;
            this.btnmüsterisil.ImageList = this.ımageList1;
            this.btnmüsterisil.Location = new System.Drawing.Point(29, 395);
            this.btnmüsterisil.Name = "btnmüsterisil";
            this.btnmüsterisil.Size = new System.Drawing.Size(125, 70);
            this.btnmüsterisil.TabIndex = 14;
            this.btnmüsterisil.Text = "SİL";
            this.btnmüsterisil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmüsterisil.UseVisualStyleBackColor = false;
            this.btnmüsterisil.Click += new System.EventHandler(this.btnmüsterisil_Click);
            // 
            // MüşteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ARAÇ_KİRALAMA_OTOMASYONU.Properties.Resources.pexels_alex_montes_1820563;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 518);
            this.Controls.Add(this.btnmüsterisil);
            this.Controls.Add(this.btnmüsteriliste);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(760, 565);
            this.MinimumSize = new System.Drawing.Size(760, 565);
            this.Name = "MüşteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.MüşteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnmüsteriliste;
        private System.Windows.Forms.Button btnmüsterisil;
        private System.Windows.Forms.ImageList ımageList1;
    }
}