namespace ConnectionStringTester
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
			if(disposing && (components != null))
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
			this.DBTypeDropdown = new System.Windows.Forms.ComboBox();
			this.dbTypeLabel = new System.Windows.Forms.Label();
			this.connStrBox = new System.Windows.Forms.TextBox();
			this.connStrLabel = new System.Windows.Forms.Label();
			this.TestButton = new System.Windows.Forms.Button();
			this.checkMark = new System.Windows.Forms.Button();
			this.RedX = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DBTypeDropdown
			// 
			this.DBTypeDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.DBTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DBTypeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DBTypeDropdown.ForeColor = System.Drawing.SystemColors.Window;
			this.DBTypeDropdown.FormattingEnabled = true;
			this.DBTypeDropdown.Items.AddRange(new object[] {
            "SQL",
            "Oracle",
            "Pinpoint"});
			this.DBTypeDropdown.Location = new System.Drawing.Point(698, 203);
			this.DBTypeDropdown.Name = "DBTypeDropdown";
			this.DBTypeDropdown.Size = new System.Drawing.Size(194, 37);
			this.DBTypeDropdown.TabIndex = 0;
			this.DBTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.DBTypeDropdown_SelectedIndexChanged);
			// 
			// dbTypeLabel
			// 
			this.dbTypeLabel.AutoSize = true;
			this.dbTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dbTypeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.dbTypeLabel.Location = new System.Drawing.Point(693, 171);
			this.dbTypeLabel.Name = "dbTypeLabel";
			this.dbTypeLabel.Size = new System.Drawing.Size(107, 29);
			this.dbTypeLabel.TabIndex = 1;
			this.dbTypeLabel.Text = "DB Type";
			// 
			// connStrBox
			// 
			this.connStrBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.connStrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connStrBox.ForeColor = System.Drawing.SystemColors.Window;
			this.connStrBox.Location = new System.Drawing.Point(38, 203);
			this.connStrBox.Name = "connStrBox";
			this.connStrBox.Size = new System.Drawing.Size(615, 35);
			this.connStrBox.TabIndex = 2;
			this.connStrBox.TextChanged += new System.EventHandler(this.connStrBox_TextChanged);
			// 
			// connStrLabel
			// 
			this.connStrLabel.AutoSize = true;
			this.connStrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connStrLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.connStrLabel.Location = new System.Drawing.Point(33, 171);
			this.connStrLabel.Name = "connStrLabel";
			this.connStrLabel.Size = new System.Drawing.Size(204, 29);
			this.connStrLabel.TabIndex = 3;
			this.connStrLabel.Text = "Connection String";
			// 
			// TestButton
			// 
			this.TestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TestButton.Location = new System.Drawing.Point(331, 261);
			this.TestButton.Name = "TestButton";
			this.TestButton.Size = new System.Drawing.Size(232, 69);
			this.TestButton.TabIndex = 4;
			this.TestButton.Text = "Test";
			this.TestButton.UseVisualStyleBackColor = true;
			this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
			// 
			// checkMark
			// 
			this.checkMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.checkMark.BackgroundImage = global::ConnectionStringTester.Properties.Resources.GreenCheck1;
			this.checkMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.checkMark.Enabled = false;
			this.checkMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkMark.Location = new System.Drawing.Point(346, 373);
			this.checkMark.Name = "checkMark";
			this.checkMark.Size = new System.Drawing.Size(73, 67);
			this.checkMark.TabIndex = 6;
			this.checkMark.UseVisualStyleBackColor = false;
			this.checkMark.Visible = false;
			// 
			// RedX
			// 
			this.RedX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.RedX.BackgroundImage = global::ConnectionStringTester.Properties.Resources.Red_X;
			this.RedX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.RedX.Enabled = false;
			this.RedX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RedX.Location = new System.Drawing.Point(460, 373);
			this.RedX.Name = "RedX";
			this.RedX.Size = new System.Drawing.Size(73, 67);
			this.RedX.TabIndex = 7;
			this.RedX.UseVisualStyleBackColor = false;
			this.RedX.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(918, 497);
			this.Controls.Add(this.RedX);
			this.Controls.Add(this.checkMark);
			this.Controls.Add(this.TestButton);
			this.Controls.Add(this.connStrLabel);
			this.Controls.Add(this.connStrBox);
			this.Controls.Add(this.dbTypeLabel);
			this.Controls.Add(this.DBTypeDropdown);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox DBTypeDropdown;
		private System.Windows.Forms.Label dbTypeLabel;
		private System.Windows.Forms.TextBox connStrBox;
		private System.Windows.Forms.Label connStrLabel;
		private System.Windows.Forms.Button TestButton;
		private System.Windows.Forms.Button checkMark;
		private System.Windows.Forms.Button RedX;
	}
}

