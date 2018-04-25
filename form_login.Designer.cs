namespace discEmbedTest
{
    partial class form_login
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
            this.button_login = new System.Windows.Forms.Button();
            this.text_token = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(12, 40);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(482, 54);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // text_token
            // 
            this.text_token.Location = new System.Drawing.Point(66, 12);
            this.text_token.Name = "text_token";
            this.text_token.Size = new System.Drawing.Size(428, 22);
            this.text_token.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Token";
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 106);
            this.Controls.Add(this.label);
            this.Controls.Add(this.text_token);
            this.Controls.Add(this.button_login);
            this.Name = "form_login";
            this.Text = "Embed Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox text_token;
        private System.Windows.Forms.Label label;
    }
}

