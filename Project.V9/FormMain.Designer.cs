namespace Project.V9
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_EIH = new System.Windows.Forms.Button();
            this.buttonInfo_EIH = new System.Windows.Forms.Button();
            this.toolTip_EIH = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_EIH = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxOutPutData_EIH = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile_EIH = new System.Windows.Forms.Button();
            this.buttonAddVideo_EIH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxVideoCounter_EIH = new System.Windows.Forms.TextBox();
            this.textBoxActorsCounter_EIH = new System.Windows.Forms.TextBox();
            this.textBoxMaxTimeCounter_EIH = new System.Windows.Forms.TextBox();
            this.textBoxMinTimeCounter_EIH = new System.Windows.Forms.TextBox();
            this.labelVideoNum_EIH = new System.Windows.Forms.Label();
            this.labelActorsCounter_EIH = new System.Windows.Forms.Label();
            this.labelMaxTime_EIH = new System.Windows.Forms.Label();
            this.labelMinTime_EIH = new System.Windows.Forms.Label();
            this.groupBoxStatistics_EIH = new System.Windows.Forms.GroupBox();
            this.labelStats_EIH = new System.Windows.Forms.Label();
            this.buttonShowStats_EIH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOutPutData_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStatistics_EIH.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_EIH
            // 
            this.buttonOpenFile_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_EIH.Image")));
            this.buttonOpenFile_EIH.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_EIH.Name = "buttonOpenFile_EIH";
            this.buttonOpenFile_EIH.Size = new System.Drawing.Size(75, 75);
            this.buttonOpenFile_EIH.TabIndex = 0;
            this.toolTip_EIH.SetToolTip(this.buttonOpenFile_EIH, "Позволяет открыть файл и считать из него данные");
            this.buttonOpenFile_EIH.UseVisualStyleBackColor = true;
            // 
            // buttonInfo_EIH
            // 
            this.buttonInfo_EIH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_EIH.Image")));
            this.buttonInfo_EIH.Location = new System.Drawing.Point(804, 13);
            this.buttonInfo_EIH.Name = "buttonInfo_EIH";
            this.buttonInfo_EIH.Size = new System.Drawing.Size(75, 75);
            this.buttonInfo_EIH.TabIndex = 0;
            this.toolTip_EIH.SetToolTip(this.buttonInfo_EIH, "Предоставляет информацию о проекте");
            this.buttonInfo_EIH.UseVisualStyleBackColor = true;
            this.buttonInfo_EIH.Click += new System.EventHandler(this.buttonInfo_EIH_Click);
            // 
            // openFileDialog_EIH
            // 
            this.openFileDialog_EIH.FileName = "openFileDialog1";
            // 
            // groupBoxOutPutData_EIH
            // 
            this.groupBoxOutPutData_EIH.Controls.Add(this.dataGridView1);
            this.groupBoxOutPutData_EIH.Location = new System.Drawing.Point(13, 111);
            this.groupBoxOutPutData_EIH.Name = "groupBoxOutPutData_EIH";
            this.groupBoxOutPutData_EIH.Size = new System.Drawing.Size(470, 444);
            this.groupBoxOutPutData_EIH.TabIndex = 1;
            this.groupBoxOutPutData_EIH.TabStop = false;
            this.groupBoxOutPutData_EIH.Text = "Вывод данных:";
            // 
            // buttonSaveFile_EIH
            // 
            this.buttonSaveFile_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_EIH.Image")));
            this.buttonSaveFile_EIH.Location = new System.Drawing.Point(214, 12);
            this.buttonSaveFile_EIH.Name = "buttonSaveFile_EIH";
            this.buttonSaveFile_EIH.Size = new System.Drawing.Size(75, 75);
            this.buttonSaveFile_EIH.TabIndex = 0;
            this.toolTip_EIH.SetToolTip(this.buttonSaveFile_EIH, "Позволяет сохранить файл");
            this.buttonSaveFile_EIH.UseVisualStyleBackColor = true;
            // 
            // buttonAddVideo_EIH
            // 
            this.buttonAddVideo_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVideo_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddVideo_EIH.Image")));
            this.buttonAddVideo_EIH.Location = new System.Drawing.Point(112, 12);
            this.buttonAddVideo_EIH.Name = "buttonAddVideo_EIH";
            this.buttonAddVideo_EIH.Size = new System.Drawing.Size(75, 75);
            this.buttonAddVideo_EIH.TabIndex = 0;
            this.toolTip_EIH.SetToolTip(this.buttonAddVideo_EIH, "Позволяет добавить информацию о новом видео\r\n");
            this.buttonAddVideo_EIH.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxVideoCounter_EIH
            // 
            this.textBoxVideoCounter_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVideoCounter_EIH.Location = new System.Drawing.Point(23, 105);
            this.textBoxVideoCounter_EIH.Name = "textBoxVideoCounter_EIH";
            this.textBoxVideoCounter_EIH.ReadOnly = true;
            this.textBoxVideoCounter_EIH.Size = new System.Drawing.Size(52, 22);
            this.textBoxVideoCounter_EIH.TabIndex = 1;
            // 
            // textBoxActorsCounter_EIH
            // 
            this.textBoxActorsCounter_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxActorsCounter_EIH.Location = new System.Drawing.Point(23, 192);
            this.textBoxActorsCounter_EIH.Name = "textBoxActorsCounter_EIH";
            this.textBoxActorsCounter_EIH.ReadOnly = true;
            this.textBoxActorsCounter_EIH.Size = new System.Drawing.Size(52, 22);
            this.textBoxActorsCounter_EIH.TabIndex = 1;
            // 
            // textBoxMaxTimeCounter_EIH
            // 
            this.textBoxMaxTimeCounter_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaxTimeCounter_EIH.Location = new System.Drawing.Point(142, 192);
            this.textBoxMaxTimeCounter_EIH.Name = "textBoxMaxTimeCounter_EIH";
            this.textBoxMaxTimeCounter_EIH.ReadOnly = true;
            this.textBoxMaxTimeCounter_EIH.Size = new System.Drawing.Size(52, 22);
            this.textBoxMaxTimeCounter_EIH.TabIndex = 1;
            // 
            // textBoxMinTimeCounter_EIH
            // 
            this.textBoxMinTimeCounter_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMinTimeCounter_EIH.Location = new System.Drawing.Point(142, 105);
            this.textBoxMinTimeCounter_EIH.Name = "textBoxMinTimeCounter_EIH";
            this.textBoxMinTimeCounter_EIH.ReadOnly = true;
            this.textBoxMinTimeCounter_EIH.Size = new System.Drawing.Size(52, 22);
            this.textBoxMinTimeCounter_EIH.TabIndex = 1;
            // 
            // labelVideoNum_EIH
            // 
            this.labelVideoNum_EIH.AutoSize = true;
            this.labelVideoNum_EIH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelVideoNum_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVideoNum_EIH.Location = new System.Drawing.Point(6, 68);
            this.labelVideoNum_EIH.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelVideoNum_EIH.Name = "labelVideoNum_EIH";
            this.labelVideoNum_EIH.Size = new System.Drawing.Size(90, 34);
            this.labelVideoNum_EIH.TabIndex = 2;
            this.labelVideoNum_EIH.Text = "Количество видео:";
            // 
            // labelActorsCounter_EIH
            // 
            this.labelActorsCounter_EIH.AutoSize = true;
            this.labelActorsCounter_EIH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelActorsCounter_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActorsCounter_EIH.Location = new System.Drawing.Point(6, 155);
            this.labelActorsCounter_EIH.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelActorsCounter_EIH.Name = "labelActorsCounter_EIH";
            this.labelActorsCounter_EIH.Size = new System.Drawing.Size(90, 34);
            this.labelActorsCounter_EIH.TabIndex = 2;
            this.labelActorsCounter_EIH.Text = "Количество актеров:";
            // 
            // labelMaxTime_EIH
            // 
            this.labelMaxTime_EIH.AutoSize = true;
            this.labelMaxTime_EIH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMaxTime_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMaxTime_EIH.Location = new System.Drawing.Point(114, 68);
            this.labelMaxTime_EIH.MaximumSize = new System.Drawing.Size(120, 100);
            this.labelMaxTime_EIH.Name = "labelMaxTime_EIH";
            this.labelMaxTime_EIH.Size = new System.Drawing.Size(109, 34);
            this.labelMaxTime_EIH.TabIndex = 2;
            this.labelMaxTime_EIH.Text = "Максимальное время видео:";
            // 
            // labelMinTime_EIH
            // 
            this.labelMinTime_EIH.AutoSize = true;
            this.labelMinTime_EIH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMinTime_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMinTime_EIH.Location = new System.Drawing.Point(114, 155);
            this.labelMinTime_EIH.MaximumSize = new System.Drawing.Size(120, 100);
            this.labelMinTime_EIH.Name = "labelMinTime_EIH";
            this.labelMinTime_EIH.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.labelMinTime_EIH.Size = new System.Drawing.Size(109, 34);
            this.labelMinTime_EIH.TabIndex = 2;
            this.labelMinTime_EIH.Text = "Минимальное время видео:";
            // 
            // groupBoxStatistics_EIH
            // 
            this.groupBoxStatistics_EIH.Controls.Add(this.labelStats_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.labelVideoNum_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.label2);
            this.groupBoxStatistics_EIH.Controls.Add(this.labelMinTime_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.textBoxVideoCounter_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.textBox2);
            this.groupBoxStatistics_EIH.Controls.Add(this.textBoxActorsCounter_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.buttonShowStats_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.labelMaxTime_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.textBox1);
            this.groupBoxStatistics_EIH.Controls.Add(this.textBoxMaxTimeCounter_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.textBoxMinTimeCounter_EIH);
            this.groupBoxStatistics_EIH.Controls.Add(this.label1);
            this.groupBoxStatistics_EIH.Controls.Add(this.labelActorsCounter_EIH);
            this.groupBoxStatistics_EIH.Location = new System.Drawing.Point(489, 111);
            this.groupBoxStatistics_EIH.Name = "groupBoxStatistics_EIH";
            this.groupBoxStatistics_EIH.Size = new System.Drawing.Size(395, 227);
            this.groupBoxStatistics_EIH.TabIndex = 3;
            this.groupBoxStatistics_EIH.TabStop = false;
            this.groupBoxStatistics_EIH.Text = "Статистика:";
            // 
            // labelStats_EIH
            // 
            this.labelStats_EIH.AutoSize = true;
            this.labelStats_EIH.BackColor = System.Drawing.SystemColors.Info;
            this.labelStats_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStats_EIH.Location = new System.Drawing.Point(6, 18);
            this.labelStats_EIH.Name = "labelStats_EIH";
            this.labelStats_EIH.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.labelStats_EIH.Size = new System.Drawing.Size(140, 34);
            this.labelStats_EIH.TabIndex = 2;
            this.labelStats_EIH.Text = "Узнать статистику:";
            // 
            // buttonShowStats_EIH
            // 
            this.buttonShowStats_EIH.BackColor = System.Drawing.SystemColors.Info;
            this.buttonShowStats_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowStats_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowStats_EIH.Image")));
            this.buttonShowStats_EIH.Location = new System.Drawing.Point(159, 18);
            this.buttonShowStats_EIH.Name = "buttonShowStats_EIH";
            this.buttonShowStats_EIH.Size = new System.Drawing.Size(40, 40);
            this.buttonShowStats_EIH.TabIndex = 0;
            this.buttonShowStats_EIH.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(246, 68);
            this.label1.MaximumSize = new System.Drawing.Size(120, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Самое дорогое видео:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(274, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(274, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(52, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(246, 155);
            this.label2.MaximumSize = new System.Drawing.Size(130, 100);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label2.Size = new System.Drawing.Size(120, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Самое дешевое видео:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(891, 564);
            this.Controls.Add(this.groupBoxStatistics_EIH);
            this.Controls.Add(this.groupBoxOutPutData_EIH);
            this.Controls.Add(this.buttonInfo_EIH);
            this.Controls.Add(this.buttonAddVideo_EIH);
            this.Controls.Add(this.buttonSaveFile_EIH);
            this.Controls.Add(this.buttonOpenFile_EIH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Каталог видео";
            this.groupBoxOutPutData_EIH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStatistics_EIH.ResumeLayout(false);
            this.groupBoxStatistics_EIH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_EIH;
        private System.Windows.Forms.Button buttonInfo_EIH;
        private System.Windows.Forms.ToolTip toolTip_EIH;
        private System.Windows.Forms.OpenFileDialog openFileDialog_EIH;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EIH;
        private System.Windows.Forms.Button buttonSaveFile_EIH;
        private System.Windows.Forms.Button buttonAddVideo_EIH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelVideoNum_EIH;
        private System.Windows.Forms.TextBox textBoxMinTimeCounter_EIH;
        private System.Windows.Forms.TextBox textBoxMaxTimeCounter_EIH;
        private System.Windows.Forms.TextBox textBoxActorsCounter_EIH;
        private System.Windows.Forms.TextBox textBoxVideoCounter_EIH;
        private System.Windows.Forms.Label labelMinTime_EIH;
        private System.Windows.Forms.Label labelMaxTime_EIH;
        private System.Windows.Forms.Label labelActorsCounter_EIH;
        private System.Windows.Forms.GroupBox groupBoxStatistics_EIH;
        private System.Windows.Forms.Label labelStats_EIH;
        private System.Windows.Forms.Button buttonShowStats_EIH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

