namespace Fiblette
{
    partial class Form1
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
            System.Windows.Forms.Button btnInfo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLose = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStartingAmount = new System.Windows.Forms.Label();
            this.txtStartingAmount = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cbxEvenPayout = new System.Windows.Forms.CheckBox();
            this.lblStartingBet = new System.Windows.Forms.Label();
            this.txtStartingBet = new System.Windows.Forms.TextBox();
            btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnInfo.Location = new System.Drawing.Point(263, 154);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(32, 32);
            btnInfo.TabIndex = 10;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnWin
            // 
            this.btnWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWin.Location = new System.Drawing.Point(12, 363);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(150, 75);
            this.btnWin.TabIndex = 0;
            this.btnWin.Text = "WIN";
            this.btnWin.UseVisualStyleBackColor = false;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLose
            // 
            this.btnLose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLose.Location = new System.Drawing.Point(173, 363);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(150, 75);
            this.btnLose.TabIndex = 1;
            this.btnLose.Text = "LOSE";
            this.btnLose.UseVisualStyleBackColor = false;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(12, 202);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(311, 158);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartingAmount
            // 
            this.lblStartingAmount.AutoSize = true;
            this.lblStartingAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingAmount.ForeColor = System.Drawing.Color.White;
            this.lblStartingAmount.Location = new System.Drawing.Point(15, 21);
            this.lblStartingAmount.Name = "lblStartingAmount";
            this.lblStartingAmount.Size = new System.Drawing.Size(131, 21);
            this.lblStartingAmount.TabIndex = 3;
            this.lblStartingAmount.Text = "Starting Amount: ";
            // 
            // txtStartingAmount
            // 
            this.txtStartingAmount.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStartingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingAmount.Location = new System.Drawing.Point(201, 20);
            this.txtStartingAmount.Name = "txtStartingAmount";
            this.txtStartingAmount.Size = new System.Drawing.Size(94, 22);
            this.txtStartingAmount.TabIndex = 4;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(11, 158);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 21);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance :";
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(220, 108);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 31);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cbxEvenPayout
            // 
            this.cbxEvenPayout.AutoSize = true;
            this.cbxEvenPayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEvenPayout.ForeColor = System.Drawing.Color.White;
            this.cbxEvenPayout.Location = new System.Drawing.Point(19, 48);
            this.cbxEvenPayout.Name = "cbxEvenPayout";
            this.cbxEvenPayout.Size = new System.Drawing.Size(276, 25);
            this.cbxEvenPayout.TabIndex = 7;
            this.cbxEvenPayout.Text = "Are you playing even payouts? (1:1)";
            this.cbxEvenPayout.UseVisualStyleBackColor = true;
            // 
            // lblStartingBet
            // 
            this.lblStartingBet.AutoSize = true;
            this.lblStartingBet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingBet.ForeColor = System.Drawing.Color.White;
            this.lblStartingBet.Location = new System.Drawing.Point(15, 79);
            this.lblStartingBet.Name = "lblStartingBet";
            this.lblStartingBet.Size = new System.Drawing.Size(150, 21);
            this.lblStartingBet.TabIndex = 8;
            this.lblStartingBet.Text = "Enter your first bet : ";
            // 
            // txtStartingBet
            // 
            this.txtStartingBet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtStartingBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingBet.Location = new System.Drawing.Point(201, 78);
            this.txtStartingBet.Name = "txtStartingBet";
            this.txtStartingBet.Size = new System.Drawing.Size(94, 24);
            this.txtStartingBet.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(btnInfo);
            this.Controls.Add(this.txtStartingBet);
            this.Controls.Add(this.lblStartingBet);
            this.Controls.Add(this.cbxEvenPayout);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtStartingAmount);
            this.Controls.Add(this.lblStartingAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnLose);
            this.Controls.Add(this.btnWin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiblette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStartingAmount;
        private System.Windows.Forms.TextBox txtStartingAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.CheckBox cbxEvenPayout;
        private System.Windows.Forms.Label lblStartingBet;
        private System.Windows.Forms.TextBox txtStartingBet;
    }
}

