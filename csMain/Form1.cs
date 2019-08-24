using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace csMain
{
    public struct HotKeyInfo {
        public bool bMove;
        public string KeyName;
        public string folderPath;

        public HotKeyInfo(bool move, string name, string path)
        {
            bMove = move;
            KeyName = name;
            folderPath = path;
        }
    };
    
    public partial class Form1 : Form
    {
        private string  selectPath;
        private int     SelectButton = 0;
        // 1, 2, 3번 리스트의 속성 값.
        HotKeyInfo[]    KeyInfo = { new HotKeyInfo(true, "", ""), new HotKeyInfo(true, "", ""), new HotKeyInfo(true, "", "") };
        MemoryStream    msImage = null;

        public Form1()
        {
            InitializeComponent();
            DialogResult resFolder = this.folderBrowserDialog1.ShowDialog();
            if (resFolder == DialogResult.OK)
            {
                selectPath = this.folderBrowserDialog1.SelectedPath;
                AddList(selectPath);
            }
            else
            {
                this.Close();
                
            }
        }

        //  윈폼 종료 시 호출
        protected override void OnClosed(EventArgs e)
        {
            using (StreamWriter settings = File.CreateText(Path.Combine(Application.StartupPath, "Setting.ini")))
            {
                for (int i = 0; i < 3; ++i)
                    settings.WriteLine("{0}|{1}|{2}", KeyInfo[i].bMove, KeyInfo[i].KeyName, KeyInfo[i].folderPath);

                settings.Close();

            }
            base.OnClosed(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //  Text Box에 포커스가 있다면 처리하지 않는다.
            if (TB_BTName.Focused) return false;
            if (!base.ProcessCmdKey(ref msg, keyData)) // 위에서 처리 안했으면
            {
                // 여기에 처리코드를 넣는다.
                if (keyData.Equals(Keys.Escape))
                {
                    //  종료
                    Close();
                    return true;
                }

                ListView nowSelectListView = null;

                switch (SelectButton)
                {
                    case 0: nowSelectListView = listView1; break;
                    case 1: nowSelectListView = listView2; break;
                    case 2: nowSelectListView = listView3; break;
                    case 3: nowSelectListView = listView4; break;
                }

                if (keyData.Equals(Keys.Oemtilde))
                {
                    if(SelectButton > 0 && nowSelectListView.SelectedItems.Count > 0)
                    {
                        if (this.MainPictureViewer.Image != null)
                        {
                            if (msImage != null) msImage.Close();
                            this.MainPictureViewer.Image.Dispose();
                            this.MainPictureViewer.Image = null;
                        }

                        ListViewItem selectedItem = nowSelectListView.SelectedItems[0];
                        int SelectIndex = nowSelectListView.Items.IndexOf(selectedItem);

                        nowSelectListView.Items.Remove(selectedItem);
                        listView1.Items.Add(selectedItem);

                        if(nowSelectListView.Items.Count > 0)
                            nowSelectListView.Items[Math.Min(nowSelectListView.Items.Count - 1, SelectIndex)].Selected = true;
                    }
                }
                if (keyData.Equals(Keys.D1))
                {
                    if (SelectButton != 1 && nowSelectListView.SelectedItems.Count > 0)
                    {
                        if (this.MainPictureViewer.Image != null)
                        {
                            if (msImage != null) msImage.Close();
                            this.MainPictureViewer.Image.Dispose();
                            this.MainPictureViewer.Image = null;
                        }

                        ListViewItem selectedItem = nowSelectListView.SelectedItems[0];
                        int SelectIndex = nowSelectListView.Items.IndexOf(selectedItem);
                        
                        nowSelectListView.Items.Remove(selectedItem);
                        try { listView2.Items.Add(selectedItem); }
                        catch(Exception ex) { MessageBox.Show(ex.Message); }

                        if (nowSelectListView.Items.Count > 0)
                            nowSelectListView.Items[Math.Min(nowSelectListView.Items.Count - 1, SelectIndex)].Selected = true;
                    }
                }
                else if (keyData.Equals(Keys.D2))
                {
                    if (SelectButton != 2 && nowSelectListView.SelectedItems.Count > 0)
                    {
                        if (this.MainPictureViewer.Image != null)
                        {
                            if (msImage != null) msImage.Close();
                            this.MainPictureViewer.Image.Dispose();
                            this.MainPictureViewer.Image = null;
                        }

                        ListViewItem selectedItem = nowSelectListView.SelectedItems[0];
                        int SelectIndex = nowSelectListView.Items.IndexOf(selectedItem);

                        nowSelectListView.Items.Remove(selectedItem);
                        listView3.Items.Add(selectedItem);

                        if (nowSelectListView.Items.Count > 0)
                            nowSelectListView.Items[Math.Min(nowSelectListView.Items.Count - 1, SelectIndex)].Selected = true;
                    }
                }
                else if (keyData.Equals(Keys.D3))
                {
                    if (SelectButton != 3 && nowSelectListView.SelectedItems.Count > 0)
                    {
                        if (this.MainPictureViewer.Image != null)
                        {
                            if (msImage != null) msImage.Close();
                            this.MainPictureViewer.Image.Dispose();
                            this.MainPictureViewer.Image = null;
                        }

                        ListViewItem selectedItem = nowSelectListView.SelectedItems[0];

                        int SelectIndex = nowSelectListView.Items.IndexOf(selectedItem);

                        nowSelectListView.Items.Remove(selectedItem);
                        listView4.Items.Add(selectedItem);

                        if (nowSelectListView.Items.Count > 0)
                            nowSelectListView.Items[Math.Min(nowSelectListView.Items.Count - 1, SelectIndex)].Selected = true;
                    }
                }
                else
                {
                    return false;
                }

                switch (SelectButton)
                {
                    case 0: listView1 = nowSelectListView; break;
                    case 1: listView2 = nowSelectListView; break;
                    case 2: listView3 = nowSelectListView; break;
                    case 3: listView4 = nowSelectListView; break;
                }

                
                return true;

            }
            else
            {
                return true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(Path.Combine(Application.StartupPath, "Setting.ini")))
            {
                StreamReader settings = File.OpenText(Path.Combine(Application.StartupPath, "Setting.ini"));
                for (int i = 0; i < 3; ++i)
                {
                    string str = settings.ReadLine();
                    string[] parses = str.Split('|');
                    if (parses[0].Equals("False"))
                         KeyInfo[i].bMove = false;
                    else KeyInfo[i].bMove = true;

                    KeyInfo[i].KeyName = parses[1];
                    KeyInfo[i].folderPath = parses[2];
                    
                }

                this.BT_Select01.Text = KeyInfo[0].KeyName;
                this.BT_Select02.Text = KeyInfo[1].KeyName;
                this.BT_Select03.Text = KeyInfo[2].KeyName;
                
                settings.Close();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MainPictureViewer.Image != null)
            {
                if (msImage != null) msImage.Close();
                this.MainPictureViewer.Image.Dispose();
                this.MainPictureViewer.Image = null;
            }

            lb_width.Text = "";
            lb_x.Visible = false;
            lb_height.Text = "";
            lb_extension.Text = "";
            linkLabel1.Text = "클릭하여 해당 폴더를 열 수 있습니다.";

            if (((ListView)sender).SelectedItems.Count == 0) return;

            ListViewItem selectedItem = ((ListView)sender).SelectedItems[0];
            //  왠지 모르게 SubItem의 인덱스는 1부터.
            string filename = selectedItem.Text + '.' + selectedItem.SubItems[1].Text;
            string allpath = System.IO.Path.Combine(selectPath, filename);

            Image img = null;

            try
            {
                if (msImage != null) msImage.Close();
                msImage = new MemoryStream(File.ReadAllBytes(allpath));
                img = System.Drawing.Image.FromStream(msImage);
            }
            catch (Exception exception)
            {
                this.MainPictureViewer.Image = null;

                DialogResult res = MessageBox.Show(string.Format("읽을 수 없는 파일입니다!\n원인 : {0}", exception.Message));

                return;
            }

            Size ViewerSize = this.MainPictureViewer.Size;
            Size imgSize = img.Size;

            lb_width.Text = imgSize.Width.ToString();
            lb_x.Visible = true;
            lb_height.Text = imgSize.Height.ToString();
            lb_extension.Text = selectedItem.SubItems[1].Text;
            linkLabel1.Text = allpath;

            if (selectedItem.SubItems[1].Text == "GIF" || selectedItem.SubItems[1].Text == "gif")
            {
                this.MainPictureViewer.Image = img;
            }
            else
            {
                Bitmap bmp = new Bitmap(ViewerSize.Width, ViewerSize.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    float fResize = 1.0f;
                    if (imgSize.Height > imgSize.Width)
                    {
                        if (imgSize.Height > ViewerSize.Height) fResize = (float)ViewerSize.Height / (float)imgSize.Height;
                    }
                    else
                    {
                        if (imgSize.Width > ViewerSize.Width) fResize = (float)ViewerSize.Width / (float)imgSize.Width;
                    }

                    imgSize.Width = (int)(imgSize.Width * fResize);
                    imgSize.Height = (int)(imgSize.Height * fResize);

                    g.DrawImage(img, (ViewerSize.Width - imgSize.Width) / 2, (ViewerSize.Height - imgSize.Height) / 2, imgSize.Width, imgSize.Height);

                    this.MainPictureViewer.Image = bmp;
                }

            }
        }
        
        private void BTReloadPath_Click(object sender, EventArgs e)
        {
            DialogResult resFolder = this.folderBrowserDialog1.ShowDialog();
            if (resFolder == DialogResult.OK)
            {
                listView1.Items.Clear();
                selectPath = this.folderBrowserDialog1.SelectedPath;
                AddList(this.folderBrowserDialog1.SelectedPath);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lb_x.Visible == false) return;

            // Run Explorer with select item
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = @"explorer.exe";
            process.StartInfo.Arguments = "/select, " + linkLabel1.Text;
            process.Start();
        //  System.Diagnostics.Process.Start("explorer.exe", string.Format("/select, {0}", linkLabel1.Text));
        }

        private void TB_BTName_TextChanged(object sender, EventArgs e)
        {
            if (SelectButton == 0) return;
            switch (SelectButton)
            {
                case 1:
                    BT_Select01.Text = TB_BTName.Text;
                    break;
                case 2:
                    BT_Select02.Text = TB_BTName.Text;
                    break;
                case 3:
                    BT_Select03.Text = TB_BTName.Text;
                    break;
            }
            
            KeyInfo[SelectButton - 1].KeyName = TB_BTName.Text;
        }

        private void BT_Folder_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
            listView4.SelectedItems.Clear();

            if (this.MainPictureViewer.Image != null)
            {
                if (msImage != null) msImage.Close();
                this.MainPictureViewer.Image.Dispose();
                this.MainPictureViewer.Image = null;
            }

            SelectButton = 0;
            this.TB_BTName.Text = "";
            this.TB_BTName.Enabled = false;

            this.RB_Move.Checked = false;
            this.RB_Copy.Checked = false;

            this.TB_FolderPath.Text = "";
            this.TB_BTName.Text = "";

            this.listView1.Visible = true;
            this.listView2.Visible = false;
            this.listView3.Visible = false;
            this.listView4.Visible = false;

        }

        private void BT_Select01_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
            listView4.SelectedItems.Clear();

            if (this.MainPictureViewer.Image != null)
            {
                if (msImage != null) msImage.Close();
                this.MainPictureViewer.Image.Dispose();
                this.MainPictureViewer.Image = null;
            }

            SelectButton = 1;
            this.TB_BTName.Enabled = true;
            this.TB_BTName.Text = BT_Select01.Text;

            this.RB_Move.Checked = KeyInfo[SelectButton - 1].bMove;
            this.RB_Copy.Checked = !(KeyInfo[SelectButton - 1].bMove);
            this.TB_FolderPath.Text = KeyInfo[SelectButton - 1].folderPath;

            this.listView1.Visible = false;
            this.listView2.Visible = true;
            this.listView3.Visible = false;
            this.listView4.Visible = false;
        }

        private void BT_Select02_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
            listView4.SelectedItems.Clear();

            if (this.MainPictureViewer.Image != null)
            {
                if (msImage != null) msImage.Close();
                this.MainPictureViewer.Image.Dispose();
                this.MainPictureViewer.Image = null;
            }

            SelectButton = 2;
            this.TB_BTName.Enabled = true;
            this.TB_BTName.Text = BT_Select02.Text;

            this.RB_Move.Checked = KeyInfo[SelectButton - 1].bMove;
            this.RB_Copy.Checked = !(KeyInfo[SelectButton - 1].bMove);
            this.TB_FolderPath.Text = KeyInfo[SelectButton - 1].folderPath;

            this.listView1.Visible = false;
            this.listView2.Visible = false;
            this.listView3.Visible = true;
            this.listView4.Visible = false;
        }

        private void BT_Select03_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
            listView3.SelectedItems.Clear();
            listView4.SelectedItems.Clear();

            if (this.MainPictureViewer.Image != null)
            {
                if (msImage != null) msImage.Close();
                this.MainPictureViewer.Image.Dispose();
                this.MainPictureViewer.Image = null;
            }

            SelectButton = 3;
            this.TB_BTName.Enabled = true;
            this.TB_BTName.Text = BT_Select03.Text;

            this.RB_Move.Checked = KeyInfo[SelectButton - 1].bMove;
            this.RB_Copy.Checked = !(KeyInfo[SelectButton - 1].bMove);
            this.TB_FolderPath.Text = KeyInfo[SelectButton - 1].folderPath;

            this.listView1.Visible = false;
            this.listView2.Visible = false;
            this.listView3.Visible = false;
            this.listView4.Visible = true;
        }

        private void BT_SearchDirectory_Click(object sender, EventArgs e)
        {
            if (SelectButton == 0) return;

            DialogResult resFolder = this.folderBrowserDialog1.ShowDialog();
            if (resFolder == DialogResult.OK)
            {
                KeyInfo[SelectButton - 1].folderPath = this.folderBrowserDialog1.SelectedPath;
                this.TB_FolderPath.Text = KeyInfo[SelectButton - 1].folderPath;
            }
        }

        private void RB_Move_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectButton == 0) return;
            if(RB_Move.Checked == true) KeyInfo[SelectButton - 1].bMove = true;
        }

        private void RB_Copy_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectButton == 0) return;
            if (RB_Copy.Checked == true) KeyInfo[SelectButton - 1].bMove = false;
        }

        private void BT_Move_Click(object sender, EventArgs e)
        {
            if (this.MainPictureViewer.Image != null)
            {
                if (msImage != null) msImage.Close();
                this.MainPictureViewer.Image.Dispose();
                this.MainPictureViewer.Image = null;
            }

            int[] donotaltFiles = new int[3];
            int[] altFiles = new int[3];
            int listCount = 0;
            for (int i = 0; i < listView2.Items.Count; ++i)
            {
                string strName = listView2.Items[i].Text;
                string strExtension = listView2.Items[i].SubItems[1].Text;
                string strPathSrc = Path.Combine(selectPath, strName + '.' + strExtension);
                string strPathDst = Path.Combine(KeyInfo[0].folderPath, strName + '.' + strExtension);

                if (KeyInfo[listCount].folderPath != "" && File.Exists(strPathSrc) && !(File.Exists(strPathDst)))
                {
                    if (KeyInfo[listCount].bMove)
                         System.IO.File.Move(strPathSrc, strPathDst);
                    else System.IO.File.Copy(strPathSrc, strPathDst, true);
                    altFiles[listCount]++;
                }
                else if (File.Exists(strPathDst))
                {
                    string strMessage = string.Format("파일이 중복됩니다. 바꾸시겠습니까?\n");
                    DialogResult dr = MessageBox.Show(strMessage, "중복!", MessageBoxButtons.OKCancel);
                    if(DialogResult.OK == dr)
                    {
                        System.IO.File.Delete(strPathDst);
                        if (KeyInfo[listCount].bMove)
                            System.IO.File.Move(strPathSrc, strPathDst);
                        else System.IO.File.Copy(strPathSrc, strPathDst, true);
                        altFiles[listCount]++;
                    }
                    else donotaltFiles[listCount]++;
                }
                else donotaltFiles[listCount]++;
            }

            listCount = 1;

            for (int i = 0; i < listView3.Items.Count; ++i)
            {
                string strName = listView3.Items[i].Text;
                string strExtension = listView3.Items[i].SubItems[1].Text;
                string strPathSrc = Path.Combine(selectPath, strName + '.' + strExtension);
                string strPathDst = Path.Combine(KeyInfo[1].folderPath, strName + '.' + strExtension);

                if (KeyInfo[listCount].folderPath != "" && File.Exists(strPathSrc) && !(File.Exists(strPathDst)))
                {
                    if (KeyInfo[listCount].bMove)
                        System.IO.File.Move(strPathSrc, strPathDst);
                    else System.IO.File.Copy(strPathSrc, strPathDst, true);
                    altFiles[listCount]++;
                }
                else if (File.Exists(strPathDst))
                {
                    string strMessage = string.Format("파일이 중복됩니다. 바꾸시겠습니까?\n");
                    DialogResult dr = MessageBox.Show(strMessage, "중복!", MessageBoxButtons.OKCancel);
                    if (DialogResult.OK == dr)
                    {
                        System.IO.File.Delete(strPathDst);
                        if (KeyInfo[listCount].bMove)
                            System.IO.File.Move(strPathSrc, strPathDst);
                        else System.IO.File.Copy(strPathSrc, strPathDst, true);
                        altFiles[listCount]++;
                    }
                    else donotaltFiles[listCount]++;
                }
                else donotaltFiles[listCount]++;
            }

            listCount = 2;

            for (int i = 0; i < listView4.Items.Count; ++i)
            {
                string strName = listView4.Items[i].Text;
                string strExtension = listView4.Items[i].SubItems[1].Text;
                string strPathSrc = Path.Combine(selectPath, strName + '.' + strExtension);
                string strPathDst = Path.Combine(KeyInfo[2].folderPath, strName + '.' + strExtension);

                if (KeyInfo[listCount].folderPath != "" && File.Exists(strPathSrc) && !(File.Exists(strPathDst)))
                {
                    if (KeyInfo[listCount].bMove)
                        System.IO.File.Move(strPathSrc, strPathDst);
                    else System.IO.File.Copy(strPathSrc, strPathDst, true);
                    altFiles[listCount]++;
                }
                else if (File.Exists(strPathDst))
                {
                    string strMessage = string.Format("파일이 중복됩니다. 바꾸시겠습니까?\n");
                    DialogResult dr = MessageBox.Show(strMessage, "중복!", MessageBoxButtons.OKCancel);
                    if (DialogResult.OK == dr)
                    {
                        System.IO.File.Delete(strPathDst);
                        if (KeyInfo[listCount].bMove)
                            System.IO.File.Move(strPathSrc, strPathDst);
                        else System.IO.File.Copy(strPathSrc, strPathDst, true);
                        altFiles[listCount]++;
                    }
                    else donotaltFiles[listCount]++;
                }
                else donotaltFiles[listCount]++;
            }

            MessageBox.Show(string.Format(
                "{0} : 성공({1}), 실패({2})\n{3} : 성공({4}), 실패({5})\n{6} : 성공({7}), 실패({8})\n",
                KeyInfo[0].KeyName, altFiles[0], donotaltFiles[0],
                KeyInfo[1].KeyName, altFiles[1], donotaltFiles[1],
                KeyInfo[2].KeyName, altFiles[2], donotaltFiles[2]
                ), "결과보고");

            AddList(selectPath);
        }

        private void MainPictureViewer_MouseDown(object sender, MouseEventArgs e)
        {
            ListView nowSelectListView = null;

            switch (SelectButton)
            {
                case 0: nowSelectListView = listView1; break;
                case 1: nowSelectListView = listView2; break;
                case 2: nowSelectListView = listView3; break;
                case 3: nowSelectListView = listView4; break;
            }
            ListViewItem selectedItem = nowSelectListView.SelectedItems[0];

            string filename = selectedItem.Text + '.' + selectedItem.SubItems[1].Text;
            string allpath = System.IO.Path.Combine(selectPath, filename);

            string[] paths = { allpath };

            DataObject dataObj = new DataObject(DataFormats.FileDrop, paths);

            DoDragDrop(dataObj, DragDropEffects.All);

        }
        
        //      public bool CheckSameFile(string path, string fileName) { return (System.IO.File.Exists(path + fileName)); }

    }

}
