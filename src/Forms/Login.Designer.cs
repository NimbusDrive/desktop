namespace NimbusDrive
{
	partial class Login
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
			this.EmailBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// EmailBox
			// 
			this.EmailBox.Location = new System.Drawing.Point(12, 32);
			this.EmailBox.Name = "EmailBox";
			this.EmailBox.Size = new System.Drawing.Size(359, 26);
			this.EmailBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(12, 149);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(359, 40);
			this.LoginButton.TabIndex = 4;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Location = new System.Drawing.Point(12, 98);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(359, 26);
			this.PasswordBox.TabIndex = 5;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 201);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EmailBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.ShowIcon = false;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EmailBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox PasswordBox;
	}
}

