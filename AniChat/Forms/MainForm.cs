using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AniChat.AniService;
using Newtonsoft.Json.Linq;

namespace AniChat
{
    public partial class MainForm : Form, IServiceAniChatCallback
    {
        ServiceAniChatClient client;
        private bool isUserConn = false;
        int ID;
        
        private bool isShow = true;
        private Form activeForm = null;
        private ChatForm chatForm1;
        private UserListItem prevUserItem;
        private GroupListItem prevGroupItem;
        DataTable dtusers;
        private List<UserListItem> contacts = new List<UserListItem>();
        private List<GroupListItem> groups = new List<GroupListItem>();

        //byte[] b_data;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void mainForm_Load(object sender, EventArgs e)
        {
            ContactListPanel.AutoScroll = true;
            //panel_Menu.AutoScroll = true;

            panel_Menu.Size = new Size(Swich_list_panel.Width, panel_Menu.Size.Height);
            NameLabel.Text = Info.nameUser;

            chatForm1 = new ChatForm(null,"",0);
            chatForm1.Name = "Chat";
            underscore_Contact_pl.Visible = true;
            underscore_Group_pl.Visible = false;

            Search_tb.LostFocus += Search_tb_LostFocus;

            await LoadProfilePhoto();
            await LoadContactsFromDb();

            client = new ServiceAniChatClient(new System.ServiceModel.InstanceContext(this));

            if (isUserConn)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();
            }

        }
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (activeForm != null) activeForm.Close();

            DisconnectUser();
            isUserConn = false;

