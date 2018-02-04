namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    partial class Getdataformail
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
            this.recipientstext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.subjecttext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.messagetext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.submitdata = new MetroFramework.Controls.MetroButton();
            this.resetall = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // recipientstext
            // 
            this.recipientstext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recipientstext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.recipientstext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recipientstext.HintForeColor = System.Drawing.Color.Gray;
            this.recipientstext.HintText = "enter recipient address here";
            this.recipientstext.isPassword = false;
            this.recipientstext.LineFocusedColor = System.Drawing.Color.Blue;
            this.recipientstext.LineIdleColor = System.Drawing.Color.Gray;
            this.recipientstext.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.recipientstext.LineThickness = 3;
            this.recipientstext.Location = new System.Drawing.Point(121, 79);
            this.recipientstext.Margin = new System.Windows.Forms.Padding(4);
            this.recipientstext.Name = "recipientstext";
            this.recipientstext.Size = new System.Drawing.Size(270, 31);
            this.recipientstext.TabIndex = 0;
            this.recipientstext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // subjecttext
            // 
            this.subjecttext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subjecttext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.subjecttext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subjecttext.HintForeColor = System.Drawing.Color.Gray;
            this.subjecttext.HintText = "enter subject here";
            this.subjecttext.isPassword = false;
            this.subjecttext.LineFocusedColor = System.Drawing.Color.Blue;
            this.subjecttext.LineIdleColor = System.Drawing.Color.Gray;
            this.subjecttext.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.subjecttext.LineThickness = 3;
            this.subjecttext.Location = new System.Drawing.Point(121, 136);
            this.subjecttext.Margin = new System.Windows.Forms.Padding(4);
            this.subjecttext.Name = "subjecttext";
            this.subjecttext.Size = new System.Drawing.Size(270, 31);
            this.subjecttext.TabIndex = 1;
            this.subjecttext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.subjecttext.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // messagetext
            // 
            this.messagetext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messagetext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.messagetext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messagetext.HintForeColor = System.Drawing.Color.Gray;
            this.messagetext.HintText = "enter your message here";
            this.messagetext.isPassword = false;
            this.messagetext.LineFocusedColor = System.Drawing.Color.Blue;
            this.messagetext.LineIdleColor = System.Drawing.Color.Gray;
            this.messagetext.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.messagetext.LineThickness = 3;
            this.messagetext.Location = new System.Drawing.Point(121, 187);
            this.messagetext.Margin = new System.Windows.Forms.Padding(4);
            this.messagetext.Name = "messagetext";
            this.messagetext.Size = new System.Drawing.Size(270, 31);
            this.messagetext.TabIndex = 2;
            this.messagetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // submitdata
            // 
            this.submitdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.submitdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitdata.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.submitdata.ForeColor = System.Drawing.Color.LightGreen;
            this.submitdata.Location = new System.Drawing.Point(121, 245);
            this.submitdata.Name = "submitdata";
            this.submitdata.Size = new System.Drawing.Size(138, 35);
            this.submitdata.TabIndex = 4;
            this.submitdata.Text = "Submit";
            this.submitdata.UseSelectable = true;
            this.submitdata.Click += new System.EventHandler(this.submitdata_Click);
            // 
            // resetall
            // 
            this.resetall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.resetall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetall.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.resetall.ForeColor = System.Drawing.Color.LightGreen;
            this.resetall.Location = new System.Drawing.Point(275, 245);
            this.resetall.Name = "resetall";
            this.resetall.Size = new System.Drawing.Size(138, 35);
            this.resetall.TabIndex = 5;
            this.resetall.Text = "Reset All";
            this.resetall.UseSelectable = true;
            this.resetall.Click += new System.EventHandler(this.resetall_Click);
            // 
            // Getdataformail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 361);
            this.ControlBox = false;
            this.Controls.Add(this.resetall);
            this.Controls.Add(this.submitdata);
            this.Controls.Add(this.messagetext);
            this.Controls.Add(this.subjecttext);
            this.Controls.Add(this.recipientstext);
            this.Name = "Getdataformail";
            this.Text = "Get data for mail";
            this.Load += new System.EventHandler(this.Getdataformail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuMaterialTextbox subjecttext;
        public Bunifu.Framework.UI.BunifuMaterialTextbox recipientstext;
        public Bunifu.Framework.UI.BunifuMaterialTextbox messagetext;
        public MetroFramework.Controls.MetroButton submitdata;
        public MetroFramework.Controls.MetroButton resetall;
    }
}