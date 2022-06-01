namespace _01_201202_P2PMessenger_ShortMessage
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
            this.tBox_My_IP = new System.Windows.Forms.TextBox();
            this.tBox_My_Port = new System.Windows.Forms.TextBox();
            this.tBox_Other_IP = new System.Windows.Forms.TextBox();
            this.tBox_Other_Port = new System.Windows.Forms.TextBox();
            this.btn_My_Set = new System.Windows.Forms.Button();
            this.btn_Other_Set = new System.Windows.Forms.Button();
            this.tBox_Msg = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lBox_Msg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tBox_My_IP
            // 
            this.tBox_My_IP.Location = new System.Drawing.Point(12, 12);
            this.tBox_My_IP.Name = "tBox_My_IP";
            this.tBox_My_IP.Size = new System.Drawing.Size(299, 21);
            this.tBox_My_IP.TabIndex = 0;
            // 
            // tBox_My_Port
            // 
            this.tBox_My_Port.Location = new System.Drawing.Point(334, 12);
            this.tBox_My_Port.Name = "tBox_My_Port";
            this.tBox_My_Port.Size = new System.Drawing.Size(106, 21);
            this.tBox_My_Port.TabIndex = 1;
            // 
            // tBox_Other_IP
            // 
            this.tBox_Other_IP.Location = new System.Drawing.Point(12, 39);
            this.tBox_Other_IP.Name = "tBox_Other_IP";
            this.tBox_Other_IP.Size = new System.Drawing.Size(299, 21);
            this.tBox_Other_IP.TabIndex = 3;
            // 
            // tBox_Other_Port
            // 
            this.tBox_Other_Port.Location = new System.Drawing.Point(334, 39);
            this.tBox_Other_Port.Name = "tBox_Other_Port";
            this.tBox_Other_Port.Size = new System.Drawing.Size(106, 21);
            this.tBox_Other_Port.TabIndex = 4;
            // 
            // btn_My_Set
            // 
            this.btn_My_Set.Location = new System.Drawing.Point(446, 10);
            this.btn_My_Set.Name = "btn_My_Set";
            this.btn_My_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_My_Set.TabIndex = 2;
            this.btn_My_Set.Text = "설정";
            this.btn_My_Set.UseVisualStyleBackColor = true;
            this.btn_My_Set.Click += new System.EventHandler(this.btn_My_Set_Click);
            // 
            // btn_Other_Set
            // 
            this.btn_Other_Set.Location = new System.Drawing.Point(446, 37);
            this.btn_Other_Set.Name = "btn_Other_Set";
            this.btn_Other_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Other_Set.TabIndex = 5;
            this.btn_Other_Set.Text = "설정";
            this.btn_Other_Set.UseVisualStyleBackColor = true;
            this.btn_Other_Set.Click += new System.EventHandler(this.btn_Other_Set_Click);
            // 
            // tBox_Msg
            // 
            this.tBox_Msg.Location = new System.Drawing.Point(12, 381);
            this.tBox_Msg.Name = "tBox_Msg";
            this.tBox_Msg.Size = new System.Drawing.Size(428, 21);
            this.tBox_Msg.TabIndex = 6;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(446, 380);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "보내기";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // lBox_Msg
            // 
            this.lBox_Msg.FormattingEnabled = true;
            this.lBox_Msg.ItemHeight = 12;
            this.lBox_Msg.Location = new System.Drawing.Point(12, 66);
            this.lBox_Msg.Name = "lBox_Msg";
            this.lBox_Msg.Size = new System.Drawing.Size(509, 292);
            this.lBox_Msg.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 421);
            this.Controls.Add(this.lBox_Msg);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tBox_Msg);
            this.Controls.Add(this.btn_Other_Set);
            this.Controls.Add(this.btn_My_Set);
            this.Controls.Add(this.tBox_Other_Port);
            this.Controls.Add(this.tBox_Other_IP);
            this.Controls.Add(this.tBox_My_Port);
            this.Controls.Add(this.tBox_My_IP);
            this.Name = "Form1";
            this.Text = "P2P Messenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_My_IP;
        private System.Windows.Forms.TextBox tBox_My_Port;
        private System.Windows.Forms.TextBox tBox_Other_IP;
        private System.Windows.Forms.TextBox tBox_Other_Port;
        private System.Windows.Forms.Button btn_My_Set;
        private System.Windows.Forms.Button btn_Other_Set;
        private System.Windows.Forms.TextBox tBox_Msg;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.ListBox lBox_Msg;
    }
}

