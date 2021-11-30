namespace test_task_vita
{
    partial class outPatient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dadname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outPatientSort = new System.Windows.Forms.Button();
            this.outPatientComboBox = new System.Windows.Forms.ComboBox();
            this.outPatientBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Surname,
            this.Name1,
            this.Dadname,
            this.Birthday,
            this.phone});
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID пациента";
            this.id.Name = "id";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Имя";
            this.Name1.Name = "Name1";
            // 
            // Dadname
            // 
            this.Dadname.HeaderText = "Отчество";
            this.Dadname.Name = "Dadname";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            // 
            // outPatientSort
            // 
            this.outPatientSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outPatientSort.Location = new System.Drawing.Point(466, 291);
            this.outPatientSort.Name = "outPatientSort";
            this.outPatientSort.Size = new System.Drawing.Size(124, 32);
            this.outPatientSort.TabIndex = 1;
            this.outPatientSort.Text = "Сортировать";
            this.outPatientSort.UseVisualStyleBackColor = true;
            this.outPatientSort.Click += new System.EventHandler(this.outPatientSort_Click);
            // 
            // outPatientComboBox
            // 
            this.outPatientComboBox.FormattingEnabled = true;
            this.outPatientComboBox.Items.AddRange(new object[] {
            "ID",
            "Фамилия",
            "Имя",
            "Отчество",
            "Дата Рождения",
            "Телефон"});
            this.outPatientComboBox.Location = new System.Drawing.Point(318, 291);
            this.outPatientComboBox.Name = "outPatientComboBox";
            this.outPatientComboBox.Size = new System.Drawing.Size(121, 21);
            this.outPatientComboBox.TabIndex = 2;
            // 
            // outPatientBack
            // 
            this.outPatientBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outPatientBack.Location = new System.Drawing.Point(59, 291);
            this.outPatientBack.Name = "outPatientBack";
            this.outPatientBack.Size = new System.Drawing.Size(124, 32);
            this.outPatientBack.TabIndex = 3;
            this.outPatientBack.Text = "Назад";
            this.outPatientBack.UseVisualStyleBackColor = true;
            this.outPatientBack.Click += new System.EventHandler(this.outPatientBack_Click);
            // 
            // outPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 379);
            this.Controls.Add(this.outPatientBack);
            this.Controls.Add(this.outPatientComboBox);
            this.Controls.Add(this.outPatientSort);
            this.Controls.Add(this.dataGridView1);
            this.Name = "outPatient";
            this.Text = "outPatient";
            this.Load += new System.EventHandler(this.outPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dadname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Button outPatientSort;
        private System.Windows.Forms.ComboBox outPatientComboBox;
        private System.Windows.Forms.Button outPatientBack;
    }
}