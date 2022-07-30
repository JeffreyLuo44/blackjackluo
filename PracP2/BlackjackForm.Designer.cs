namespace PracP2
{
    partial class BlackjackForm
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
            this.buttonQuit_ = new System.Windows.Forms.Button();
            this.labelDealerTotal_ = new System.Windows.Forms.Label();
            this.textBoxDealerTotal_ = new System.Windows.Forms.TextBox();
            this.textBoxPlayerTotal_ = new System.Windows.Forms.TextBox();
            this.buttonDealSecondCard_ = new System.Windows.Forms.Button();
            this.labelMoneyLeft_ = new System.Windows.Forms.Label();
            this.textBoxMoneyLeft_ = new System.Windows.Forms.TextBox();
            this.labelMoneyToBet_ = new System.Windows.Forms.Label();
            this.textBoxBet_ = new System.Windows.Forms.TextBox();
            this.buttonDealFirstCard_ = new System.Windows.Forms.Button();
            this.textBoxWins = new System.Windows.Forms.TextBox();
            this.textBoxLosses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPlayerHand = new System.Windows.Forms.ListBox();
            this.listBoxDealerHand = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonQuit_
            // 
            this.buttonQuit_.Location = new System.Drawing.Point(363, 374);
            this.buttonQuit_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuit_.Name = "buttonQuit_";
            this.buttonQuit_.Size = new System.Drawing.Size(205, 34);
            this.buttonQuit_.TabIndex = 37;
            this.buttonQuit_.Text = "Quit";
            this.buttonQuit_.UseVisualStyleBackColor = true;
            this.buttonQuit_.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelDealerTotal_
            // 
            this.labelDealerTotal_.AutoSize = true;
            this.labelDealerTotal_.Location = new System.Drawing.Point(383, 160);
            this.labelDealerTotal_.Name = "labelDealerTotal_";
            this.labelDealerTotal_.Size = new System.Drawing.Size(133, 17);
            this.labelDealerTotal_.TabIndex = 36;
            this.labelDealerTotal_.Text = "Dealer\'s total points";
            // 
            // textBoxDealerTotal_
            // 
            this.textBoxDealerTotal_.Location = new System.Drawing.Point(363, 179);
            this.textBoxDealerTotal_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDealerTotal_.Name = "textBoxDealerTotal_";
            this.textBoxDealerTotal_.ReadOnly = true;
            this.textBoxDealerTotal_.Size = new System.Drawing.Size(176, 22);
            this.textBoxDealerTotal_.TabIndex = 34;
            this.textBoxDealerTotal_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPlayerTotal_
            // 
            this.textBoxPlayerTotal_.Location = new System.Drawing.Point(69, 179);
            this.textBoxPlayerTotal_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayerTotal_.Name = "textBoxPlayerTotal_";
            this.textBoxPlayerTotal_.ReadOnly = true;
            this.textBoxPlayerTotal_.Size = new System.Drawing.Size(169, 22);
            this.textBoxPlayerTotal_.TabIndex = 33;
            this.textBoxPlayerTotal_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDealSecondCard_
            // 
            this.buttonDealSecondCard_.Location = new System.Drawing.Point(363, 299);
            this.buttonDealSecondCard_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDealSecondCard_.Name = "buttonDealSecondCard_";
            this.buttonDealSecondCard_.Size = new System.Drawing.Size(205, 34);
            this.buttonDealSecondCard_.TabIndex = 32;
            this.buttonDealSecondCard_.Text = "Deal Final Card";
            this.buttonDealSecondCard_.UseVisualStyleBackColor = true;
            this.buttonDealSecondCard_.Click += new System.EventHandler(this.buttonDealSecondCard_Click);
            // 
            // labelMoneyLeft_
            // 
            this.labelMoneyLeft_.AutoSize = true;
            this.labelMoneyLeft_.Location = new System.Drawing.Point(53, 302);
            this.labelMoneyLeft_.Name = "labelMoneyLeft_";
            this.labelMoneyLeft_.Size = new System.Drawing.Size(73, 17);
            this.labelMoneyLeft_.TabIndex = 31;
            this.labelMoneyLeft_.Text = "Money left";
            // 
            // textBoxMoneyLeft_
            // 
            this.textBoxMoneyLeft_.Location = new System.Drawing.Point(148, 299);
            this.textBoxMoneyLeft_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMoneyLeft_.Name = "textBoxMoneyLeft_";
            this.textBoxMoneyLeft_.ReadOnly = true;
            this.textBoxMoneyLeft_.Size = new System.Drawing.Size(151, 22);
            this.textBoxMoneyLeft_.TabIndex = 30;
            // 
            // labelMoneyToBet_
            // 
            this.labelMoneyToBet_.AutoSize = true;
            this.labelMoneyToBet_.Location = new System.Drawing.Point(53, 342);
            this.labelMoneyToBet_.Name = "labelMoneyToBet_";
            this.labelMoneyToBet_.Size = new System.Drawing.Size(90, 17);
            this.labelMoneyToBet_.TabIndex = 29;
            this.labelMoneyToBet_.Text = "Money to bet";
            // 
            // textBoxBet_
            // 
            this.textBoxBet_.Location = new System.Drawing.Point(148, 338);
            this.textBoxBet_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBet_.Name = "textBoxBet_";
            this.textBoxBet_.Size = new System.Drawing.Size(151, 22);
            this.textBoxBet_.TabIndex = 24;
            // 
            // buttonDealFirstCard_
            // 
            this.buttonDealFirstCard_.Location = new System.Drawing.Point(363, 220);
            this.buttonDealFirstCard_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDealFirstCard_.Name = "buttonDealFirstCard_";
            this.buttonDealFirstCard_.Size = new System.Drawing.Size(205, 34);
            this.buttonDealFirstCard_.TabIndex = 19;
            this.buttonDealFirstCard_.Text = "Deal First Card";
            this.buttonDealFirstCard_.UseVisualStyleBackColor = true;
            this.buttonDealFirstCard_.Click += new System.EventHandler(this.buttonDealFirstCard_Click);
            // 
            // textBoxWins
            // 
            this.textBoxWins.Location = new System.Drawing.Point(148, 372);
            this.textBoxWins.Name = "textBoxWins";
            this.textBoxWins.ReadOnly = true;
            this.textBoxWins.Size = new System.Drawing.Size(100, 22);
            this.textBoxWins.TabIndex = 38;
            // 
            // textBoxLosses
            // 
            this.textBoxLosses.Location = new System.Drawing.Point(148, 400);
            this.textBoxLosses.Name = "textBoxLosses";
            this.textBoxLosses.ReadOnly = true;
            this.textBoxLosses.Size = new System.Drawing.Size(100, 22);
            this.textBoxLosses.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Losses";
            // 
            // listBoxPlayerHand
            // 
            this.listBoxPlayerHand.FormattingEnabled = true;
            this.listBoxPlayerHand.ItemHeight = 16;
            this.listBoxPlayerHand.Location = new System.Drawing.Point(93, 47);
            this.listBoxPlayerHand.Name = "listBoxPlayerHand";
            this.listBoxPlayerHand.Size = new System.Drawing.Size(128, 84);
            this.listBoxPlayerHand.TabIndex = 42;
            // 
            // listBoxDealerHand
            // 
            this.listBoxDealerHand.FormattingEnabled = true;
            this.listBoxDealerHand.ItemHeight = 16;
            this.listBoxDealerHand.Location = new System.Drawing.Point(386, 47);
            this.listBoxDealerHand.Name = "listBoxDealerHand";
            this.listBoxDealerHand.Size = new System.Drawing.Size(130, 84);
            this.listBoxDealerHand.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Player Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Dealer Hand";
            // 
            // buttonDeal
            // 
            this.buttonDeal.Location = new System.Drawing.Point(363, 259);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(205, 32);
            this.buttonDeal.TabIndex = 46;
            this.buttonDeal.Text = "Deal Extra card";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Player\'s total points";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Note: First, \"deal first card\" and then place bet";
            // 
            // BlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDeal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxDealerHand);
            this.Controls.Add(this.listBoxPlayerHand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLosses);
            this.Controls.Add(this.textBoxWins);
            this.Controls.Add(this.buttonQuit_);
            this.Controls.Add(this.labelDealerTotal_);
            this.Controls.Add(this.textBoxDealerTotal_);
            this.Controls.Add(this.textBoxPlayerTotal_);
            this.Controls.Add(this.buttonDealSecondCard_);
            this.Controls.Add(this.labelMoneyLeft_);
            this.Controls.Add(this.textBoxMoneyLeft_);
            this.Controls.Add(this.labelMoneyToBet_);
            this.Controls.Add(this.textBoxBet_);
            this.Controls.Add(this.buttonDealFirstCard_);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BlackjackForm";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit_;
        private System.Windows.Forms.Label labelDealerTotal_;
        private System.Windows.Forms.TextBox textBoxDealerTotal_;
        private System.Windows.Forms.TextBox textBoxPlayerTotal_;
        private System.Windows.Forms.Button buttonDealSecondCard_;
        private System.Windows.Forms.Label labelMoneyLeft_;
        private System.Windows.Forms.TextBox textBoxMoneyLeft_;
        private System.Windows.Forms.Label labelMoneyToBet_;
        private System.Windows.Forms.TextBox textBoxBet_;
        private System.Windows.Forms.Button buttonDealFirstCard_;
        private System.Windows.Forms.TextBox textBoxWins;
        private System.Windows.Forms.TextBox textBoxLosses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPlayerHand;
        private System.Windows.Forms.ListBox listBoxDealerHand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

