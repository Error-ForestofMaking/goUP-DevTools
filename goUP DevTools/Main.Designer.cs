namespace goUP_DevTools
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Search_BT = new System.Windows.Forms.Button();
            this.언어listBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.추가listBox = new System.Windows.Forms.ListBox();
            this.검색listBox = new System.Windows.Forms.ListBox();
            this.title_bar = new System.Windows.Forms.Panel();
            this.Close_BT = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpt_BT = new System.Windows.Forms.Button();
            this.title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_BT
            // 
            this.Search_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Search_BT.FlatAppearance.BorderSize = 0;
            this.Search_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_BT.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_BT.ForeColor = System.Drawing.Color.White;
            this.Search_BT.Location = new System.Drawing.Point(321, 61);
            this.Search_BT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_BT.Name = "Search_BT";
            this.Search_BT.Size = new System.Drawing.Size(97, 106);
            this.Search_BT.TabIndex = 0;
            this.Search_BT.Text = "Search\r\n검색";
            this.Search_BT.UseVisualStyleBackColor = false;
            this.Search_BT.Click += new System.EventHandler(this.Search_BT_Click);
            // 
            // 언어listBox
            // 
            this.언어listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.언어listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.언어listBox.ForeColor = System.Drawing.Color.White;
            this.언어listBox.FormattingEnabled = true;
            this.언어listBox.ItemHeight = 15;
            this.언어listBox.Items.AddRange(new object[] {
            "Python",
            "C++",
            "C#",
            "Java",
            "JavaScript",
            "Swift",
            "html"});
            this.언어listBox.Location = new System.Drawing.Point(12, 61);
            this.언어listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.언어listBox.Name = "언어listBox";
            this.언어listBox.Size = new System.Drawing.Size(97, 150);
            this.언어listBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "input";
            // 
            // 추가listBox
            // 
            this.추가listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.추가listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.추가listBox.ForeColor = System.Drawing.Color.White;
            this.추가listBox.FormattingEnabled = true;
            this.추가listBox.ItemHeight = 15;
            this.추가listBox.Items.AddRange(new object[] {
            "",
            "WinFrom",
            "Chrome",
            "Unity",
            "Windows",
            "iOS",
            "MacOS",
            "Android",
            "Linux"});
            this.추가listBox.Location = new System.Drawing.Point(115, 61);
            this.추가listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.추가listBox.Name = "추가listBox";
            this.추가listBox.Size = new System.Drawing.Size(97, 150);
            this.추가listBox.TabIndex = 3;
            // 
            // 검색listBox
            // 
            this.검색listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.검색listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.검색listBox.ForeColor = System.Drawing.Color.White;
            this.검색listBox.FormattingEnabled = true;
            this.검색listBox.ItemHeight = 15;
            this.검색listBox.Items.AddRange(new object[] {
            "Google",
            "stackoverflow",
            "github"});
            this.검색listBox.Location = new System.Drawing.Point(218, 61);
            this.검색listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.검색listBox.Name = "검색listBox";
            this.검색listBox.Size = new System.Drawing.Size(97, 150);
            this.검색listBox.TabIndex = 4;
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.title_bar.Controls.Add(this.Close_BT);
            this.title_bar.Controls.Add(this.label1);
            this.title_bar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(645, 25);
            this.title_bar.TabIndex = 7;
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            // 
            // Close_BT
            // 
            this.Close_BT.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close_BT.Image = global::goUP_DevTools.Properties.Resources.Close_1;
            this.Close_BT.Location = new System.Drawing.Point(406, 3);
            this.Close_BT.Name = "Close_BT";
            this.Close_BT.Size = new System.Drawing.Size(20, 20);
            this.Close_BT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_BT.TabIndex = 8;
            this.Close_BT.TabStop = false;
            this.Close_BT.Click += new System.EventHandler(this.Close_BT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "goUP DevTools | 1.0";
            // 
            // gpt_BT
            // 
            this.gpt_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.gpt_BT.FlatAppearance.BorderSize = 0;
            this.gpt_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpt_BT.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gpt_BT.ForeColor = System.Drawing.Color.White;
            this.gpt_BT.Location = new System.Drawing.Point(321, 175);
            this.gpt_BT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpt_BT.Name = "gpt_BT";
            this.gpt_BT.Size = new System.Drawing.Size(97, 36);
            this.gpt_BT.TabIndex = 8;
            this.gpt_BT.Text = "ChatGPT";
            this.gpt_BT.UseVisualStyleBackColor = false;
            this.gpt_BT.Click += new System.EventHandler(this.gpt_BT_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(430, 225);
            this.Controls.Add(this.gpt_BT);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.검색listBox);
            this.Controls.Add(this.추가listBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.언어listBox);
            this.Controls.Add(this.Search_BT);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "goUP DevTools | 1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.title_bar.ResumeLayout(false);
            this.title_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_BT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_BT;
        private System.Windows.Forms.ListBox 언어listBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox 추가listBox;
        private System.Windows.Forms.ListBox 검색listBox;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.PictureBox Close_BT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gpt_BT;
    }
}

