namespace test_task_vita
{
    partial class outVisitByPatient
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
            this.outVisitComboBox = new System.Windows.Forms.ComboBox();
            this.outVisitViewing = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mkb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outVisitExportXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // outVisitComboBox
            // 
            this.outVisitComboBox.FormattingEnabled = true;
            this.outVisitComboBox.Location = new System.Drawing.Point(21, 188);
            this.outVisitComboBox.Name = "outVisitComboBox";
            this.outVisitComboBox.Size = new System.Drawing.Size(121, 21);
            this.outVisitComboBox.TabIndex = 0;
            // 
            // outVisitViewing
            // 
            this.outVisitViewing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outVisitViewing.Location = new System.Drawing.Point(368, 188);
            this.outVisitViewing.Name = "outVisitViewing";
            this.outVisitViewing.Size = new System.Drawing.Size(109, 34);
            this.outVisitViewing.TabIndex = 4;
            this.outVisitViewing.Text = "Посещения";
            this.outVisitViewing.UseVisualStyleBackColor = true;
            this.outVisitViewing.Click += new System.EventHandler(this.outVisitViewing_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.date,
            this.Mkb,
            this.Id_patient});
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 134);
            this.dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // date
            // 
            this.date.HeaderText = "Дата посещения";
            this.date.Name = "date";
            // 
            // Mkb
            // 
            this.Mkb.HeaderText = "Диагноз";
            this.Mkb.Name = "Mkb";
            // 
            // Id_patient
            // 
            this.Id_patient.HeaderText = "Id пациента";
            this.Id_patient.Name = "Id_patient";
            // 
            // outVisitExportXml
            // 
            this.outVisitExportXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outVisitExportXml.Location = new System.Drawing.Point(368, 239);
            this.outVisitExportXml.Name = "outVisitExportXml";
            this.outVisitExportXml.Size = new System.Drawing.Size(109, 34);
            this.outVisitExportXml.TabIndex = 6;
            this.outVisitExportXml.Text = "Экспорт";
            this.outVisitExportXml.UseVisualStyleBackColor = true;
            this.outVisitExportXml.Click += new System.EventHandler(this.outVisitExportXml_Click);
            // 
            // outVisitByPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.outVisitExportXml);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.outVisitViewing);
            this.Controls.Add(this.outVisitComboBox);
            this.Name = "outVisitByPatient";
            this.Text = "outVisitByPatient";
            this.Load += new System.EventHandler(this.outVisitByPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox outVisitComboBox;
        private System.Windows.Forms.Button outVisitViewing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mkb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_patient;
        private System.Windows.Forms.Button outVisitExportXml;
    }
}