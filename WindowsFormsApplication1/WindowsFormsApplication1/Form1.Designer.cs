namespace WindowsFormsApplication1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.a = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(12, 71);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(423, 165);
            this.webBrowser2.TabIndex = 2;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 21);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(12, 280);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(423, 165);
            this.webBrowser3.TabIndex = 5;
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted);
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(12, 40);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(629, 414);
            this.webBrowser4.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 21);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add website";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 21);
            this.button4.TabIndex = 8;
            this.button4.Text = "Mix website";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-9, -32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.a);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser3);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1130, 506);
            this.splitContainer1.SplitterDistance = 671;
            this.splitContainer1.TabIndex = 9;
            // 
            // a
            // 
            this.a.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("a.BackgroundImage")));
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.a.ForeColor = System.Drawing.Color.Transparent;
            this.a.Location = new System.Drawing.Point(654, 251);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(23, 23);
            this.a.TabIndex = 0;
            this.a.Text = "button5";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1113, 466);
            this.Controls.Add(this.webBrowser4);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button a;
    }
}

