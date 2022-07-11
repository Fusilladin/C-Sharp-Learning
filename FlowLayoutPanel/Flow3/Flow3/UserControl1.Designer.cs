namespace Flow3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnBtn = new System.Windows.Forms.Button();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.UserNameTb = new System.Windows.Forms.TextBox();
            this.ServerTb = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnBtn
            // 
            this.ConnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnBtn.Location = new System.Drawing.Point(73, 492);
            this.ConnBtn.Name = "ConnBtn";
            this.ConnBtn.Size = new System.Drawing.Size(154, 53);
            this.ConnBtn.TabIndex = 14;
            this.ConnBtn.Text = "Connect";
            this.ConnBtn.UseVisualStyleBackColor = true;
            this.ConnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(73, 331);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(186, 20);
            this.PasswordTb.TabIndex = 13;
            // 
            // UserNameTb
            // 
            this.UserNameTb.Location = new System.Drawing.Point(73, 207);
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.Size = new System.Drawing.Size(186, 20);
            this.UserNameTb.TabIndex = 12;
            // 
            // ServerTb
            // 
            this.ServerTb.Location = new System.Drawing.Point(73, 73);
            this.ServerTb.Name = "ServerTb";
            this.ServerTb.Size = new System.Drawing.Size(186, 20);
            this.ServerTb.TabIndex = 11;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(99, 286);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(100, 24);
            this.PasswordLbl.TabIndex = 10;
            this.PasswordLbl.Text = "Password";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(99, 158);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(108, 24);
            this.UserNameLbl.TabIndex = 9;
            this.UserNameLbl.Text = "UserName";
            // 
            // ServerLbl
            // 
            this.ServerLbl.AutoSize = true;
            this.ServerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLbl.Location = new System.Drawing.Point(95, 36);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(132, 24);
            this.ServerLbl.TabIndex = 8;
            this.ServerLbl.Text = "Server Name";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ConnBtn);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UserNameTb);
            this.Controls.Add(this.ServerTb);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.ServerLbl);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(309, 571);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnBtn;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox UserNameTb;
        private System.Windows.Forms.TextBox ServerTb;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label ServerLbl;
    }
}
