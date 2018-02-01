namespace WindowsFormsApp1
{
    partial class Gry
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.GameDescription = new System.Windows.Forms.Label();
            this.GamePremiere = new System.Windows.Forms.Label();
            this.GameRating = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.Label();
            this.OrToBuy = new System.Windows.Forms.Label();
            this.textTypeId = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textPremiere = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textOrToBuy = new System.Windows.Forms.TextBox();
            this.OrRecommended = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameFileBestseller = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NameFileNews = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NameFileRecomended = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.GameTypeID1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.GameID = new System.Windows.Forms.Label();
            this.textGameID = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(31, 189);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameDescription
            // 
            this.GameDescription.AutoSize = true;
            this.GameDescription.Location = new System.Drawing.Point(28, 71);
            this.GameDescription.Name = "GameDescription";
            this.GameDescription.Size = new System.Drawing.Size(60, 13);
            this.GameDescription.TabIndex = 1;
            this.GameDescription.Text = "Description";
            this.GameDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // GamePremiere
            // 
            this.GamePremiere.AutoSize = true;
            this.GamePremiere.Location = new System.Drawing.Point(28, 121);
            this.GamePremiere.Name = "GamePremiere";
            this.GamePremiere.Size = new System.Drawing.Size(48, 13);
            this.GamePremiere.TabIndex = 1;
            this.GamePremiere.Text = "Premiere";
            this.GamePremiere.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameRating
            // 
            this.GameRating.AutoSize = true;
            this.GameRating.Location = new System.Drawing.Point(82, 121);
            this.GameRating.Name = "GameRating";
            this.GameRating.Size = new System.Drawing.Size(38, 13);
            this.GameRating.TabIndex = 1;
            this.GameRating.Text = "Rating";
            this.GameRating.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Location = new System.Drawing.Point(126, 22);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(35, 13);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Name";
            this.GameName.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrToBuy
            // 
            this.OrToBuy.AutoSize = true;
            this.OrToBuy.Location = new System.Drawing.Point(126, 121);
            this.OrToBuy.Name = "OrToBuy";
            this.OrToBuy.Size = new System.Drawing.Size(49, 13);
            this.OrToBuy.TabIndex = 1;
            this.OrToBuy.Text = "OrToBuy";
            this.OrToBuy.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTypeId
            // 
            this.textTypeId.Location = new System.Drawing.Point(84, 39);
            this.textTypeId.Name = "textTypeId";
            this.textTypeId.Size = new System.Drawing.Size(37, 20);
            this.textTypeId.TabIndex = 2;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(31, 87);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(311, 20);
            this.textDescription.TabIndex = 2;
            this.textDescription.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textPremiere
            // 
            this.textPremiere.Location = new System.Drawing.Point(31, 137);
            this.textPremiere.Name = "textPremiere";
            this.textPremiere.Size = new System.Drawing.Size(45, 20);
            this.textPremiere.TabIndex = 2;
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(85, 137);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(35, 20);
            this.textRating.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(129, 39);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(246, 20);
            this.textName.TabIndex = 2;
            // 
            // textOrToBuy
            // 
            this.textOrToBuy.Location = new System.Drawing.Point(129, 137);
            this.textOrToBuy.Name = "textOrToBuy";
            this.textOrToBuy.Size = new System.Drawing.Size(46, 20);
            this.textOrToBuy.TabIndex = 2;
            this.textOrToBuy.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // OrRecommended
            // 
            this.OrRecommended.AutoSize = true;
            this.OrRecommended.Location = new System.Drawing.Point(181, 121);
            this.OrRecommended.Name = "OrRecommended";
            this.OrRecommended.Size = new System.Drawing.Size(90, 13);
            this.OrRecommended.TabIndex = 1;
            this.OrRecommended.Text = "OrRecommended";
            this.OrRecommended.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // NameFileBestseller
            // 
            this.NameFileBestseller.AutoSize = true;
            this.NameFileBestseller.Location = new System.Drawing.Point(236, 121);
            this.NameFileBestseller.Name = "NameFileBestseller";
            this.NameFileBestseller.Size = new System.Drawing.Size(96, 13);
            this.NameFileBestseller.TabIndex = 1;
            this.NameFileBestseller.Text = "NameFileBestseller";
            this.NameFileBestseller.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // NameFileNews
            // 
            this.NameFileNews.AutoSize = true;
            this.NameFileNews.Location = new System.Drawing.Point(291, 121);
            this.NameFileNews.Name = "NameFileNews";
            this.NameFileNews.Size = new System.Drawing.Size(78, 13);
            this.NameFileNews.TabIndex = 1;
            this.NameFileNews.Text = "NameFileNews";
            this.NameFileNews.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // NameFileRecomended
            // 
            this.NameFileRecomended.AutoSize = true;
            this.NameFileRecomended.Location = new System.Drawing.Point(346, 121);
            this.NameFileRecomended.Name = "NameFileRecomended";
            this.NameFileRecomended.Size = new System.Drawing.Size(115, 13);
            this.NameFileRecomended.TabIndex = 1;
            this.NameFileRecomended.Text = "NameFileRecomended";
            this.NameFileRecomended.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(349, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // GameTypeID1
            // 
            this.GameTypeID1.AutoSize = true;
            this.GameTypeID1.Location = new System.Drawing.Point(81, 22);
            this.GameTypeID1.Name = "GameTypeID1";
            this.GameTypeID1.Size = new System.Drawing.Size(42, 13);
            this.GameTypeID1.TabIndex = 1;
            this.GameTypeID1.Text = "TypeID";
            this.GameTypeID1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(129, 189);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 3;
            this.Update.Text = "Aktualizuj";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(239, 189);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Usuń";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // GameID
            // 
            this.GameID.AutoSize = true;
            this.GameID.Location = new System.Drawing.Point(28, 22);
            this.GameID.Name = "GameID";
            this.GameID.Size = new System.Drawing.Size(18, 13);
            this.GameID.TabIndex = 1;
            this.GameID.Text = "ID";
            this.GameID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textGameID
            // 
            this.textGameID.Location = new System.Drawing.Point(31, 39);
            this.textGameID.Name = "textGameID";
            this.textGameID.Size = new System.Drawing.Size(37, 20);
            this.textGameID.TabIndex = 2;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(31, 248);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 23);
            this.Select.TabIndex = 5;
            this.Select.Text = "Wybierz";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 230);
            this.dataGridView1.TabIndex = 6;
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(129, 248);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(185, 23);
            this.SelectAll.TabIndex = 7;
            this.SelectAll.Text = "Wybierz wszystkie";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Gry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textOrToBuy);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPremiere);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textGameID);
            this.Controls.Add(this.textTypeId);
            this.Controls.Add(this.NameFileRecomended);
            this.Controls.Add(this.NameFileNews);
            this.Controls.Add(this.NameFileBestseller);
            this.Controls.Add(this.OrRecommended);
            this.Controls.Add(this.OrToBuy);
            this.Controls.Add(this.GameRating);
            this.Controls.Add(this.GamePremiere);
            this.Controls.Add(this.GameID);
            this.Controls.Add(this.GameDescription);
            this.Controls.Add(this.GameTypeID1);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.Add);
            this.Name = "Gry";
            this.Text = "Gry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label GameDescription;
        private System.Windows.Forms.Label GamePremiere;
        private System.Windows.Forms.Label GameRating;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label OrToBuy;
        private System.Windows.Forms.TextBox textTypeId;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textPremiere;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textOrToBuy;
        private System.Windows.Forms.Label OrRecommended;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NameFileBestseller;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NameFileNews;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label NameFileRecomended;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label GameTypeID1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label GameID;
        private System.Windows.Forms.TextBox textGameID;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button button1;
    }
}