using System;
using System.Windows.Forms;
using System.IO;
using EZLabeling_1.ClassFIle;

namespace EZLabeling_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region 전역변수
        // 전역변수
        string m_filePath;
        #endregion


        private void FormMain_Load(object sender, EventArgs e)
        {
            btn_Load.Select();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "All Files (*.*)|*.*";
            OFD.Multiselect = true;
            bool b_filePath = true;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < OFD.FileNames.Length; i++)
                {
                    if (b_filePath == true) { m_filePath = CSplit.FilenameSplit(OFD.FileNames[i], false); b_filePath = false; }
                    lb_Picture.Items.Add(CSplit.FilenameSplit(OFD.FileNames[i]));
                    Console.WriteLine(CSplit.FilenameSplit(OFD.FileNames[i]));
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(m_filePath);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        public void btn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                //btn_Color.BackColor = cd.Color;
            }
        }
    }
}
