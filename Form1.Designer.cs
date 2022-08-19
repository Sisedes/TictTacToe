namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.player2Score = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.kare9 = new System.Windows.Forms.Button();
            this.kare8 = new System.Windows.Forms.Button();
            this.kare7 = new System.Windows.Forms.Button();
            this.kare6 = new System.Windows.Forms.Button();
            this.kare5 = new System.Windows.Forms.Button();
            this.kare4 = new System.Windows.Forms.Button();
            this.kare3 = new System.Windows.Forms.Button();
            this.kare2 = new System.Windows.Forms.Button();
            this.kare1 = new System.Windows.Forms.Button();
            this.siyah4 = new System.Windows.Forms.Panel();
            this.siyah3 = new System.Windows.Forms.Panel();
            this.siyah2 = new System.Windows.Forms.Panel();
            this.siyah1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.player2Score);
            this.mainPanel.Controls.Add(this.player1Score);
            this.mainPanel.Controls.Add(this.player2);
            this.mainPanel.Controls.Add(this.player1);
            this.mainPanel.Controls.Add(this.restartButton);
            this.mainPanel.Controls.Add(this.kare9);
            this.mainPanel.Controls.Add(this.kare8);
            this.mainPanel.Controls.Add(this.kare7);
            this.mainPanel.Controls.Add(this.kare6);
            this.mainPanel.Controls.Add(this.kare5);
            this.mainPanel.Controls.Add(this.kare4);
            this.mainPanel.Controls.Add(this.kare3);
            this.mainPanel.Controls.Add(this.kare2);
            this.mainPanel.Controls.Add(this.kare1);
            this.mainPanel.Controls.Add(this.siyah4);
            this.mainPanel.Controls.Add(this.siyah3);
            this.mainPanel.Controls.Add(this.siyah2);
            this.mainPanel.Controls.Add(this.siyah1);
            this.mainPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 703);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Reset Score";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.Location = new System.Drawing.Point(400, 567);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(41, 40);
            this.player2Score.TabIndex = 19;
            this.player2Score.Text = "0";
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.Location = new System.Drawing.Point(52, 567);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(41, 40);
            this.player1Score.TabIndex = 18;
            this.player1Score.Text = "0";
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(387, 484);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(70, 70);
            this.player2.TabIndex = 17;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(39, 484);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(70, 70);
            this.player1.TabIndex = 16;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(165, 591);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(166, 27);
            this.restartButton.TabIndex = 15;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // kare9
            // 
            this.kare9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kare9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare9.Location = new System.Drawing.Point(337, 342);
            this.kare9.Name = "kare9";
            this.kare9.Size = new System.Drawing.Size(120, 120);
            this.kare9.TabIndex = 14;
            this.kare9.UseVisualStyleBackColor = false;
            this.kare9.Click += new System.EventHandler(this.kare9_Click_1);
            // 
            // kare8
            // 
            this.kare8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare8.Location = new System.Drawing.Point(188, 342);
            this.kare8.Name = "kare8";
            this.kare8.Size = new System.Drawing.Size(120, 120);
            this.kare8.TabIndex = 13;
            this.kare8.UseVisualStyleBackColor = true;
            this.kare8.Click += new System.EventHandler(this.kare8_Click_1);
            // 
            // kare7
            // 
            this.kare7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare7.Location = new System.Drawing.Point(39, 342);
            this.kare7.Name = "kare7";
            this.kare7.Size = new System.Drawing.Size(120, 120);
            this.kare7.TabIndex = 12;
            this.kare7.UseVisualStyleBackColor = true;
            this.kare7.Click += new System.EventHandler(this.kare7_Click_1);
            // 
            // kare6
            // 
            this.kare6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare6.Location = new System.Drawing.Point(337, 193);
            this.kare6.Name = "kare6";
            this.kare6.Size = new System.Drawing.Size(120, 120);
            this.kare6.TabIndex = 11;
            this.kare6.UseVisualStyleBackColor = true;
            this.kare6.Click += new System.EventHandler(this.kare6_Click);
            // 
            // kare5
            // 
            this.kare5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare5.Location = new System.Drawing.Point(188, 193);
            this.kare5.Name = "kare5";
            this.kare5.Size = new System.Drawing.Size(120, 120);
            this.kare5.TabIndex = 10;
            this.kare5.UseVisualStyleBackColor = true;
            this.kare5.Click += new System.EventHandler(this.kare5_Click);
            // 
            // kare4
            // 
            this.kare4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare4.Location = new System.Drawing.Point(39, 193);
            this.kare4.Name = "kare4";
            this.kare4.Size = new System.Drawing.Size(120, 120);
            this.kare4.TabIndex = 9;
            this.kare4.UseVisualStyleBackColor = true;
            this.kare4.Click += new System.EventHandler(this.kare4_Click);
            // 
            // kare3
            // 
            this.kare3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kare3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare3.Location = new System.Drawing.Point(337, 44);
            this.kare3.Name = "kare3";
            this.kare3.Size = new System.Drawing.Size(120, 120);
            this.kare3.TabIndex = 8;
            this.kare3.UseVisualStyleBackColor = false;
            this.kare3.Click += new System.EventHandler(this.kare3_Click);
            // 
            // kare2
            // 
            this.kare2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare2.Location = new System.Drawing.Point(188, 44);
            this.kare2.Name = "kare2";
            this.kare2.Size = new System.Drawing.Size(120, 120);
            this.kare2.TabIndex = 7;
            this.kare2.UseVisualStyleBackColor = true;
            this.kare2.Click += new System.EventHandler(this.kare2_Click);
            // 
            // kare1
            // 
            this.kare1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kare1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kare1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kare1.Location = new System.Drawing.Point(39, 44);
            this.kare1.Name = "kare1";
            this.kare1.Size = new System.Drawing.Size(120, 120);
            this.kare1.TabIndex = 0;
            this.kare1.UseVisualStyleBackColor = true;
            this.kare1.Click += new System.EventHandler(this.kare1_Click_1);
            // 
            // siyah4
            // 
            this.siyah4.BackColor = System.Drawing.SystemColors.ControlText;
            this.siyah4.Location = new System.Drawing.Point(39, 319);
            this.siyah4.Name = "siyah4";
            this.siyah4.Size = new System.Drawing.Size(418, 17);
            this.siyah4.TabIndex = 6;
            // 
            // siyah3
            // 
            this.siyah3.BackColor = System.Drawing.Color.Black;
            this.siyah3.Location = new System.Drawing.Point(39, 170);
            this.siyah3.Name = "siyah3";
            this.siyah3.Size = new System.Drawing.Size(418, 17);
            this.siyah3.TabIndex = 5;
            // 
            // siyah2
            // 
            this.siyah2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siyah2.Location = new System.Drawing.Point(314, 44);
            this.siyah2.Name = "siyah2";
            this.siyah2.Size = new System.Drawing.Size(17, 418);
            this.siyah2.TabIndex = 4;
            // 
            // siyah1
            // 
            this.siyah1.BackColor = System.Drawing.Color.Black;
            this.siyah1.Location = new System.Drawing.Point(165, 44);
            this.siyah1.Name = "siyah1";
            this.siyah1.Size = new System.Drawing.Size(17, 418);
            this.siyah1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 703);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel siyah4;
        private System.Windows.Forms.Panel siyah3;
        private System.Windows.Forms.Panel siyah2;
        private System.Windows.Forms.Panel siyah1;
        private System.Windows.Forms.Button kare9;
        private System.Windows.Forms.Button kare8;
        private System.Windows.Forms.Button kare7;
        private System.Windows.Forms.Button kare6;
        private System.Windows.Forms.Button kare5;
        private System.Windows.Forms.Button kare4;
        private System.Windows.Forms.Button kare3;
        private System.Windows.Forms.Button kare2;
        private System.Windows.Forms.Button kare1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Button button1;
    }
}

