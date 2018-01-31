namespace GameStoreForms
{
    partial class GameForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.GameId = new System.Windows.Forms.Label();
            this.GameDescription = new System.Windows.Forms.Label();
            this.GamePremiere = new System.Windows.Forms.Label();
            this.GameRating = new System.Windows.Forms.Label();
            //this.GameTypeId = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.Label();
            this.OrToBuy = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameId
            // 
            this.GameId.AutoSize = true;
            this.GameId.Location = new System.Drawing.Point(26, 25);
            this.GameId.Name = "GameId";
            this.GameId.Size = new System.Drawing.Size(16, 13);
            this.GameId.TabIndex = 1;
            this.GameId.Text = "Id";
            this.GameId.Click += new System.EventHandler(this.label1_Click);
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
            // GameTypeId
            // 
            //this.GameTypeId.AutoSize = true;
            //this.GameTypeId.Location = new System.Drawing.Point(48, 25);
            //this.GameTypeId.Name = "GameTypeId";
            //this.GameTypeId.Size = new System.Drawing.Size(40, 13);
            //this.GameTypeId.TabIndex = 1;
            //this.GameTypeId.Text = "TypeId";
            //this.GameTypeId.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Location = new System.Drawing.Point(93, 25);
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
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(29, 42);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(13, 20);
            this.textId.TabIndex = 2;
            // 
            // textTypeId
            // 
            this.textTypeId.Location = new System.Drawing.Point(51, 42);
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
            this.textName.Location = new System.Drawing.Point(96, 42);
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 307);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textOrToBuy);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPremiere);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textTypeId);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.NameFileRecomended);
            this.Controls.Add(this.NameFileNews);
            this.Controls.Add(this.NameFileBestseller);
            this.Controls.Add(this.OrRecommended);
            this.Controls.Add(this.OrToBuy);
            this.Controls.Add(this.GameRating);
            this.Controls.Add(this.GamePremiere);
            this.Controls.Add(this.GameDescription);
            this.Controls.Add(this.GameName);
            //this.Controls.Add(this.GameTypeId);
            this.Controls.Add(this.GameId);
            this.Controls.Add(this.button1);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GameId;
        private System.Windows.Forms.Label GameDescription;
        private System.Windows.Forms.Label GamePremiere;
        private System.Windows.Forms.Label GameRating;
        //private System.Windows.Forms.Label GameTypeId;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label OrToBuy;
        private System.Windows.Forms.TextBox textId;
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
    }
}

