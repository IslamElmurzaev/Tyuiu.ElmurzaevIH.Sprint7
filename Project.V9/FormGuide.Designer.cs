namespace Project.V9
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.textBoxGuide_EIH = new System.Windows.Forms.TextBox();
            this.buttonClose_EIH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGuide_EIH
            // 
            this.textBoxGuide_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGuide_EIH.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuide_EIH.Location = new System.Drawing.Point(12, 12);
            this.textBoxGuide_EIH.Multiline = true;
            this.textBoxGuide_EIH.Name = "textBoxGuide_EIH";
            this.textBoxGuide_EIH.ReadOnly = true;
            this.textBoxGuide_EIH.Size = new System.Drawing.Size(573, 450);
            this.textBoxGuide_EIH.TabIndex = 0;
            this.textBoxGuide_EIH.Text = resources.GetString("textBoxGuide_EIH.Text");
            // 
            // buttonClose_EIH
            // 
            this.buttonClose_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose_EIH.Location = new System.Drawing.Point(464, 360);
            this.buttonClose_EIH.Name = "buttonClose_EIH";
            this.buttonClose_EIH.Size = new System.Drawing.Size(75, 52);
            this.buttonClose_EIH.TabIndex = 1;
            this.buttonClose_EIH.Text = "OK";
            this.buttonClose_EIH.UseVisualStyleBackColor = true;
            this.buttonClose_EIH.Click += new System.EventHandler(this.buttonClose_EIH_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 491);
            this.Controls.Add(this.buttonClose_EIH);
            this.Controls.Add(this.textBoxGuide_EIH);
            this.Name = "FormGuide";
            this.Text = "FormGuide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuide_EIH;
        private System.Windows.Forms.Button buttonClose_EIH;
    }
}