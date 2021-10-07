using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book.User_Control;

namespace Book
{
    public partial class BookShop : Form
    {
        int PanelWidth;
        bool isCollapsed;
        
        public BookShop()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            labelNum.Text = Program.Number;
            
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 30;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 30;
                if (panelLeft.Width <= 75)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSlidePanel(Control btn) 
        {
            PanelSide.Top = btn.Top;
            PanelSide.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c) 
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnSell);
            UC_Sell ucs = new UC_Sell();
            AddControlsToPanel(ucs);

        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnCollect);

        }

        private void btnShopList_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnShopList);
            UC_List ucl = new UC_List();
            AddControlsToPanel(ucl);

        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnNotify);

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnSet);

        }
    }
}
