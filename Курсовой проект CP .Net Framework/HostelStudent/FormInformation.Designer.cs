
namespace HostelStudent
{
    partial class FormInformation
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
            this.dataGridViewInformation = new System.Windows.Forms.DataGridView();
            this.buttonGetDepartments = new System.Windows.Forms.Button();
            this.buttonGetInfoGroup = new System.Windows.Forms.Button();
            this.buttonGetInfoRooms = new System.Windows.Forms.Button();
            this.buttonGetInfoTypeRooms = new System.Windows.Forms.Button();
            this.buttonGetInfoUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInformation
            // 
            this.dataGridViewInformation.AllowUserToAddRows = false;
            this.dataGridViewInformation.AllowUserToDeleteRows = false;
            this.dataGridViewInformation.AllowUserToOrderColumns = true;
            this.dataGridViewInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewInformation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInformation.Name = "dataGridViewInformation";
            this.dataGridViewInformation.ReadOnly = true;
            this.dataGridViewInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInformation.Size = new System.Drawing.Size(800, 292);
            this.dataGridViewInformation.TabIndex = 0;
            // 
            // buttonGetDepartments
            // 
            this.buttonGetDepartments.Location = new System.Drawing.Point(12, 325);
            this.buttonGetDepartments.Name = "buttonGetDepartments";
            this.buttonGetDepartments.Size = new System.Drawing.Size(261, 50);
            this.buttonGetDepartments.TabIndex = 1;
            this.buttonGetDepartments.Text = "Информация о кафедрах";
            this.buttonGetDepartments.UseVisualStyleBackColor = true;
            this.buttonGetDepartments.Click += new System.EventHandler(this.buttonGetDepartments_Click);
            // 
            // buttonGetInfoGroup
            // 
            this.buttonGetInfoGroup.Location = new System.Drawing.Point(12, 398);
            this.buttonGetInfoGroup.Name = "buttonGetInfoGroup";
            this.buttonGetInfoGroup.Size = new System.Drawing.Size(261, 50);
            this.buttonGetInfoGroup.TabIndex = 2;
            this.buttonGetInfoGroup.Text = "Информация о группах";
            this.buttonGetInfoGroup.UseVisualStyleBackColor = true;
            this.buttonGetInfoGroup.Click += new System.EventHandler(this.buttonGetInfoGroup_Click);
            // 
            // buttonGetInfoRooms
            // 
            this.buttonGetInfoRooms.Location = new System.Drawing.Point(12, 474);
            this.buttonGetInfoRooms.Name = "buttonGetInfoRooms";
            this.buttonGetInfoRooms.Size = new System.Drawing.Size(261, 50);
            this.buttonGetInfoRooms.TabIndex = 3;
            this.buttonGetInfoRooms.Text = "Информация о комнатах";
            this.buttonGetInfoRooms.UseVisualStyleBackColor = true;
            this.buttonGetInfoRooms.Click += new System.EventHandler(this.buttonGetInfoRooms_Click);
            // 
            // buttonGetInfoTypeRooms
            // 
            this.buttonGetInfoTypeRooms.Location = new System.Drawing.Point(327, 325);
            this.buttonGetInfoTypeRooms.Name = "buttonGetInfoTypeRooms";
            this.buttonGetInfoTypeRooms.Size = new System.Drawing.Size(261, 50);
            this.buttonGetInfoTypeRooms.TabIndex = 4;
            this.buttonGetInfoTypeRooms.Text = "Инофрмация о типах комнат";
            this.buttonGetInfoTypeRooms.UseVisualStyleBackColor = true;
            this.buttonGetInfoTypeRooms.Click += new System.EventHandler(this.buttonGetInfoTypeRooms_Click);
            // 
            // buttonGetInfoUsers
            // 
            this.buttonGetInfoUsers.Location = new System.Drawing.Point(327, 398);
            this.buttonGetInfoUsers.Name = "buttonGetInfoUsers";
            this.buttonGetInfoUsers.Size = new System.Drawing.Size(261, 50);
            this.buttonGetInfoUsers.TabIndex = 5;
            this.buttonGetInfoUsers.Text = "Информация о пользователях";
            this.buttonGetInfoUsers.UseVisualStyleBackColor = true;
            this.buttonGetInfoUsers.Click += new System.EventHandler(this.buttonGetInfoUsers_Click);
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.buttonGetInfoUsers);
            this.Controls.Add(this.buttonGetInfoTypeRooms);
            this.Controls.Add(this.buttonGetInfoRooms);
            this.Controls.Add(this.buttonGetInfoGroup);
            this.Controls.Add(this.buttonGetDepartments);
            this.Controls.Add(this.dataGridViewInformation);
            this.Name = "FormInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр общей информации";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInformation;
        private System.Windows.Forms.Button buttonGetDepartments;
        private System.Windows.Forms.Button buttonGetInfoGroup;
        private System.Windows.Forms.Button buttonGetInfoRooms;
        private System.Windows.Forms.Button buttonGetInfoTypeRooms;
        private System.Windows.Forms.Button buttonGetInfoUsers;
    }
}