            Application.Exit();
        }

        private void Search_tb_LostFocus(object sender, EventArgs e)
        {
            Search_tb.Visible = false;
        }

        private async Task LoadProfilePhoto()
        {
            byte[] bData = await Task.Run(() => Info.DownloadFileFromDB($"SELECT Foto FROM Chat_Users WHERE idChat_Users = '{Info.idUser}'"));

            if (bData != null)
            {
                using (MemoryStream memImage = new MemoryStream(bData))
                {
                    circlePicture_box1.Image = Image.FromStream(memImage);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if (this.Size.Width <= this.MinimumSize.Width + 150) return;

            //await MenuPanelAnimation();
        }

        private void Setting_menu_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.FormClosed += SettingForm_FormClosed;
            OpenChildform(settingForm);
            ResetListItem();
        }

        private void ResetListItem()
        {
            if (underscore_Contact_pl.Visible) 
            {
                prevUserItem = null;
                for (int i = 0; i < ContactListPanel.Controls.Count; i++)
                {
                    ((UserListItem)ContactListPanel.Controls[i]).Item_cPl.BorderColor = Color.FromArgb(35, 35, 35);
                }
            }
            if (underscore_Group_pl.Visible) 
            {
                prevGroupItem = null;
                for (int i = 0; i < ContactListPanel.Controls.Count; i++)
                {
                    ((GroupListItem)ContactListPanel.Controls[i]).Item_cPl.BorderColor = Color.FromArgb(35, 35, 35);
                }
            }
        }

        private async void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           await LoadProfilePhoto();
        }

        public void OpenChildform(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_form_out.Controls.Add(childForm);
            panel_form_out.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        public async Task LoadUsersFromDb(string text)
        {
            ContactListPanel.Controls.Clear();

            string sqlStr = $"SELECT idChat_Users, Foto, Login, Rank FROM Chat_Users " +
                            $"WHERE Login != '{Info.nameUser}' " +
                            $"AND (Login LIKE '%{text}%' OR Rank LIKE '%{text}%');";
            dtusers = await Task.Run(() => Info.SelectFromDB(sqlStr));

            foreach (DataRow row in dtusers.Rows)
            {
                byte[] fotoData = row.Field<byte[]>(1);
                Image image = null;

                if (fotoData != null && fotoData.Length > 0)
                {
                    using (MemoryStream memImage = new MemoryStream(fotoData))
                    {
                        image = Image.FromStream(memImage);
                    }
                }

                UserListItem userListItem = new UserListItem(image, row.Field<string>(2), row.Field<string>(3));
                userListItem.ID = row.Field<int>(0);
                userListItem.Item_cPl.Click += ListItemU_Click;
                ContactListPanel.Controls.Add(userListItem);
            }
        }

        public async Task LoadContactsFromDb()
        {
            contacts.Clear();

            string sqlStr = $"SELECT idChat_Users, Foto, Login, Rank, Gitlink, Inlink, newMessNum FROM chat_users " +
                            $"INNER JOIN user_in_contact ON idChat_Users = contactUserId " +
                            $"WHERE userId = {Info.idUser}";

            dtusers = await Task.Run(() => Info.SelectFromDB(sqlStr));

            foreach (DataRow row in dtusers.Rows)
            {
                Image image = null;
                byte[] fotoData = row.Field<byte[]>(1);

                if (fotoData != null && fotoData.Length > 0)
                {
                    using (MemoryStream memImage = new MemoryStream(fotoData))
                    {
                        image = Image.FromStream(memImage);
                    }
                }

                UserListItem userListItem = new UserListItem(image, row.Field<string>(2), row.Field<string>(3));
                userListItem.ID = row.Field<int>(0);
                userListItem.GitLink = row.Field<string>(4);
                userListItem.InLink = row.Field<string>(5);
                userListItem.Chatname = string.Concat((userListItem.UserNamelb.Text + Info.nameUser).OrderBy(c => c));
                userListItem.SetnewMsgNum(row.Field<int>(6));

                userListItem.Item_cPl.Click += ListItemC_Click;
                contacts.Add(userListItem);
            }

            ShowContacts();
        }

        private void ShowContacts()
        {
            foreach (UserListItem item in contacts)
            {
                item.Width = ContactListPanel.Width - 10;
                if (prevUserItem != null && prevUserItem.UserNamelb.Text == item.UserNamelb.Text)
                {
                    item.Item_cPl.BorderColor = Color.MediumSlateBlue;
                    prevUserItem = item;
                }
                ContactListPanel.Controls.Add(item);
            }
        }

        public async Task LoadGroupsFromDb()
        {
            groups.Clear();

            string sqlStr = $"SELECT IdGp, Image, GroupName, Description, Admin, newMessNum FROM chat_users " +
                            $"INNER JOIN user_in_groups ON chat_users.idChat_Users = user_in_groups.userId " +
                            $"INNER JOIN group_users ON group_users.IdGp = user_in_groups.groupId " +
                            $"WHERE chat_users.idChat_Users = {Info.idUser}";

            dtusers = await Task.Run(() => Info.SelectFromDB(sqlStr));

            foreach (DataRow row in dtusers.Rows)
            {
                Image image = null;
                byte[] fotoData = row.Field<byte[]>(1);

                if (fotoData != null && fotoData.Length > 0)
                {
                    using (MemoryStream memImage = new MemoryStream(fotoData))
                    {
                        image = Image.FromStream(memImage);
                    }
                }

                GroupListItem groupListItem = new GroupListItem(
                    row.Field<int>(0),
                    image,
                    row.Field<string>(2),
                    row.Field<string>(3),
                    row.Field<string>(4));

                groupListItem.SetnewMsgNum(row.Field<int>(5));
                groupListItem.Item_cPl.Click += ListItemG_Click;

                groups.Add(groupListItem);
            }

            ShowGroups();
        }

        private void ShowGroups()
        {
            foreach (GroupListItem item in groups)
            {
                item.Width = ContactListPanel.Width - 10;
                if (prevGroupItem != null && prevGroupItem.UserNamelb.Text == item.UserNamelb.Text)
                {
                    item.Item_cPl.BorderColor = Color.MediumSlateBlue;
                    prevGroupItem = item;
                }
                ContactListPanel.Controls.Add(item);
            }
        }

        private void ListItemU_Click(object sender, EventArgs e)
        {
            UserListItem userListItem = (UserListItem)((CustomPanel)sender).Parent;
            var exist = contacts.FirstOrDefault(obj => obj.ID == userListItem.ID);
            if (exist == null)
            {
                string strSql = $"INSERT INTO `user_in_contact` (`userId`, `contactUserId`, `newMessNum`) VALUES ({Info.idUser}, {userListItem.ID}, 0); " +
                                $"INSERT INTO `user_in_contact` (`userId`, `contactUserId`, `newMessNum`) VALUES ({userListItem.ID}, {Info.idUser}, 0); ";
                Info.InsertToDB(strSql);
            }

            contact_swich_btn.PerformClick();
            OpenContactChat(userListItem);
        }

        private void ListItemC_Click(object sender, EventArgs e)
        {
            UserListItem userListItem = (UserListItem)((CustomPanel)sender).Parent;
            OpenContactChat(userListItem);
        }

        private void OpenContactChat(UserListItem userListItem)
        {
            chatForm1 = new ChatForm(userListItem.UserPictureBox.Image, userListItem.UserNamelb.Text, userListItem.ID);
            chatForm1.Name = userListItem.Chatname;
            if(prevUserItem != null)
            {
                prevUserItem.Item_cPl.BorderColor = Color.FromArgb(35, 35, 35);
            }
            prevGroupItem = null;
            userListItem.Item_cPl.BorderColor = Color.MediumSlateBlue;
            prevUserItem = userListItem;

            userListItem.SetnewMsgNum(0);
            OpenChildform(chatForm1);
        }

        private void ListItemG_Click(object sender, EventArgs e)
        {
            GroupListItem groupListItem = (GroupListItem)((CustomPanel)sender).Parent;
            string chat_name = groupListItem.UserNamelb.Text;

            ChatGroupForm chatGroup = new ChatGroupForm(
                groupListItem.GroupId,
                groupListItem.UserPictureBox.Image,
                groupListItem.UserNamelb.Text,
                groupListItem.GroupAdmin);

            chatGroup.Name = chat_name;
            chatGroup.delete_gp_btn.Click += Delete_gp_btn_Click;

            if (prevGroupItem != null)
            {
                prevGroupItem.Item_cPl.BorderColor = Color.FromArgb(35, 35, 35);
            }

            prevUserItem = null;
            groupListItem.Item_cPl.BorderColor = Color.MediumSlateBlue;
            prevGroupItem = groupListItem;

            groupListItem.SetnewMsgNum(0);
            OpenChildform(chatGroup);
        }

        private void Delete_gp_btn_Click(object sender, EventArgs e)
        {
            group_swich_btn.PerformClick();
        }

        private async void contact_swich_btn_Click(object sender, EventArgs e)
        {
            underscore_Group_pl.Visible = false;
            underscore_Contact_pl.Visible = true;

            ContactListPanel.Controls.Clear();
            await LoadContactsFromDb();
        }

        private async void group_swich_btn_Click(object sender, EventArgs e)
        {
            underscore_Group_pl.Visible = true;
            underscore_Contact_pl.Visible = false;

            ContactListPanel.Controls.Clear();
            await LoadGroupsFromDb();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            AddNewGroupForm addNewGroupForm = new AddNewGroupForm();
            addNewGroupForm.FormClosed += AddNewGroupForm_FormClosed;
            OpenChildform(addNewGroupForm);
            ResetListItem();
        }

        private void AddNewGroupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            group_swich_btn.PerformClick();
        }

        private void panel_Menu_SizeChanged(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.HorizontalScroll.Maximum = 0;
            panel.Update();
        }

        private async void mainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width <= this.MinimumSize.Width + 150 && WindowState != FormWindowState.Minimized)
            {
                await Task.Run(() => Invoke((Action)MenuPanelAnimation_hide));
                return;
            }
            if (this.Size.Width >= this.MinimumSize.Width + 150)
            {
                await Task.Run(() => Invoke((Action)MenuPanelAnimation_show));
                return;
            }
        }

        private void MenuPanelAnimation_hide()
        {
            //<---
            if (isShow)
            {
                panel_Menu.Hide();

                isShow = false;
            }
        }

        private void MenuPanelAnimation_show()
        {
            //--->
            if (!isShow)
            {
                panel_Menu.Show();
                
                isShow = true;
            }
        }

        private async void Search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(Search_tb.Text)) return;

                await LoadUsersFromDb(Search_tb.Text);
            }
        }

        public void MsgCallback(string msg)
        {
            var json = JObject.Parse(msg);
            string chatname = json["chatname"].ToString();

            if (activeForm != null)
            {
                if (chatname == activeForm.Name) return;
            }

            dynamic item = contacts.FirstOrDefault(obj => obj.Chatname == chatname);
            if (item == null)
            {
                item = groups.FirstOrDefault(obj => obj.UserNamelb.Text == chatname);
                if (item == null) return;
            }

            item.SetnewMsgNum(1);

            if (WindowState == FormWindowState.Minimized || !isShow)
            {
                string text = String.Empty;
                if (json["message"].ToString() != String.Empty)
                {
                    text = json["message"].ToString();
                }
                Alert($"From {item.UserNamelb.Text} !\n{text}");
            }
        }
        public void Alert(string msg)
        {
            FormAlert formAlert = new FormAlert();
            formAlert.ShowAlert(msg);
        }

        public void ConnectUser()
        {
            if (!isUserConn)
            {

                try
                {
                    ID = client.Connect(Info.nameUser, "notification");
                    isUserConn = true;
                }
                catch
                {
                    MessageBox.Show("Неможливо з'єднатися Host недоступний!",
                        "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DisconnectUser()
        {
            if (isUserConn)
            {
                client.Disconnect(ID, "notification");
                isUserConn = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Search_tb.Visible = !Search_tb.Visible;
            if (Search_tb.Visible)
            {
                Search_tb.Text = String.Empty;
                Search_tb.Focus();
            }
        }

        private void GPTBot_btn_Click(object sender, EventArgs e)
        {
            BotsForm botsForm = new BotsForm("OpenAI");
            OpenChildform(botsForm);
            ResetListItem();
        }
    }
}