namespace ClientSocketTest
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인요청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관제요청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보변경요청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관제해제요청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재난종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.긴급영상요청ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사회적약자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사건정보수신ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재난ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(176, 131);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(576, 27);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(176, 307);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(576, 136);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 490);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.사회적약자ToolStripMenuItem,
            this.재난ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인요청ToolStripMenuItem,
            this.관제요청ToolStripMenuItem,
            this.정보변경요청ToolStripMenuItem,
            this.관제해제요청ToolStripMenuItem,
            this.재난종료ToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 25);
            this.toolStripMenuItem1.Text = "119";
            // 
            // 로그인요청ToolStripMenuItem
            // 
            this.로그인요청ToolStripMenuItem.Name = "로그인요청ToolStripMenuItem";
            this.로그인요청ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.로그인요청ToolStripMenuItem.Text = "로그인요청";
            this.로그인요청ToolStripMenuItem.Click += new System.EventHandler(this.로그인요청ToolStripMenuItem_Click);
            // 
            // 관제요청ToolStripMenuItem
            // 
            this.관제요청ToolStripMenuItem.Name = "관제요청ToolStripMenuItem";
            this.관제요청ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.관제요청ToolStripMenuItem.Text = "관제요청";
            this.관제요청ToolStripMenuItem.Click += new System.EventHandler(this.관제요청ToolStripMenuItem_Click);
            // 
            // 정보변경요청ToolStripMenuItem
            // 
            this.정보변경요청ToolStripMenuItem.Name = "정보변경요청ToolStripMenuItem";
            this.정보변경요청ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.정보변경요청ToolStripMenuItem.Text = "정보변경요청";
            this.정보변경요청ToolStripMenuItem.Click += new System.EventHandler(this.정보변경요청ToolStripMenuItem_Click);
            // 
            // 관제해제요청ToolStripMenuItem
            // 
            this.관제해제요청ToolStripMenuItem.Name = "관제해제요청ToolStripMenuItem";
            this.관제해제요청ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.관제해제요청ToolStripMenuItem.Text = "관제해제요청";
            this.관제해제요청ToolStripMenuItem.Click += new System.EventHandler(this.관제해제요청ToolStripMenuItem_Click);
            // 
            // 재난종료ToolStripMenuItem
            // 
            this.재난종료ToolStripMenuItem.Name = "재난종료ToolStripMenuItem";
            this.재난종료ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.재난종료ToolStripMenuItem.Text = "재난종료";
            this.재난종료ToolStripMenuItem.Click += new System.EventHandler(this.재난종료ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.긴급영상요청ToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 25);
            this.toolStripMenuItem2.Text = "112";
            // 
            // 긴급영상요청ToolStripMenuItem
            // 
            this.긴급영상요청ToolStripMenuItem.Name = "긴급영상요청ToolStripMenuItem";
            this.긴급영상요청ToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.긴급영상요청ToolStripMenuItem.Text = "112긴급영상요청";
            this.긴급영상요청ToolStripMenuItem.Click += new System.EventHandler(this.긴급영상요청ToolStripMenuItem_Click);
            // 
            // 사회적약자ToolStripMenuItem
            // 
            this.사회적약자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사건정보수신ToolStripMenuItem});
            this.사회적약자ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.사회적약자ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.사회적약자ToolStripMenuItem.Name = "사회적약자ToolStripMenuItem";
            this.사회적약자ToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.사회적약자ToolStripMenuItem.Text = "사회적 약자";
            // 
            // 사건정보수신ToolStripMenuItem
            // 
            this.사건정보수신ToolStripMenuItem.Name = "사건정보수신ToolStripMenuItem";
            this.사건정보수신ToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.사건정보수신ToolStripMenuItem.Text = "사건정보수신";
            this.사건정보수신ToolStripMenuItem.Click += new System.EventHandler(this.사건정보수신ToolStripMenuItem_Click);
            // 
            // 재난ToolStripMenuItem
            // 
            this.재난ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.재난ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.재난ToolStripMenuItem.Name = "재난ToolStripMenuItem";
            this.재난ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.재난ToolStripMenuItem.Text = "재난";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(176, 173);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(576, 106);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.logInKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(109, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "HEAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(109, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "DATA :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(103, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "요청값 :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.title.Location = new System.Drawing.Point(54, 65);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(50, 25);
            this.title.TabIndex = 11;
            this.title.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 563);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 로그인요청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관제요청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보변경요청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관제해제요청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재난종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 긴급영상요청ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사회적약자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사건정보수신ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재난ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label title;
    }
}

