namespace Fiblette
{
    partial class BalanceInfoForm
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
            this.lblMaxPosLStrk = new System.Windows.Forms.Label();
            this.lblSessionPL = new System.Windows.Forms.Label();
            this.lblSeshWL = new System.Windows.Forms.Label();
            this.lblMaxLStreak = new System.Windows.Forms.Label();
            this.lblPL = new System.Windows.Forms.Label();
            this.lblWL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaxPosLStrk
            // 
            this.lblMaxPosLStrk.AutoSize = true;
            this.lblMaxPosLStrk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPosLStrk.ForeColor = System.Drawing.Color.White;
            this.lblMaxPosLStrk.Location = new System.Drawing.Point(9, 9);
            this.lblMaxPosLStrk.Name = "lblMaxPosLStrk";
            this.lblMaxPosLStrk.Padding = new System.Windows.Forms.Padding(15);
            this.lblMaxPosLStrk.Size = new System.Drawing.Size(218, 51);
            this.lblMaxPosLStrk.TabIndex = 0;
            this.lblMaxPosLStrk.Text = "Max Possible Loss Streak :";
            // 
            // lblSessionPL
            // 
            this.lblSessionPL.AutoSize = true;
            this.lblSessionPL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionPL.ForeColor = System.Drawing.Color.White;
            this.lblSessionPL.Location = new System.Drawing.Point(12, 60);
            this.lblSessionPL.Name = "lblSessionPL";
            this.lblSessionPL.Padding = new System.Windows.Forms.Padding(15);
            this.lblSessionPL.Size = new System.Drawing.Size(179, 51);
            this.lblSessionPL.TabIndex = 1;
            this.lblSessionPL.Text = "Session Profit/Loss :";
            // 
            // lblSeshWL
            // 
            this.lblSeshWL.AutoSize = true;
            this.lblSeshWL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeshWL.ForeColor = System.Drawing.Color.White;
            this.lblSeshWL.Location = new System.Drawing.Point(12, 111);
            this.lblSeshWL.Name = "lblSeshWL";
            this.lblSeshWL.Padding = new System.Windows.Forms.Padding(15);
            this.lblSeshWL.Size = new System.Drawing.Size(199, 51);
            this.lblSeshWL.TabIndex = 2;
            this.lblSeshWL.Text = "Session Wins - Losses :";
            // 
            // lblMaxLStreak
            // 
            this.lblMaxLStreak.AutoSize = true;
            this.lblMaxLStreak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLStreak.ForeColor = System.Drawing.Color.White;
            this.lblMaxLStreak.Location = new System.Drawing.Point(233, 9);
            this.lblMaxLStreak.Name = "lblMaxLStreak";
            this.lblMaxLStreak.Padding = new System.Windows.Forms.Padding(15);
            this.lblMaxLStreak.Size = new System.Drawing.Size(30, 51);
            this.lblMaxLStreak.TabIndex = 3;
            // 
            // lblPL
            // 
            this.lblPL.AutoSize = true;
            this.lblPL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPL.ForeColor = System.Drawing.Color.White;
            this.lblPL.Location = new System.Drawing.Point(233, 60);
            this.lblPL.Name = "lblPL";
            this.lblPL.Padding = new System.Windows.Forms.Padding(15);
            this.lblPL.Size = new System.Drawing.Size(30, 51);
            this.lblPL.TabIndex = 4;
            // 
            // lblWL
            // 
            this.lblWL.AutoSize = true;
            this.lblWL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWL.ForeColor = System.Drawing.Color.White;
            this.lblWL.Location = new System.Drawing.Point(233, 111);
            this.lblWL.Name = "lblWL";
            this.lblWL.Padding = new System.Windows.Forms.Padding(15);
            this.lblWL.Size = new System.Drawing.Size(30, 51);
            this.lblWL.TabIndex = 5;
            // 
            // BalanceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(397, 176);
            this.Controls.Add(this.lblWL);
            this.Controls.Add(this.lblPL);
            this.Controls.Add(this.lblMaxLStreak);
            this.Controls.Add(this.lblSeshWL);
            this.Controls.Add(this.lblSessionPL);
            this.Controls.Add(this.lblMaxPosLStrk);
            this.Name = "BalanceInfoForm";
            this.Text = "BalanceInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxPosLStrk;
        private System.Windows.Forms.Label lblSessionPL;
        private System.Windows.Forms.Label lblSeshWL;
        private System.Windows.Forms.Label lblMaxLStreak;
        private System.Windows.Forms.Label lblPL;
        private System.Windows.Forms.Label lblWL;
    }
}