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
    public partial class SelectedUserCtrl : UserControl
    {
        public SelectedUserCtrl()
        {
            InitializeComponent();
        }

        public int ID { get; set; }
    }
}
