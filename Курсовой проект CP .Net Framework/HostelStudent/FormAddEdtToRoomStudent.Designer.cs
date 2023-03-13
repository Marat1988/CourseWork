
namespace HostelStudent
{
    partial class FormAddEdtToRoomStudent
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
            this.labelChooseStudent = new System.Windows.Forms.Label();
            this.comboBoxChooseStudent = new System.Windows.Forms.ComboBox();
            this.labelChooseRoom = new System.Windows.Forms.Label();
            this.comboBoxChooseRooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateSettlement = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChooseStudent
            // 
            this.labelChooseStudent.AutoSize = true;
            this.labelChooseStudent.Location = new System.Drawing.Point(12, 15);
            this.labelChooseStudent.Name = "labelChooseStudent";
            this.labelChooseStudent.Size = new System.Drawing.Size(108, 13);
            this.labelChooseStudent.TabIndex = 0;
            this.labelChooseStudent.Text = "Выберите студента:";
            // 
            // comboBoxChooseStudent
            // 
            this.comboBoxChooseStudent.FormattingEnabled = true;
            this.comboBoxChooseStudent.Location = new System.Drawing.Point(162, 12);
            this.comboBoxChooseStudent.Name = "comboBoxChooseStudent";
            this.comboBoxChooseStudent.Size = new System.Drawing.Size(178, 21);
            this.comboBoxChooseStudent.TabIndex = 1;
            // 
            // labelChooseRoom
            // 
            this.labelChooseRoom.AutoSize = true;
            this.labelChooseRoom.Location = new System.Drawing.Point(12, 53);
            this.labelChooseRoom.Name = "labelChooseRoom";
            this.labelChooseRoom.Size = new System.Drawing.Size(105, 13);
            this.labelChooseRoom.TabIndex = 2;
            this.labelChooseRoom.Text = "Выверите комнату:";
            // 
            // comboBoxChooseRooms
            // 
            this.comboBoxChooseRooms.FormattingEnabled = true;
            this.comboBoxChooseRooms.Location = new System.Drawing.Point(162, 50);
            this.comboBoxChooseRooms.Name = "comboBoxChooseRooms";
            this.comboBoxChooseRooms.Size = new System.Drawing.Size(178, 21);
            this.comboBoxChooseRooms.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите дату заселения:";
            // 
            // dateTimePickerDateSettlement
            // 
            this.dateTimePickerDateSettlement.Location = new System.Drawing.Point(162, 87);
            this.dateTimePickerDateSettlement.Name = "dateTimePickerDateSettlement";
            this.dateTimePickerDateSettlement.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerDateSettlement.TabIndex = 5;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(15, 133);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(139, 44);
            this.buttonSaveData.TabIndex = 6;
            this.buttonSaveData.Text = "Сохранить данные";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 133);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 44);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddEdtToRoomStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 208);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.dateTimePickerDateSettlement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChooseRooms);
            this.Controls.Add(this.labelChooseRoom);
            this.Controls.Add(this.comboBoxChooseStudent);
            this.Controls.Add(this.labelChooseStudent);
            this.Name = "FormAddEdtToRoomStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заселить, изменить данные студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseStudent;
        private System.Windows.Forms.ComboBox comboBoxChooseStudent;
        private System.Windows.Forms.Label labelChooseRoom;
        private System.Windows.Forms.ComboBox comboBoxChooseRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSettlement;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonCancel;
    }
}