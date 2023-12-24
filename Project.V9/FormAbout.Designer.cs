namespace Project.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxDeveloper_EIH = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_EIH = new System.Windows.Forms.TextBox();
            this.buttonCloseWindow_EIH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_EIH)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDeveloper_EIH
            // 
            this.pictureBoxDeveloper_EIH.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDeveloper_EIH.Image")));
            this.pictureBoxDeveloper_EIH.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDeveloper_EIH.Name = "pictureBoxDeveloper_EIH";
            this.pictureBoxDeveloper_EIH.Size = new System.Drawing.Size(224, 234);
            this.pictureBoxDeveloper_EIH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeveloper_EIH.TabIndex = 0;
            this.pictureBoxDeveloper_EIH.TabStop = false;
            // 
            // textBoxInfo_EIH
            // 
            this.textBoxInfo_EIH.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxInfo_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfo_EIH.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo_EIH.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxInfo_EIH.Location = new System.Drawing.Point(243, 12);
            this.textBoxInfo_EIH.Multiline = true;
            this.textBoxInfo_EIH.Name = "textBoxInfo_EIH";
            this.textBoxInfo_EIH.ReadOnly = true;
            this.textBoxInfo_EIH.Size = new System.Drawing.Size(458, 178);
            this.textBoxInfo_EIH.TabIndex = 1;
            this.textBoxInfo_EIH.Text = resources.GetString("textBoxInfo_EIH.Text");
            // 
            // buttonCloseWindow_EIH
            // 
            this.buttonCloseWindow_EIH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCloseWindow_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWindow_EIH.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseWindow_EIH.Location = new System.Drawing.Point(647, 196);
            this.buttonCloseWindow_EIH.Name = "buttonCloseWindow_EIH";
            this.buttonCloseWindow_EIH.Size = new System.Drawing.Size(50, 50);
            this.buttonCloseWindow_EIH.TabIndex = 2;
            this.buttonCloseWindow_EIH.Text = "OK";
            this.buttonCloseWindow_EIH.UseVisualStyleBackColor = false;
            this.buttonCloseWindow_EIH.Click += new System.EventHandler(this.buttonCloseWindow_EIH_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(709, 258);
            this.Controls.Add(this.buttonCloseWindow_EIH);
            this.Controls.Add(this.textBoxInfo_EIH);
            this.Controls.Add(this.pictureBoxDeveloper_EIH);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_EIH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDeveloper_EIH;
        private System.Windows.Forms.TextBox textBoxInfo_EIH;
        private System.Windows.Forms.Button buttonCloseWindow_EIH;
    }
}