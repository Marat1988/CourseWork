
namespace HostelStudent
{
    partial class FormSendMail
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxMessageBody = new System.Windows.Forms.TextBox();
            this.labelMessageBody = new System.Windows.Forms.Label();
            this.comboBoxFileExtension = new System.Windows.Forms.ComboBox();
            this.labelFileExtension = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(29, 21);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(101, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Адрес получателя:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(146, 18);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(261, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(29, 58);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(97, 13);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Тема сообщения:";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(146, 55);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(261, 20);
            this.textBoxSubject.TabIndex = 3;
            // 
            // textBoxMessageBody
            // 
            this.textBoxMessageBody.Location = new System.Drawing.Point(146, 95);
            this.textBoxMessageBody.Multiline = true;
            this.textBoxMessageBody.Name = "textBoxMessageBody";
            this.textBoxMessageBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessageBody.Size = new System.Drawing.Size(261, 152);
            this.textBoxMessageBody.TabIndex = 4;
            // 
            // labelMessageBody
            // 
            this.labelMessageBody.AutoSize = true;
            this.labelMessageBody.Location = new System.Drawing.Point(31, 140);
            this.labelMessageBody.Name = "labelMessageBody";
            this.labelMessageBody.Size = new System.Drawing.Size(95, 13);
            this.labelMessageBody.TabIndex = 5;
            this.labelMessageBody.Text = "Тело сообщения:";
            // 
            // comboBoxFileExtension
            // 
            this.comboBoxFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileExtension.FormattingEnabled = true;
            this.comboBoxFileExtension.Items.AddRange(new object[] {
            "DOCX",
            "DOC",
            "XLSX",
            "XLS",
            "PPTX",
            "PDF"});
            this.comboBoxFileExtension.Location = new System.Drawing.Point(146, 267);
            this.comboBoxFileExtension.Name = "comboBoxFileExtension";
            this.comboBoxFileExtension.Size = new System.Drawing.Size(261, 21);
            this.comboBoxFileExtension.TabIndex = 6;
            // 
            // labelFileExtension
            // 
            this.labelFileExtension.AutoSize = true;
            this.labelFileExtension.Location = new System.Drawing.Point(22, 270);
            this.labelFileExtension.Name = "labelFileExtension";
            this.labelFileExtension.Size = new System.Drawing.Size(108, 13);
            this.labelFileExtension.TabIndex = 7;
            this.labelFileExtension.Text = "Расширение файла:";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(25, 313);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(204, 62);
            this.buttonSendMessage.TabIndex = 8;
            this.buttonSendMessage.Text = "Отправить сообщение:";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // FormSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 407);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.labelFileExtension);
            this.Controls.Add(this.comboBoxFileExtension);
            this.Controls.Add(this.labelMessageBody);
            this.Controls.Add(this.textBoxMessageBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Name = "FormSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почтовая отправка карточки студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxMessageBody;
        private System.Windows.Forms.Label labelMessageBody;
        private System.Windows.Forms.ComboBox comboBoxFileExtension;
        private System.Windows.Forms.Label labelFileExtension;
        private System.Windows.Forms.Button buttonSendMessage;
    }
}