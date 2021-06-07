namespace EZLabeling_1
{
    partial class FormMain
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
            this.p_Main = new System.Windows.Forms.Panel();
            this.p_Top = new System.Windows.Forms.Panel();
            this.p_ScreenC = new System.Windows.Forms.Panel();
            this.p_ButtonM = new System.Windows.Forms.Panel();
            this.p_LabelM = new System.Windows.Forms.Panel();
            this.p_ScreenB = new System.Windows.Forms.Panel();
            this.pb_Main = new System.Windows.Forms.PictureBox();
            this.lb_Picture = new System.Windows.Forms.ListBox();
            this.gb_List = new System.Windows.Forms.GroupBox();
            this.gb_Button = new System.Windows.Forms.GroupBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Key = new System.Windows.Forms.Button();
            this.btn_Seg = new System.Windows.Forms.Button();
            this.btn_Boun = new System.Windows.Forms.Button();
            this.btn_Color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.p_Main.SuspendLayout();
            this.p_Top.SuspendLayout();
            this.p_ScreenC.SuspendLayout();
            this.p_ButtonM.SuspendLayout();
            this.p_LabelM.SuspendLayout();
            this.p_ScreenB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
            this.gb_List.SuspendLayout();
            this.gb_Button.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Main
            // 
            this.p_Main.Controls.Add(this.p_ButtonM);
            this.p_Main.Controls.Add(this.p_LabelM);
            this.p_Main.Controls.Add(this.p_ScreenC);
            this.p_Main.Controls.Add(this.p_Top);
            this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Main.Location = new System.Drawing.Point(0, 0);
            this.p_Main.Name = "p_Main";
            this.p_Main.Size = new System.Drawing.Size(1284, 561);
            this.p_Main.TabIndex = 1;
            // 
            // p_Top
            // 
            this.p_Top.Controls.Add(this.panel1);
            this.p_Top.Controls.Add(this.panel2);
            this.p_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Top.Location = new System.Drawing.Point(0, 0);
            this.p_Top.Name = "p_Top";
            this.p_Top.Size = new System.Drawing.Size(1284, 40);
            this.p_Top.TabIndex = 4;
            // 
            // p_ScreenC
            // 
            this.p_ScreenC.Controls.Add(this.pb_Main);
            this.p_ScreenC.Controls.Add(this.p_ScreenB);
            this.p_ScreenC.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_ScreenC.Location = new System.Drawing.Point(0, 40);
            this.p_ScreenC.Name = "p_ScreenC";
            this.p_ScreenC.Size = new System.Drawing.Size(884, 521);
            this.p_ScreenC.TabIndex = 5;
            // 
            // p_ButtonM
            // 
            this.p_ButtonM.Controls.Add(this.gb_Button);
            this.p_ButtonM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_ButtonM.Location = new System.Drawing.Point(884, 40);
            this.p_ButtonM.Name = "p_ButtonM";
            this.p_ButtonM.Size = new System.Drawing.Size(200, 521);
            this.p_ButtonM.TabIndex = 6;
            // 
            // p_LabelM
            // 
            this.p_LabelM.Controls.Add(this.gb_List);
            this.p_LabelM.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_LabelM.Location = new System.Drawing.Point(1084, 40);
            this.p_LabelM.Name = "p_LabelM";
            this.p_LabelM.Size = new System.Drawing.Size(200, 521);
            this.p_LabelM.TabIndex = 6;
            // 
            // p_ScreenB
            // 
            this.p_ScreenB.Controls.Add(this.btn_Save);
            this.p_ScreenB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_ScreenB.Location = new System.Drawing.Point(0, 481);
            this.p_ScreenB.Name = "p_ScreenB";
            this.p_ScreenB.Size = new System.Drawing.Size(884, 40);
            this.p_ScreenB.TabIndex = 0;
            // 
            // pb_Main
            // 
            this.pb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Main.Location = new System.Drawing.Point(0, 0);
            this.pb_Main.Name = "pb_Main";
            this.pb_Main.Size = new System.Drawing.Size(884, 481);
            this.pb_Main.TabIndex = 1;
            this.pb_Main.TabStop = false;
            // 
            // lb_Picture
            // 
            this.lb_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Picture.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Picture.FormattingEnabled = true;
            this.lb_Picture.ItemHeight = 12;
            this.lb_Picture.Location = new System.Drawing.Point(3, 17);
            this.lb_Picture.Name = "lb_Picture";
            this.lb_Picture.Size = new System.Drawing.Size(194, 501);
            this.lb_Picture.TabIndex = 2;
            // 
            // gb_List
            // 
            this.gb_List.Controls.Add(this.lb_Picture);
            this.gb_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_List.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_List.Location = new System.Drawing.Point(0, 0);
            this.gb_List.Name = "gb_List";
            this.gb_List.Size = new System.Drawing.Size(200, 521);
            this.gb_List.TabIndex = 3;
            this.gb_List.TabStop = false;
            this.gb_List.Text = "List";
            // 
            // gb_Button
            // 
            this.gb_Button.Controls.Add(this.btn_Color);
            this.gb_Button.Controls.Add(this.btn_Boun);
            this.gb_Button.Controls.Add(this.btn_Seg);
            this.gb_Button.Controls.Add(this.btn_Key);
            this.gb_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_Button.Location = new System.Drawing.Point(0, 0);
            this.gb_Button.Name = "gb_Button";
            this.gb_Button.Size = new System.Drawing.Size(200, 521);
            this.gb_Button.TabIndex = 4;
            this.gb_Button.TabStop = false;
            this.gb_Button.Text = "Button";
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Load.Location = new System.Drawing.Point(19, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(100, 30);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "불러오기";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Save.Location = new System.Drawing.Point(774, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 30);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "저장하기";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Key
            // 
            this.btn_Key.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key.Location = new System.Drawing.Point(25, 33);
            this.btn_Key.Name = "btn_Key";
            this.btn_Key.Size = new System.Drawing.Size(150, 70);
            this.btn_Key.TabIndex = 2;
            this.btn_Key.Text = "Key Point";
            this.btn_Key.UseVisualStyleBackColor = true;
            // 
            // btn_Seg
            // 
            this.btn_Seg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Seg.Location = new System.Drawing.Point(25, 133);
            this.btn_Seg.Name = "btn_Seg";
            this.btn_Seg.Size = new System.Drawing.Size(150, 70);
            this.btn_Seg.TabIndex = 3;
            this.btn_Seg.Text = "Bounding Box";
            this.btn_Seg.UseVisualStyleBackColor = true;
            // 
            // btn_Boun
            // 
            this.btn_Boun.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Boun.Location = new System.Drawing.Point(25, 233);
            this.btn_Boun.Name = "btn_Boun";
            this.btn_Boun.Size = new System.Drawing.Size(150, 70);
            this.btn_Boun.TabIndex = 4;
            this.btn_Boun.Text = "Segmentation";
            this.btn_Boun.UseVisualStyleBackColor = true;
            // 
            // btn_Color
            // 
            this.btn_Color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Color.Location = new System.Drawing.Point(25, 439);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(150, 70);
            this.btn_Color.TabIndex = 5;
            this.btn_Color.Text = "Color";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.btn_Load);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(884, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 40);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_FileName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 40);
            this.panel1.TabIndex = 4;
            // 
            // tb_FileName
            // 
            this.tb_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_FileName.Location = new System.Drawing.Point(0, 0);
            this.tb_FileName.Multiline = true;
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.ReadOnly = true;
            this.tb_FileName.Size = new System.Drawing.Size(884, 40);
            this.tb_FileName.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Close.Location = new System.Drawing.Point(285, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 30);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "끝내기";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.p_Main);
            this.Name = "FormMain";
            this.Text = "EZLabeling";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.p_Main.ResumeLayout(false);
            this.p_Top.ResumeLayout(false);
            this.p_ScreenC.ResumeLayout(false);
            this.p_ButtonM.ResumeLayout(false);
            this.p_LabelM.ResumeLayout(false);
            this.p_ScreenB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
            this.gb_List.ResumeLayout(false);
            this.gb_Button.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_Main;
        private System.Windows.Forms.Panel p_Top;
        private System.Windows.Forms.Panel p_ButtonM;
        private System.Windows.Forms.Panel p_LabelM;
        private System.Windows.Forms.Panel p_ScreenC;
        private System.Windows.Forms.Panel p_ScreenB;
        private System.Windows.Forms.PictureBox pb_Main;
        private System.Windows.Forms.GroupBox gb_Button;
        private System.Windows.Forms.GroupBox gb_List;
        private System.Windows.Forms.ListBox lb_Picture;
        private System.Windows.Forms.Button btn_Key;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.Button btn_Boun;
        private System.Windows.Forms.Button btn_Seg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.Button btn_Close;
    }
}

