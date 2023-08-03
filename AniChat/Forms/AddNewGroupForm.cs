using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AniChat
{
    public partial class AddNewGroupForm : Form
    {
        private DataTable dtusers;
        private string pathToImage;
        private List<UserListItem> contacts = new List<UserListItem>();

        public AddNewGroupForm()
        {
            InitializeComponent();

            Members_tLPanel.AutoScroll = true;
        }

        private async void AddNewGroupForm_Load(object sender, EventArgs e)
        {
            await LoadContactsFromDb();
        }

        public async Task LoadContactsFromDb()
        {
            contacts.Clear();

            string sqlStr = $"SELECT idChat_Users, Foto, Login, Rank FROM chat_users " +
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

                userListItem.Item_cPl.Click += ListItemU_Click;
                contacts.Add(userListItem);
            }

            ShowContact();
        }

        private void ShowContact()
        {
            Members_tLPanel.Controls.Clear();
            foreach (var item in contacts)
            {
                item.Height = 80;
                item.Dock = DockStyle.Top;
                item.UserPictureBox.Width = 45;
                item.UserPictureBox.Height = 45;

                Members_tLPanel.Controls.Add(item);
            }
        }

        public async Task Load_UsersFromDb(string text)
        {
            Members_tLPanel.Controls.Clear();

            string sqlStr = $"SELECT idChat_Users, Foto, Login, Rank FROM Chat_Users " +
                            $"WHERE Login != '{Info.nameUser}' " +
                            $"AND (Login LIKE '%{text}%' OR Rank LIKE '%{text}%');";

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

                userListItem.Item_cPl.Click += ListItemU_Click;

                userListItem.Height = 80;
                userListItem.Dock = DockStyle.Top;
                userListItem.UserPictureBox.Width = 45;
                userListItem.UserPictureBox.Height = 45;
                Members_tLPanel.Controls.Add(userListItem);
            }
        }

        private void ListItemU_Click(object sender, EventArgs e)
        {
            UserListItem userListItem = (UserListItem)((CustomPanel)sender).Parent;

            SelectedUserCtrl selectedUserCtrl = new SelectedUserCtrl();
            selectedUserCtrl.ID = userListItem.ID;
            selectedUserCtrl.UserImageBox.Image = userListItem.UserPictureBox.Image;
            selectedUserCtrl.UserName.Text = userListItem.UserNamelb.Text;

            selectedUserCtrl.RemMbrsBtn.Click += selectedUserCtrl_Click;

            bool isAdded = false;
            if (AddedUser_fLPanel.Controls.Count == 0)
            {
                AddedUser_fLPanel.Controls.Add(selectedUserCtrl);
            }
            else
            {
                foreach (SelectedUserCtrl item in AddedUser_fLPanel.Controls)
                {
                    if (item.ID.Equals(selectedUserCtrl.ID))
                    {
                        isAdded = true;
                        break;
                    }
                    else
                    {
                        isAdded = false;
                    }
                }
            }

            if (!isAdded)
            {
                AddedUser_fLPanel.Controls.Add(selectedUserCtrl);
            }
        }

        private void selectedUserCtrl_Click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            CustomPanel customPanel = (CustomPanel)((Button)sender).Parent;
            SelectedUserCtrl selectedUserCtrl = (SelectedUserCtrl)customPanel.Parent;
            AddedUser_fLPanel.Controls.Remove(selectedUserCtrl);
        }

        private void Picture_Groupbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Виберіть файл";
            openFileDialog1.Filter = "img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            {
                pathToImage = openFileDialog1.FileName;
                PictureGroupbox.Image = Image.FromFile(pathToImage);
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Info.idUser.ToString());

            // Update `group_users` set Foto = @File where Login = '{Info.nameUser}' ";

            if (string.IsNullOrWhiteSpace(GpName_tbx.Text))
            {
                MessageBox.Show("Enter name!!!");
                return;
            }

            if (AddedUser_fLPanel.Controls.Count == 0)
            {
                MessageBox.Show("Add members !!!");
                return;
            }

            string sqlStr = "INSERT INTO `group_users` (`GroupName`, `Description`, `Admin`) " +
                           $"VALUES ('{GpName_tbx.Text}','{Des_tbx.Text}','{Info.nameUser}'); " +
                            "SELECT LAST_INSERT_ID();";

            int idGp = Info.InsertToDB(sqlStr);

            string sqlStrfoto = $"UPDATE `group_users` SET `Image`= @File WHERE `IdGp`='{idGp}';";

            Info.UploadFileToDB(pathToImage, sqlStrfoto);
            AddMembersInDB(idGp);

            //MessageBox.Show("Group was created!!!");
            this.Close();
        }

        private void AddMembersInDB(int idGp)
        {
            string sqlStr = $"INSERT INTO `user_in_groups` (`groupId`, `userId`) VALUES ('{idGp}', '{Info.idUser}') ";

            foreach (SelectedUserCtrl member in AddedUser_fLPanel.Controls)
            {
                sqlStr += $", ('{idGp}', '{member.ID}')";
            }

            Info.SelectFromDB(sqlStr);

        }

        private void Cansel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(Search_tb.Text)) return;

                await Load_UsersFromDb(Search_tb.Text);
            }
        }

        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            if (Search_tb.Text.Length <= 0)
            {
                ShowContact();
            }
        }
    }
}
