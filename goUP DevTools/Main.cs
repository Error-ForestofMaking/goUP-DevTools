using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goUP_DevTools
{
    public partial class Main : Form
    {
        private Point mCurrentPosition;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,      // x-coordinate of upper-left corner
        int nTopRect,       // y-coordinate of upper-left corner
        int nRightRect,     // x-coordinate of lower-right corner
        int nBottomRect,    // y-coordinate of lower-right corner   
        int nWidthEllipse,  // height of ellipse
        int nHeightEllipse  // width of ellipse  
        );

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Please subscribe to [Forest of Making] on YouTube");
            //MessageBox.Show("유튜브에서 만들기의 숲을 구독해 주세요");

            언어listBox.SelectedIndex = 0;
            추가listBox.SelectedIndex = 0;
            검색listBox.SelectedIndex = 0;

            //Search_BT.Region = Region.FromHrgn(CreateRoundRectRgn(2, 2, Search_BT.Width, Search_BT.Height, 15, 15));
            //Sub_BT.Region = Region.FromHrgn(CreateRoundRectRgn(2, 2, Sub_BT.Width, Sub_BT.Height, 15, 15));
        }

        private void Search_BT_Click(object sender, EventArgs e)
        {
            string name = 언어listBox.SelectedItem.ToString() + "[space]" + 추가listBox.SelectedItem.ToString() + "[space]" + textBox1.Text;

            name = name.Replace("+", "%2B");
            name = name.Replace("#", "%23");
            name = name.Replace(" ", "+");
            name = name.Replace("[space]", "+");

            if (검색listBox.SelectedIndex == 0)
            {
                Process.Start("https://www.google.com/search?q=" + name);
            }
            else if (검색listBox.SelectedIndex == 1)
            {
                Process.Start("https://stackoverflow.com/search?q=" + name);
            }
            else if (검색listBox.SelectedIndex == 2)
            {
                Process.Start("https://github.com/search?q=" + name);
            }
        }

        private void Close_BT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                this.Location.X + (mCurrentPosition.X + e.X),
                this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            // 윤곽선 색과 굵기 설정
            Pen pen = new Pen(Color.FromArgb(113, 96, 232), 1);

            // 폼의 경계선 좌표 계산
            int x = this.ClientRectangle.Left;
            int y = this.ClientRectangle.Top;
            int w = this.ClientRectangle.Width - 1;
            int h = this.ClientRectangle.Height - 1;

            // 윤곽선 그리기
            e.Graphics.DrawRectangle(pen, x, y, w, h);
        }

        private void gpt_BT_Click(object sender, EventArgs e)
        {
            Process.Start("https://chat.openai.com/");
            MessageBox.Show("Open ChatGPT");
        }
    }
}
