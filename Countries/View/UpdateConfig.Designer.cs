namespace Countries.View
{
    partial class UpdateConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReconnectButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ServerText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.DatabaseText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // ReconnectButton
            // 
            this.ReconnectButton.Location = new System.Drawing.Point(15, 154);
            this.ReconnectButton.Name = "ReconnectButton";
            this.ReconnectButton.Size = new System.Drawing.Size(90, 23);
            this.ReconnectButton.TabIndex = 4;
            this.ReconnectButton.Text = "Reconnect";
            this.ReconnectButton.UseVisualStyleBackColor = true;
            this.ReconnectButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(155, 154);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ServerText
            // 
            this.ServerText.Location = new System.Drawing.Point(91, 6);
            this.ServerText.Name = "ServerText";
            this.ServerText.Size = new System.Drawing.Size(139, 22);
            this.ServerText.TabIndex = 6;
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(91, 38);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(139, 22);
            this.UserText.TabIndex = 7;
            // 
            // DatabaseText
            // 
            this.DatabaseText.Location = new System.Drawing.Point(91, 74);
            this.DatabaseText.Name = "DatabaseText";
            this.DatabaseText.Size = new System.Drawing.Size(139, 22);
            this.DatabaseText.TabIndex = 8;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(91, 106);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(139, 22);
            this.PasswordText.TabIndex = 9;
            // 
            // UpdateConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 200);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.DatabaseText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.ServerText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ReconnectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 247);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(267, 247);
            this.Name = "UpdateConfig";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReconnectButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ServerText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox DatabaseText;
        private System.Windows.Forms.TextBox PasswordText;
    }
}