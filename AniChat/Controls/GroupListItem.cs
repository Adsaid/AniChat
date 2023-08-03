using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniChat
{
    public partial class GroupListItem : UserControl
    {
        int msgNum = 0;
        public GroupListItem(int id, Image image, string name, string description, string admin)
        {
            InitializeComponent();
            GroupId = id;
            GroupAdmin = admin;
            if (image != null)
            {
                UserPictureBox.Image = image;
            }
            UserNamelb.Text = name;
            Descr_lb.Text = description;
        }
        public int GroupId { get; set; }

        public string GroupAdmin { get; set; }

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

    }
}
