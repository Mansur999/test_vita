namespace test_task_vita
{
    partial class visitFormInput
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
            this.visitFormId = new System.Windows.Forms.TextBox();
            this.visitFormMkb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visitFormDate = new System.Windows.Forms.DateTimePicker();
            this.visitFormAdd = new System.Windows.Forms.Button();
            this.visitFormBack = new System.Windows.Forms.Button();
            this.visitFormMkbInfo = new System.Windows.Forms.Button();
            this.visitFormIdPacient = new System.Windows.Forms.Button();
            this.visitFormId_patient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // visitFormId
            // 
            this.visitFormId.Location = new System.Drawing.Point(199, 46);
            this.visitFormId.Name = "visitFormId";
            this.visitFormId.Size = new System.Drawing.Size(108, 20);
            this.visitFormId.TabIndex = 0;
            // 
            // visitFormMkb
            // 
            this.visitFormMkb.Location = new System.Drawing.Point(199, 120);
            this.visitFormMkb.Name = "visitFormMkb";
            this.visitFormMkb.Size = new System.Drawing.Size(108, 20);
            this.visitFormMkb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время пос.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Диагноз";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(53, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID пациента";
            // 
            // visitFormDate
            // 
            this.visitFormDate.Location = new System.Drawing.Point(199, 83);
            this.visitFormDate.Name = "visitFormDate";
            this.visitFormDate.Size = new System.Drawing.Size(108, 20);
            this.visitFormDate.TabIndex = 8;
            // 
            // visitFormAdd
            // 
            this.visitFormAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitFormAdd.Location = new System.Drawing.Point(222, 218);
            this.visitFormAdd.Name = "visitFormAdd";
            this.visitFormAdd.Size = new System.Drawing.Size(94, 29);
            this.visitFormAdd.TabIndex = 9;
            this.visitFormAdd.Text = "Добавить";
            this.visitFormAdd.UseVisualStyleBackColor = true;
            this.visitFormAdd.Click += new System.EventHandler(this.visitFormAdd_Click);
            // 
            // visitFormBack
            // 
            this.visitFormBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitFormBack.Location = new System.Drawing.Point(50, 218);
            this.visitFormBack.Name = "visitFormBack";
            this.visitFormBack.Size = new System.Drawing.Size(75, 29);
            this.visitFormBack.TabIndex = 10;
            this.visitFormBack.Text = "Назад";
            this.visitFormBack.UseVisualStyleBackColor = true;
            this.visitFormBack.Click += new System.EventHandler(this.visitFormBack_Click);
            // 
            // visitFormMkbInfo
            // 
            this.visitFormMkbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitFormMkbInfo.Location = new System.Drawing.Point(342, 115);
            this.visitFormMkbInfo.Name = "visitFormMkbInfo";
            this.visitFormMkbInfo.Size = new System.Drawing.Size(99, 29);
            this.visitFormMkbInfo.TabIndex = 11;
            this.visitFormMkbInfo.Text = "Подробнее";
            this.visitFormMkbInfo.UseVisualStyleBackColor = true;
            this.visitFormMkbInfo.Click += new System.EventHandler(this.visitFormMkbInfo_Click);
            // 
            // visitFormIdPacient
            // 
            this.visitFormIdPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitFormIdPacient.Location = new System.Drawing.Point(342, 155);
            this.visitFormIdPacient.Name = "visitFormIdPacient";
            this.visitFormIdPacient.Size = new System.Drawing.Size(99, 29);
            this.visitFormIdPacient.TabIndex = 12;
            this.visitFormIdPacient.Text = "Пациенты";
            this.visitFormIdPacient.UseVisualStyleBackColor = true;
            this.visitFormIdPacient.Click += new System.EventHandler(this.visitFormIdPacient_Click);
            // 
            // visitFormId_patient
            // 
            this.visitFormId_patient.FormattingEnabled = true;
            this.visitFormId_patient.Location = new System.Drawing.Point(199, 163);
            this.visitFormId_patient.Name = "visitFormId_patient";
            this.visitFormId_patient.Size = new System.Drawing.Size(108, 21);
            this.visitFormId_patient.TabIndex = 13;
            // 
            // visitFormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 290);
            this.Controls.Add(this.visitFormId_patient);
            this.Controls.Add(this.visitFormIdPacient);
            this.Controls.Add(this.visitFormMkbInfo);
            this.Controls.Add(this.visitFormBack);
            this.Controls.Add(this.visitFormAdd);
            this.Controls.Add(this.visitFormDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visitFormMkb);
            this.Controls.Add(this.visitFormId);
            this.Name = "visitFormInput";
            this.Text = "visitForm";
            this.Load += new System.EventHandler(this.visitFormInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visitFormId;
        private System.Windows.Forms.TextBox visitFormMkb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker visitFormDate;
        private System.Windows.Forms.Button visitFormAdd;
        private System.Windows.Forms.Button visitFormBack;
        private System.Windows.Forms.Button visitFormMkbInfo;
        private System.Windows.Forms.Button visitFormIdPacient;
        private System.Windows.Forms.ComboBox visitFormId_patient;
    }
}