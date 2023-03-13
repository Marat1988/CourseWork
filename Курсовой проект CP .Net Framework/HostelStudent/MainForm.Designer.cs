
namespace HostelStudent
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddStudentRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditStudentRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeleteStudentRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemRefreshData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSendMail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemShowAllInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExportCardStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveCardStudentXLSX = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveCardStudentPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveCardStudentDOCX = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemSaveCardStudentPPTX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSaveAllCardStudentXLSX = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAllCardStudentPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAllCardStudentDOCX = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAllCardStudentPPTX = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCountStudent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonWebPortal = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItemShowListStudentOnWebPortal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemShowCardStudentOnWebPortal = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewInfoStudent = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAction,
            this.ToolStripMenuItemHelpInformation,
            this.ToolStripMenuItemExportCardStudent});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemAction
            // 
            this.ToolStripMenuItemAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddStudentRoom,
            this.ToolStripMenuItemEditStudentRoom,
            this.ToolStripMenuItemDeleteStudentRoom,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemRefreshData,
            this.toolStripMenuItem2,
            this.ToolStripMenuItemSendMail,
            this.toolStripMenuItem4,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemAction.Name = "ToolStripMenuItemAction";
            this.ToolStripMenuItemAction.Size = new System.Drawing.Size(70, 20);
            this.ToolStripMenuItemAction.Text = "Действия";
            // 
            // ToolStripMenuItemAddStudentRoom
            // 
            this.ToolStripMenuItemAddStudentRoom.Name = "ToolStripMenuItemAddStudentRoom";
            this.ToolStripMenuItemAddStudentRoom.Size = new System.Drawing.Size(283, 22);
            this.ToolStripMenuItemAddStudentRoom.Text = "Заселить студента в комнату";
            this.ToolStripMenuItemAddStudentRoom.Click += new System.EventHandler(this.ToolStripMenuItemAddStudentRoom_Click);
            // 
            // ToolStripMenuItemEditStudentRoom
            // 
            this.ToolStripMenuItemEditStudentRoom.Name = "ToolStripMenuItemEditStudentRoom";
            this.ToolStripMenuItemEditStudentRoom.Size = new System.Drawing.Size(283, 22);
            this.ToolStripMenuItemEditStudentRoom.Text = "Изменить данные студента";
            this.ToolStripMenuItemEditStudentRoom.Click += new System.EventHandler(this.ToolStripMenuItemEditStudentRoom_Click);
            // 
            // ToolStripMenuItemDeleteStudentRoom
            // 
            this.ToolStripMenuItemDeleteStudentRoom.Name = "ToolStripMenuItemDeleteStudentRoom";
            this.ToolStripMenuItemDeleteStudentRoom.Size = new System.Drawing.Size(283, 22);
            this.ToolStripMenuItemDeleteStudentRoom.Text = "Выселить студента из комнаты";
            this.ToolStripMenuItemDeleteStudentRoom.Click += new System.EventHandler(this.ToolStripMenuItemDeleteStudentRoom_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(280, 6);
            // 
            // ToolStripMenuItemRefreshData
            // 
            this.ToolStripMenuItemRefreshData.Name = "ToolStripMenuItemRefreshData";
            this.ToolStripMenuItemRefreshData.Size = new System.Drawing.Size(283, 22);
            this.ToolStripMenuItemRefreshData.Text = "Обновить данные";
            this.ToolStripMenuItemRefreshData.Click += new System.EventHandler(this.ToolStripMenuItemRefreshData_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(280, 6);
            // 
            // ToolStripMenuItemSendMail
            // 
            this.ToolStripMenuItemSendMail.Name = "ToolStripMenuItemSendMail";
            this.ToolStripMenuItemSendMail.Size = new System.Drawing.Size(283, 22);
            this.ToolStripMenuItemSendMail.Text = "Отправка карточки студента на e-mail";
            this.ToolStripMenuItemSendMail.Click += new System.EventHandler(this.ToolStripMenuItemSendMail_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(280, 6);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(283, 22);
            this.ToolStripMenuItemExit.Text = "Выход из программы";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemHelpInformation
            // 
            this.ToolStripMenuItemHelpInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemShowAllInfo});
            this.ToolStripMenuItemHelpInformation.Name = "ToolStripMenuItemHelpInformation";
            this.ToolStripMenuItemHelpInformation.Size = new System.Drawing.Size(161, 20);
            this.ToolStripMenuItemHelpInformation.Text = "Справочная информация";
            // 
            // ToolStripMenuItemShowAllInfo
            // 
            this.ToolStripMenuItemShowAllInfo.Name = "ToolStripMenuItemShowAllInfo";
            this.ToolStripMenuItemShowAllInfo.Size = new System.Drawing.Size(188, 22);
            this.ToolStripMenuItemShowAllInfo.Text = "Общая информация";
            this.ToolStripMenuItemShowAllInfo.Click += new System.EventHandler(this.ToolStripMenuItemShowAllInfo_Click);
            // 
            // ToolStripMenuItemExportCardStudent
            // 
            this.ToolStripMenuItemExportCardStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSaveCardStudentXLSX,
            this.ToolStripMenuItemSaveCardStudentPDF,
            this.ToolStripMenuItemSaveCardStudentDOCX,
            this.StripMenuItemSaveCardStudentPPTX,
            this.toolStripMenuItem3,
            this.ToolStripMenuItemSaveAllCardStudentXLSX,
            this.ToolStripMenuItemSaveAllCardStudentPDF,
            this.ToolStripMenuItemSaveAllCardStudentDOCX,
            this.ToolStripMenuItemSaveAllCardStudentPPTX});
            this.ToolStripMenuItemExportCardStudent.Name = "ToolStripMenuItemExportCardStudent";
            this.ToolStripMenuItemExportCardStudent.Size = new System.Drawing.Size(64, 20);
            this.ToolStripMenuItemExportCardStudent.Text = "Экспорт";
            // 
            // ToolStripMenuItemSaveCardStudentXLSX
            // 
            this.ToolStripMenuItemSaveCardStudentXLSX.Name = "ToolStripMenuItemSaveCardStudentXLSX";
            this.ToolStripMenuItemSaveCardStudentXLSX.Size = new System.Drawing.Size(405, 22);
            this.ToolStripMenuItemSaveCardStudentXLSX.Text = "Сохранить карточку студента в формате XLSX";
            this.ToolStripMenuItemSaveCardStudentXLSX.Click += new System.EventHandler(this.ToolStripMenuItemSaveCardStudentXLSX_Click);
            // 
            // ToolStripMenuItemSaveCardStudentPDF
            // 
            this.ToolStripMenuItemSaveCardStudentPDF.Name = "ToolStripMenuItemSaveCardStudentPDF";
            this.ToolStripMenuItemSaveCardStudentPDF.Size = new System.Drawing.Size(405, 22);
            this.ToolStripMenuItemSaveCardStudentPDF.Text = "Сохранить карторку студента в формате PDF";
            this.ToolStripMenuItemSaveCardStudentPDF.Click += new System.EventHandler(this.ToolStripMenuItemSaveCardStudentPDF_Click);
            // 
            // ToolStripMenuItemSaveCardStudentDOCX
            // 
            this.ToolStripMenuItemSaveCardStudentDOCX.Name = "ToolStripMenuItemSaveCardStudentDOCX";
            this.ToolStripMenuItemSaveCardStudentDOCX.Size = new System.Drawing.Size(405, 22);
            this.ToolStripMenuItemSaveCardStudentDOCX.Text = "Сохранить карточку студента ф формате DOCX";
            this.ToolStripMenuItemSaveCardStudentDOCX.Click += new System.EventHandler(this.ToolStripMenuItemSaveCardStudentDOCX_Click);
            // 
            // StripMenuItemSaveCardStudentPPTX
            // 
            this.StripMenuItemSaveCardStudentPPTX.Name = "StripMenuItemSaveCardStudentPPTX";
            this.StripMenuItemSaveCardStudentPPTX.Size = new System.Drawing.Size(405, 22);
            this.StripMenuItemSaveCardStudentPPTX.Text = "Сохранить карточку студента в формате PPTX";
            this.StripMenuItemSaveCardStudentPPTX.Click += new System.EventHandler(this.StripMenuItemSaveCardStudentPPTX_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(402, 6);
            // 
            // ToolStripMenuItemSaveAllCardStudentXLSX
            // 
            this.ToolStripMenuItemSaveAllCardStudentXLSX.Name = "ToolStripMenuItemSaveAllCardStudentXLSX";
            this.ToolStripMenuItemSaveAllCardStudentXLSX.Size = new System.Drawing.Size(405, 22);
            this.ToolStripMenuItemSaveAllCardStudentXLSX.Text = "Массовый экспорт всех карточек студента в формате XLSX";
            this.ToolStripMenuItemSaveAllCardStudentXLSX.Click += new System.EventHandler(this.ToolStripMenuItemSaveAllCardStudentXLSX_ClickAsync);
            // 
            // ToolStripMenuItemSaveAllCardStudentPDF
            // 
            this.ToolStripMenuItemSaveAllCardStudentPDF.Name = "ToolStripMenuItemSaveAllCardStudentPDF";
            this.ToolStripMenuItemSaveAllCardStudentPDF.Size = new System.Drawing.Size(405, 22);
            this.ToolStripMenuItemSaveAllCardStudentPDF.Text = "Массовый экспорт всех карточек студента в формате PDF";
            this.ToolStripMenuItemSaveAllCardStudentPDF.Click += new System.EventHandler(this.ToolStripMenuItemSaveAllCardStudentPDF_Click);
            // 
            // ToolStripMenuItemSaveAllCardStudentDOCX
            // 
            this.ToolStripMenuItemSaveAllCardStudentDOCX.Name = "ToolStripMenuItemSaveAllCardStudentDOCX";
            this.ToolStripMenuItemSaveAllCardStudentDOCX.Size = new System.Drawing.Size(405, 22);
            this.ToolStripMenuItemSaveAllCardStudentDOCX.Text = "Массовый экспорт всех карточек студента в формате DOCX";
            this.ToolStripMenuItemSaveAllCardStudentDOCX.Click += new System.EventHandler(this.ToolStripMenuItemSaveAllCardStudentDOCX_Click);
            // 
            // ToolStripMenuItemSaveAllCardStudentPPTX
            // 
            this.ToolStripMenuItemSaveAllCardStudentPPTX.Name = "ToolStripMenuItemSaveAllCardStudentPPTX";
            this.ToolStripMenuItemSaveAllCardStudentPPTX.Size = new System.Drawing.Size(405, 22);
            this.ToolStripMenuItemSaveAllCardStudentPPTX.Text = "Массовый экспорт всех карточек студента в формате PPTX";
            this.ToolStripMenuItemSaveAllCardStudentPPTX.Click += new System.EventHandler(this.ToolStripMenuItemSaveAllCardStudentPPTX_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelCountStudent,
            this.toolStripSplitButtonWebPortal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStripInfo";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(173, 17);
            this.toolStripStatusLabel1.Text = "Общее количество студентов:";
            // 
            // toolStripStatusLabelCountStudent
            // 
            this.toolStripStatusLabelCountStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabelCountStudent.Name = "toolStripStatusLabelCountStudent";
            this.toolStripStatusLabelCountStudent.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabelCountStudent.Text = "0";
            // 
            // toolStripSplitButtonWebPortal
            // 
            this.toolStripSplitButtonWebPortal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonWebPortal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemShowListStudentOnWebPortal,
            this.ToolStripMenuItemShowCardStudentOnWebPortal});
            this.toolStripSplitButtonWebPortal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonWebPortal.Image")));
            this.toolStripSplitButtonWebPortal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonWebPortal.Name = "toolStripSplitButtonWebPortal";
            this.toolStripSplitButtonWebPortal.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButtonWebPortal.Text = "toolStripSplitButton1";
            // 
            // ToolStripMenuItemShowListStudentOnWebPortal
            // 
            this.ToolStripMenuItemShowListStudentOnWebPortal.Name = "ToolStripMenuItemShowListStudentOnWebPortal";
            this.ToolStripMenuItemShowListStudentOnWebPortal.Size = new System.Drawing.Size(344, 22);
            this.ToolStripMenuItemShowListStudentOnWebPortal.Text = "Просмотреть список студентов на Web-портале";
            this.ToolStripMenuItemShowListStudentOnWebPortal.Click += new System.EventHandler(this.ToolStripMenuItemShowListStudentOnWebPortal_Click);
            // 
            // ToolStripMenuItemShowCardStudentOnWebPortal
            // 
            this.ToolStripMenuItemShowCardStudentOnWebPortal.Name = "ToolStripMenuItemShowCardStudentOnWebPortal";
            this.ToolStripMenuItemShowCardStudentOnWebPortal.Size = new System.Drawing.Size(344, 22);
            this.ToolStripMenuItemShowCardStudentOnWebPortal.Text = "Просмотреть карточку студента на Web-портале";
            this.ToolStripMenuItemShowCardStudentOnWebPortal.Click += new System.EventHandler(this.ToolStripMenuItemShowCardStudentOnWebPortal_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a.ico");
            this.imageList1.Images.SetKeyName(1, "b.ico");
            this.imageList1.Images.SetKeyName(2, "c.ico");
            this.imageList1.Images.SetKeyName(3, "Refresh.ico");
            // 
            // dataGridViewInfoStudent
            // 
            this.dataGridViewInfoStudent.AllowUserToAddRows = false;
            this.dataGridViewInfoStudent.AllowUserToDeleteRows = false;
            this.dataGridViewInfoStudent.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInfoStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInfoStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInfoStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInfoStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInfoStudent.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewInfoStudent.Name = "dataGridViewInfoStudent";
            this.dataGridViewInfoStudent.ReadOnly = true;
            this.dataGridViewInfoStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInfoStudent.Size = new System.Drawing.Size(800, 404);
            this.dataGridViewInfoStudent.TabIndex = 2;
            this.dataGridViewInfoStudent.SelectionChanged += new System.EventHandler(this.dataGridViewInfoStudent_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewInfoStudent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpInformation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowAllInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAction;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddStudentRoom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditStudentRoom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteStudentRoom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExportCardStudent;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveCardStudentXLSX;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAllCardStudentXLSX;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveCardStudentPDF;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAllCardStudentPDF;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveCardStudentDOCX;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAllCardStudentDOCX;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCountStudent;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRefreshData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.DataGridView dataGridViewInfoStudent;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSendMail;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemSaveCardStudentPPTX;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAllCardStudentPPTX;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonWebPortal;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowListStudentOnWebPortal;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowCardStudentOnWebPortal;
    }
}