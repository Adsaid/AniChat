using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniChat
{
    public partial class UserListItem : UserControl
    {
        int msgNum = 0;

        public int ID { get; set; }
        public string Chatname { get; set; }
        public string GitLink { get; set; }
        public string InLink { get; set; }

        public UserListItem(Image image, string name, string rank)
        {
            InitializeComponent();
            if (image != null)
            {
                UserPictureBox.Image = image;
            }
            UserNamelb.Text = name;
            Rank_lb.Text = rank;
        }

        public void SetnewMsgNum(int num)
        {
            if (num <= 0)
            {
                customPanel1.Visible = false;
                msgNum = 0;
                return;
            }

            msgNum += num;
            newMsgNum_lb.Text = msgNum.ToString();
            customPanel1.Visible = true;
        }
        private void Item_cPl_MouseEnter(object sender, EventArgs e)
        {
            Item_cPl.BackColor = Color.FromArgb(65, 65, 65);
            //Item_cPl.BorderColor = Color.MediumSlateBlue;
        }
        private void Item_cPl_MouseLeave(object sender, EventArgs e)
        {
            Item_cPl.BackColor = Color.FromArgb(35, 35, 35);
            //Item_cPl.BorderColor = Color.FromArgb(35, 35, 35);
        }

        private void gitLink_pb_Click(object sender, EventArgs e)
        {
            LaunchWeblink(GitLink);
        }

        private void InLink_pb_Click(object sender, EventArgs e)
        {
            LaunchWeblink(InLink);
        }

        // Performs the actual browser launch to follow link:
        private void LaunchWeblink(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        // Simple check to make sure link is valid,
        // can be modified to check for other protocols:
        private bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }

        private void UserListItem_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GitLink))
            {
                gitLink_pb.Visible = false;
            }
            if (String.IsNullOrEmpty(InLink))
            {
                InLink_pb.Visible = false;
            }

        }
    }
}
