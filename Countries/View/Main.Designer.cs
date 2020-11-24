namespace Countries
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryInput = new System.Windows.Forms.TextBox();
            this.GetInfoButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.GetAllCountryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.DatabaseToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EditConfigToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountryInput
            // 
            this.CountryInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryInput.Location = new System.Drawing.Point(14, 39);
            this.CountryInput.Name = "CountryInput";
            this.CountryInput.Size = new System.Drawing.Size(316, 22);
            this.CountryInput.TabIndex = 0;
            // 
            // GetInfoButton
            // 
            this.GetInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetInfoButton.Location = new System.Drawing.Point(3, 3);
            this.GetInfoButton.Name = "GetInfoButton";
            this.GetInfoButton.Size = new System.Drawing.Size(174, 30);
            this.GetInfoButton.TabIndex = 1;
            this.GetInfoButton.Text = "Get country information";
            this.GetInfoButton.UseVisualStyleBackColor = true;
            this.GetInfoButton.Click += new System.EventHandler(this.GetInfoButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTextBox.Location = new System.Drawing.Point(12, 70);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.InfoTextBox.Size = new System.Drawing.Size(760, 411);
            this.InfoTextBox.TabIndex = 2;
            this.InfoTextBox.Text = "";
            // 
            // GetAllCountryButton
            // 
            this.GetAllCountryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetAllCountryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAllCountryButton.Location = new System.Drawing.Point(183, 3);
            this.GetAllCountryButton.Name = "GetAllCountryButton";
            this.GetAllCountryButton.Size = new System.Drawing.Size(250, 30);
            this.GetAllCountryButton.TabIndex = 3;
            this.GetAllCountryButton.Text = "Get all saved countries";
            this.GetAllCountryButton.UseVisualStyleBackColor = true;
            this.GetAllCountryButton.Click += new System.EventHandler(this.GetAllCountryButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.GetInfoButton);
            this.flowLayoutPanel1.Controls.Add(this.GetAllCountryButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(336, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 37);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatabaseToolStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(782, 28);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // DatabaseToolStrip
            // 
            this.DatabaseToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditConfigToolStrip});
            this.DatabaseToolStrip.Name = "DatabaseToolStrip";
            this.DatabaseToolStrip.Size = new System.Drawing.Size(84, 24);
            this.DatabaseToolStrip.Text = "Database";
            // 
            // EditConfigToolStrip
            // 
            this.EditConfigToolStrip.Name = "EditConfigToolStrip";
            this.EditConfigToolStrip.Size = new System.Drawing.Size(216, 26);
            this.EditConfigToolStrip.Text = "Edit config";
            this.EditConfigToolStrip.Click += new System.EventHandler(this.EditConfigToolStrip_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 483);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.CountryInput);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "Main";
            this.Text = "Country info";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountryInput;
        private System.Windows.Forms.Button GetInfoButton;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button GetAllCountryButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DatabaseToolStrip;
        private System.Windows.Forms.ToolStripMenuItem EditConfigToolStrip;
    }
}

