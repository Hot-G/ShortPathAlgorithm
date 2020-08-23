namespace shortpathprolab
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FindPathBtn = new System.Windows.Forms.Button();
            this.CityList = new System.Windows.Forms.ListBox();
            this.CityNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addcitytolistBtn = new System.Windows.Forms.Button();
            this.AddCityPanel = new System.Windows.Forms.Panel();
            this.RemoveCityToListBtn = new System.Windows.Forms.Button();
            this.DrawPathBorder = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MapImage = new System.Windows.Forms.PictureBox();
            this.VisitedCityList = new System.Windows.Forms.ListBox();
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.AddCityPanel.SuspendLayout();
            this.DrawPathBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FindPathBtn
            // 
            this.FindPathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FindPathBtn.Location = new System.Drawing.Point(27, 366);
            this.FindPathBtn.Name = "FindPathBtn";
            this.FindPathBtn.Size = new System.Drawing.Size(246, 84);
            this.FindPathBtn.TabIndex = 0;
            this.FindPathBtn.Text = "YOLU BUL";
            this.FindPathBtn.UseVisualStyleBackColor = true;
            this.FindPathBtn.Click += new System.EventHandler(this.FindPathBtn_Click);
            // 
            // CityList
            // 
            this.CityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CityList.FormattingEnabled = true;
            this.CityList.ItemHeight = 20;
            this.CityList.Location = new System.Drawing.Point(27, 96);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(246, 224);
            this.CityList.TabIndex = 1;
            // 
            // CityNames
            // 
            this.CityNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CityNames.FormattingEnabled = true;
            this.CityNames.Location = new System.Drawing.Point(27, 44);
            this.CityNames.Name = "CityNames";
            this.CityNames.Size = new System.Drawing.Size(181, 33);
            this.CityNames.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ŞEHİRLER";
            // 
            // addcitytolistBtn
            // 
            this.addcitytolistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addcitytolistBtn.Location = new System.Drawing.Point(215, 44);
            this.addcitytolistBtn.Name = "addcitytolistBtn";
            this.addcitytolistBtn.Size = new System.Drawing.Size(58, 33);
            this.addcitytolistBtn.TabIndex = 4;
            this.addcitytolistBtn.Text = "EKLE";
            this.addcitytolistBtn.UseVisualStyleBackColor = true;
            this.addcitytolistBtn.Click += new System.EventHandler(this.addcitytolistBtn_Click);
            // 
            // AddCityPanel
            // 
            this.AddCityPanel.Controls.Add(this.RemoveCityToListBtn);
            this.AddCityPanel.Controls.Add(this.label1);
            this.AddCityPanel.Controls.Add(this.addcitytolistBtn);
            this.AddCityPanel.Controls.Add(this.FindPathBtn);
            this.AddCityPanel.Controls.Add(this.CityList);
            this.AddCityPanel.Controls.Add(this.CityNames);
            this.AddCityPanel.Location = new System.Drawing.Point(0, 0);
            this.AddCityPanel.Name = "AddCityPanel";
            this.AddCityPanel.Size = new System.Drawing.Size(300, 470);
            this.AddCityPanel.TabIndex = 5;
            // 
            // RemoveCityToListBtn
            // 
            this.RemoveCityToListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveCityToListBtn.Location = new System.Drawing.Point(27, 327);
            this.RemoveCityToListBtn.Name = "RemoveCityToListBtn";
            this.RemoveCityToListBtn.Size = new System.Drawing.Size(246, 33);
            this.RemoveCityToListBtn.TabIndex = 5;
            this.RemoveCityToListBtn.Text = "SEÇİLİ ŞEHRİ LİSTEDEN KALDIR";
            this.RemoveCityToListBtn.UseVisualStyleBackColor = true;
            this.RemoveCityToListBtn.Click += new System.EventHandler(this.RemoveCityToListBtn_Click);
            // 
            // DrawPathBorder
            // 
            this.DrawPathBorder.Controls.Add(this.BackBtn);
            this.DrawPathBorder.Controls.Add(this.MapImage);
            this.DrawPathBorder.Controls.Add(this.VisitedCityList);
            this.DrawPathBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPathBorder.Location = new System.Drawing.Point(0, 0);
            this.DrawPathBorder.Name = "DrawPathBorder";
            this.DrawPathBorder.Size = new System.Drawing.Size(1179, 566);
            this.DrawPathBorder.TabIndex = 6;
            this.DrawPathBorder.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBtn.Location = new System.Drawing.Point(4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(98, 32);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "GERİ";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MapImage
            // 
            this.MapImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapImage.Image = ((System.Drawing.Image)(resources.GetObject("MapImage.Image")));
            this.MapImage.Location = new System.Drawing.Point(0, 0);
            this.MapImage.Name = "MapImage";
            this.MapImage.Size = new System.Drawing.Size(1006, 566);
            this.MapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapImage.TabIndex = 0;
            this.MapImage.TabStop = false;
            // 
            // VisitedCityList
            // 
            this.VisitedCityList.Dock = System.Windows.Forms.DockStyle.Right;
            this.VisitedCityList.FormattingEnabled = true;
            this.VisitedCityList.Location = new System.Drawing.Point(1006, 0);
            this.VisitedCityList.Name = "VisitedCityList";
            this.VisitedCityList.Size = new System.Drawing.Size(173, 566);
            this.VisitedCityList.TabIndex = 1;
            // 
            // DrawTimer
            // 
            this.DrawTimer.Interval = 600;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 566);
            this.Controls.Add(this.DrawPathBorder);
            this.Controls.Add(this.AddCityPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Yol Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddCityPanel.ResumeLayout(false);
            this.AddCityPanel.PerformLayout();
            this.DrawPathBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FindPathBtn;
        private System.Windows.Forms.ListBox CityList;
        private System.Windows.Forms.ComboBox CityNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addcitytolistBtn;
        private System.Windows.Forms.Panel AddCityPanel;
        private System.Windows.Forms.Panel DrawPathBorder;
        private System.Windows.Forms.PictureBox MapImage;
        private System.Windows.Forms.ListBox VisitedCityList;
        private System.Windows.Forms.Button RemoveCityToListBtn;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Button BackBtn;
    }
}

