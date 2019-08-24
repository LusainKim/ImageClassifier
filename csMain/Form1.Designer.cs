namespace csMain
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPictureViewer = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BTReloadPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_extension = new System.Windows.Forms.Label();
            this.lb_x = new System.Windows.Forms.Label();
            this.lb_width = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_height = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BT_Folder = new System.Windows.Forms.Button();
            this.BT_Select01 = new System.Windows.Forms.Button();
            this.BT_Select02 = new System.Windows.Forms.Button();
            this.BT_Select03 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_BTName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_FolderPath = new System.Windows.Forms.TextBox();
            this.BT_SearchDirectory = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_Copy = new System.Windows.Forms.RadioButton();
            this.RB_Move = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_Move = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPictureViewer
            // 
            this.MainPictureViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPictureViewer.Location = new System.Drawing.Point(225, 75);
            this.MainPictureViewer.Name = "MainPictureViewer";
            this.MainPictureViewer.Size = new System.Drawing.Size(500, 500);
            this.MainPictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainPictureViewer.TabIndex = 2;
            this.MainPictureViewer.TabStop = false;
            this.MainPictureViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureViewer_MouseDown);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 75);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 355);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "확장자";
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.AllowColumnReorder = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(20, 75);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(200, 355);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이름";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "확장자";
            // 
            // listView3
            // 
            this.listView3.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView3.AllowColumnReorder = true;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(20, 75);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(200, 355);
            this.listView3.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView3.TabIndex = 9;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.Visible = false;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "이름";
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "확장자";
            // 
            // listView4
            // 
            this.listView4.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView4.AllowColumnReorder = true;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listView4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(20, 75);
            this.listView4.MultiSelect = false;
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(200, 355);
            this.listView4.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView4.TabIndex = 10;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.Visible = false;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "이름";
            this.columnHeader7.Width = 135;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "확장자";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // BTReloadPath
            // 
            this.BTReloadPath.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BTReloadPath.Location = new System.Drawing.Point(20, 12);
            this.BTReloadPath.Name = "BTReloadPath";
            this.BTReloadPath.Size = new System.Drawing.Size(200, 55);
            this.BTReloadPath.TabIndex = 11;
            this.BTReloadPath.Text = "폴더 다시 선택";
            this.BTReloadPath.UseVisualStyleBackColor = true;
            this.BTReloadPath.Click += new System.EventHandler(this.BTReloadPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_extension);
            this.groupBox1.Controls.Add(this.lb_x);
            this.groupBox1.Controls.Add(this.lb_width);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_height);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(225, 581);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 86);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "속성";
            // 
            // lb_extension
            // 
            this.lb_extension.AutoSize = true;
            this.lb_extension.Location = new System.Drawing.Point(62, 43);
            this.lb_extension.Name = "lb_extension";
            this.lb_extension.Size = new System.Drawing.Size(11, 15);
            this.lb_extension.TabIndex = 4;
            this.lb_extension.Text = " ";
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Location = new System.Drawing.Point(107, 19);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(15, 15);
            this.lb_x.TabIndex = 4;
            this.lb_x.Text = "×";
            this.lb_x.Visible = false;
            // 
            // lb_width
            // 
            this.lb_width.AutoSize = true;
            this.lb_width.Location = new System.Drawing.Point(62, 19);
            this.lb_width.Name = "lb_width";
            this.lb_width.Size = new System.Drawing.Size(11, 15);
            this.lb_width.TabIndex = 4;
            this.lb_width.Text = " ";
            this.lb_width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "확장자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(128, 19);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(11, 15);
            this.lb_height.TabIndex = 2;
            this.lb_height.Text = " ";
            this.lb_height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "크기";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(6, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(210, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "클릭하여 해당 폴더를 열 수 있습니다.";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BT_Folder
            // 
            this.BT_Folder.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_Folder.Location = new System.Drawing.Point(225, 12);
            this.BT_Folder.Name = "BT_Folder";
            this.BT_Folder.Size = new System.Drawing.Size(116, 55);
            this.BT_Folder.TabIndex = 14;
            this.BT_Folder.Text = "폴더";
            this.BT_Folder.UseVisualStyleBackColor = true;
            this.BT_Folder.Click += new System.EventHandler(this.BT_Folder_Click);
            // 
            // BT_Select01
            // 
            this.BT_Select01.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_Select01.Location = new System.Drawing.Point(347, 31);
            this.BT_Select01.Name = "BT_Select01";
            this.BT_Select01.Size = new System.Drawing.Size(122, 36);
            this.BT_Select01.TabIndex = 14;
            this.BT_Select01.Text = "(제목 미정)";
            this.BT_Select01.UseVisualStyleBackColor = true;
            this.BT_Select01.Click += new System.EventHandler(this.BT_Select01_Click);
            // 
            // BT_Select02
            // 
            this.BT_Select02.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_Select02.Location = new System.Drawing.Point(475, 31);
            this.BT_Select02.Name = "BT_Select02";
            this.BT_Select02.Size = new System.Drawing.Size(122, 36);
            this.BT_Select02.TabIndex = 14;
            this.BT_Select02.Text = "(제목 미정)";
            this.BT_Select02.UseVisualStyleBackColor = true;
            this.BT_Select02.Click += new System.EventHandler(this.BT_Select02_Click);
            // 
            // BT_Select03
            // 
            this.BT_Select03.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_Select03.Location = new System.Drawing.Point(603, 31);
            this.BT_Select03.Name = "BT_Select03";
            this.BT_Select03.Size = new System.Drawing.Size(122, 36);
            this.BT_Select03.TabIndex = 14;
            this.BT_Select03.Text = "(제목 미정)";
            this.BT_Select03.UseVisualStyleBackColor = true;
            this.BT_Select03.Click += new System.EventHandler(this.BT_Select03_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_BTName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TB_FolderPath);
            this.groupBox2.Controls.Add(this.BT_SearchDirectory);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.groupBox2.Location = new System.Drawing.Point(20, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 179);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "옵션";
            // 
            // TB_BTName
            // 
            this.TB_BTName.Location = new System.Drawing.Point(9, 37);
            this.TB_BTName.Name = "TB_BTName";
            this.TB_BTName.Size = new System.Drawing.Size(182, 23);
            this.TB_BTName.TabIndex = 6;
            this.TB_BTName.TextChanged += new System.EventHandler(this.TB_BTName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "단축키 이름";
            // 
            // TB_FolderPath
            // 
            this.TB_FolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_FolderPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_FolderPath.Location = new System.Drawing.Point(6, 142);
            this.TB_FolderPath.MaxLength = 256;
            this.TB_FolderPath.Name = "TB_FolderPath";
            this.TB_FolderPath.ReadOnly = true;
            this.TB_FolderPath.Size = new System.Drawing.Size(134, 23);
            this.TB_FolderPath.TabIndex = 4;
            this.TB_FolderPath.TabStop = false;
            // 
            // BT_SearchDirectory
            // 
            this.BT_SearchDirectory.Location = new System.Drawing.Point(144, 142);
            this.BT_SearchDirectory.Name = "BT_SearchDirectory";
            this.BT_SearchDirectory.Size = new System.Drawing.Size(49, 25);
            this.BT_SearchDirectory.TabIndex = 3;
            this.BT_SearchDirectory.Text = "찾기";
            this.BT_SearchDirectory.UseVisualStyleBackColor = true;
            this.BT_SearchDirectory.Click += new System.EventHandler(this.BT_SearchDirectory_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_Copy);
            this.groupBox3.Controls.Add(this.RB_Move);
            this.groupBox3.Location = new System.Drawing.Point(6, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "이미지 이동여부";
            // 
            // RB_Copy
            // 
            this.RB_Copy.AutoSize = true;
            this.RB_Copy.Location = new System.Drawing.Point(10, 43);
            this.RB_Copy.Name = "RB_Copy";
            this.RB_Copy.Size = new System.Drawing.Size(49, 19);
            this.RB_Copy.TabIndex = 1;
            this.RB_Copy.Text = "복사";
            this.RB_Copy.UseVisualStyleBackColor = true;
            this.RB_Copy.CheckedChanged += new System.EventHandler(this.RB_Copy_CheckedChanged);
            // 
            // RB_Move
            // 
            this.RB_Move.Checked = true;
            this.RB_Move.Location = new System.Drawing.Point(10, 17);
            this.RB_Move.Name = "RB_Move";
            this.RB_Move.Size = new System.Drawing.Size(49, 19);
            this.RB_Move.TabIndex = 0;
            this.RB_Move.TabStop = true;
            this.RB_Move.Text = "이동";
            this.RB_Move.UseVisualStyleBackColor = true;
            this.RB_Move.CheckedChanged += new System.EventHandler(this.RB_Move_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "3";
            // 
            // BT_Move
            // 
            this.BT_Move.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_Move.Location = new System.Drawing.Point(20, 621);
            this.BT_Move.Name = "BT_Move";
            this.BT_Move.Size = new System.Drawing.Size(199, 47);
            this.BT_Move.TabIndex = 13;
            this.BT_Move.Text = "이동";
            this.BT_Move.UseVisualStyleBackColor = true;
            this.BT_Move.Click += new System.EventHandler(this.BT_Move_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 680);
            this.Controls.Add(this.BT_Move);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BT_Select03);
            this.Controls.Add(this.BT_Select02);
            this.Controls.Add(this.BT_Select01);
            this.Controls.Add(this.BT_Folder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTReloadPath);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.MainPictureViewer);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "이미지 정리기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void AddList(string strDir)
        {
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            this.listView3.Items.Clear();
            this.listView4.Items.Clear();

            if(this.MainPictureViewer.Image != null)
            {
                this.MainPictureViewer.Image.Dispose();
                this.MainPictureViewer.Image = null;
            }

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(strDir);
            
            foreach (System.IO.FileInfo f in di.GetFiles())
            {
                if(    f.Extension == ".png"
                    || f.Extension == ".PNG"
                    || f.Extension == ".jpg"
                    || f.Extension == ".JPG"
                    || f.Extension == ".jpeg"
                    || f.Extension == ".JPEG"
                    || f.Extension == ".gif"
                    || f.Extension == ".GIF"
                    || f.Extension == ".BMP"
                    || f.Extension == ".bmp"
                    )
                {
                    System.Windows.Forms.ListViewItem subItem =
                        new System.Windows.Forms.ListViewItem(System.IO.Path.GetFileNameWithoutExtension(f.Name));
                    subItem.SubItems.Add(f.Extension.Substring(1));
                    this.listView1.Items.Add(subItem);
                }
            }
            
        }

        private System.Windows.Forms.PictureBox MainPictureViewer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BTReloadPath;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_width;
        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.Label lb_extension;
        private System.Windows.Forms.Button BT_Folder;
        private System.Windows.Forms.Button BT_Select01;
        private System.Windows.Forms.Button BT_Select02;
        private System.Windows.Forms.Button BT_Select03;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_Copy;
        private System.Windows.Forms.RadioButton RB_Move;
        private System.Windows.Forms.Button BT_SearchDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_FolderPath;
        private System.Windows.Forms.Button BT_Move;
        private System.Windows.Forms.TextBox TB_BTName;
        private System.Windows.Forms.Label label6;
    }
}

