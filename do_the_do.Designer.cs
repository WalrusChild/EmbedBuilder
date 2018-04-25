namespace discEmbedTest
{
    partial class do_the_do
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
            this.button_send = new System.Windows.Forms.Button();
            this.text_title = new System.Windows.Forms.TextBox();
            this.check_title = new System.Windows.Forms.CheckBox();
            this.check_img = new System.Windows.Forms.CheckBox();
            this.text_img_url = new System.Windows.Forms.TextBox();
            this.check_desc = new System.Windows.Forms.CheckBox();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.check_footer = new System.Windows.Forms.CheckBox();
            this.text_footer = new System.Windows.Forms.TextBox();
            this.button_fields = new System.Windows.Forms.Button();
            this.label_sep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_guild_id = new System.Windows.Forms.TextBox();
            this.text_channel_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(12, 400);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(420, 70);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "Send Embed";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // text_title
            // 
            this.text_title.Enabled = false;
            this.text_title.Location = new System.Drawing.Point(12, 125);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(420, 22);
            this.text_title.TabIndex = 5;
            // 
            // check_title
            // 
            this.check_title.AutoSize = true;
            this.check_title.Location = new System.Drawing.Point(12, 98);
            this.check_title.Name = "check_title";
            this.check_title.Size = new System.Drawing.Size(105, 21);
            this.check_title.TabIndex = 6;
            this.check_title.Text = "Embed Title";
            this.check_title.UseVisualStyleBackColor = true;
            this.check_title.CheckedChanged += new System.EventHandler(this.check_title_CheckedChanged);
            // 
            // check_img
            // 
            this.check_img.AutoSize = true;
            this.check_img.Location = new System.Drawing.Point(12, 153);
            this.check_img.Name = "check_img";
            this.check_img.Size = new System.Drawing.Size(148, 21);
            this.check_img.TabIndex = 8;
            this.check_img.Text = "Embed Image URL";
            this.check_img.UseVisualStyleBackColor = true;
            this.check_img.CheckedChanged += new System.EventHandler(this.check_img_CheckedChanged);
            // 
            // text_img_url
            // 
            this.text_img_url.Enabled = false;
            this.text_img_url.Location = new System.Drawing.Point(12, 180);
            this.text_img_url.Name = "text_img_url";
            this.text_img_url.Size = new System.Drawing.Size(420, 22);
            this.text_img_url.TabIndex = 7;
            // 
            // check_desc
            // 
            this.check_desc.AutoSize = true;
            this.check_desc.Location = new System.Drawing.Point(12, 208);
            this.check_desc.Name = "check_desc";
            this.check_desc.Size = new System.Drawing.Size(149, 21);
            this.check_desc.TabIndex = 10;
            this.check_desc.Text = "Embed Description";
            this.check_desc.UseVisualStyleBackColor = true;
            this.check_desc.CheckedChanged += new System.EventHandler(this.check_desc_CheckedChanged);
            // 
            // text_desc
            // 
            this.text_desc.Enabled = false;
            this.text_desc.Location = new System.Drawing.Point(12, 235);
            this.text_desc.Name = "text_desc";
            this.text_desc.Size = new System.Drawing.Size(420, 22);
            this.text_desc.TabIndex = 9;
            // 
            // check_footer
            // 
            this.check_footer.AutoSize = true;
            this.check_footer.Location = new System.Drawing.Point(12, 263);
            this.check_footer.Name = "check_footer";
            this.check_footer.Size = new System.Drawing.Size(119, 21);
            this.check_footer.TabIndex = 12;
            this.check_footer.Text = "Embed Footer";
            this.check_footer.UseVisualStyleBackColor = true;
            this.check_footer.CheckedChanged += new System.EventHandler(this.check_footer_CheckedChanged);
            // 
            // text_footer
            // 
            this.text_footer.Enabled = false;
            this.text_footer.Location = new System.Drawing.Point(12, 290);
            this.text_footer.Name = "text_footer";
            this.text_footer.Size = new System.Drawing.Size(420, 22);
            this.text_footer.TabIndex = 11;
            // 
            // button_fields
            // 
            this.button_fields.Location = new System.Drawing.Point(12, 318);
            this.button_fields.Name = "button_fields";
            this.button_fields.Size = new System.Drawing.Size(420, 35);
            this.button_fields.TabIndex = 13;
            this.button_fields.Text = "Fields (WIP)";
            this.button_fields.UseVisualStyleBackColor = true;
            this.button_fields.Click += new System.EventHandler(this.button_fields_Click);
            // 
            // label_sep
            // 
            this.label_sep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_sep.Location = new System.Drawing.Point(12, 375);
            this.label_sep.Name = "label_sep";
            this.label_sep.Size = new System.Drawing.Size(420, 2);
            this.label_sep.TabIndex = 14;
            this.label_sep.Text = "label1";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 2);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Guild ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Channel ID";
            // 
            // text_guild_id
            // 
            this.text_guild_id.Location = new System.Drawing.Point(95, 12);
            this.text_guild_id.Name = "text_guild_id";
            this.text_guild_id.Size = new System.Drawing.Size(337, 22);
            this.text_guild_id.TabIndex = 18;
            // 
            // text_channel_id
            // 
            this.text_channel_id.Location = new System.Drawing.Point(95, 40);
            this.text_channel_id.Name = "text_channel_id";
            this.text_channel_id.Size = new System.Drawing.Size(337, 22);
            this.text_channel_id.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Creator";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // do_the_do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_channel_id);
            this.Controls.Add(this.text_guild_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_sep);
            this.Controls.Add(this.button_fields);
            this.Controls.Add(this.check_footer);
            this.Controls.Add(this.text_footer);
            this.Controls.Add(this.check_desc);
            this.Controls.Add(this.text_desc);
            this.Controls.Add(this.check_img);
            this.Controls.Add(this.text_img_url);
            this.Controls.Add(this.check_title);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.button_send);
            this.Name = "do_the_do";
            this.Text = "Embed Creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.do_the_do_FormClosed);
            this.Load += new System.EventHandler(this.do_the_do_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.CheckBox check_title;
        private System.Windows.Forms.CheckBox check_img;
        private System.Windows.Forms.TextBox text_img_url;
        private System.Windows.Forms.CheckBox check_desc;
        private System.Windows.Forms.TextBox text_desc;
        private System.Windows.Forms.CheckBox check_footer;
        private System.Windows.Forms.TextBox text_footer;
        private System.Windows.Forms.Button button_fields;
        private System.Windows.Forms.Label label_sep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_guild_id;
        private System.Windows.Forms.TextBox text_channel_id;
        private System.Windows.Forms.Label label4;
    }
}