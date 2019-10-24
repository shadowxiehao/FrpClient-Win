﻿using System;
using System.Windows.Forms;

namespace FrpClient_Win
{
    public partial class ServerConfigDlg : Form
    {
        public ServerConfigDlg()
        {
            InitializeComponent();
        }

        private void CancelConfig_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveServerConfig_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(FrpServerIp.Text + "\n" + FrpServerPort.Text + "\n" + FrpToken.Text);
            DB.Instance().cServerinfo.strIp = FrpServerIp.Text;
            DB.Instance().cServerinfo.nPort = Convert.ToInt32(FrpServerPort.Text);
            DB.Instance().cServerinfo.strToken = FrpToken.Text;

            DB.Instance().SaveConfig();
            Close();
        }

        private void OnConfigDlgLoad(object sender, EventArgs e)
        {
            //初始化显示
            FrpServerIp.Text = DB.Instance().cServerinfo.strIp;
            FrpServerPort.Text = DB.Instance().cServerinfo.nPort.ToString();
            FrpToken.Text = DB.Instance().cServerinfo.strToken;
        }
    }
}
