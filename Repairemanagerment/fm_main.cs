using Repairemanagerment.Query;
using Repairemanagerment.State;
using System;
using System.Windows.Forms;

namespace Repairemanagerment
{
    public partial class fm_main : Form
    {
        public fm_main()
        {
            InitializeComponent();
        }
        private void tsmi_use_Click(object sender, EventArgs e)
        {
            //打开仪器运行维护界面
            fm_Use frm = new fm_Use();
            frm.Show();
        }
        private void tsmi_Repaire_Click(object sender, EventArgs e)
        {
            //打开仪器维修维护界面
            fm_Repair frm = new fm_Repair();
            frm.Show();
        }
        private void tsim_Repaireinfo_Click(object sender, EventArgs e)
        {
            //打开仪器信息维护界面
            fm_Repairinfo frm = new fm_Repairinfo();
            frm.Show();
        }
        private void tsim_Parts_Click(object sender, EventArgs e)
        {
            //打开仪器部件维护界面
            fm_Parts frm = new fm_Parts();
            frm.Show();
        }
        private void tsim_Spare_Click(object sender, EventArgs e)
        {
            //打开备件信息维护界面
            fm_Spare frm = new fm_Spare();
            frm.Show();
        }
        private void tsim_Belong_Click(object sender, EventArgs e)
        {
            //打开仪器归属维护界面
            fm_Belong frm = new fm_Belong();
            frm.Show();
        }
        private void tsim_Srepaire_Click(object sender, EventArgs e)
        {
            //打开维修状态界面
            fm_Srepair frm = new fm_Srepair();
            frm.Show();
        }
        private void tsim_Stooling_Click(object sender, EventArgs e)
        {
            //打开仪器状态界面
            fm_Stooling frm = new fm_Stooling();
            frm.Show();
        }
        private void tsim_Quse_Click(object sender, EventArgs e)
        {
            //打开仪器运行查询界面
            fm_Quse frm = new fm_Quse();
            frm.Show();
        }
        private void tsim_Qrepair_Click(object sender, EventArgs e)
        {
            //打开仪器维修查询界面
            fm_Qrepair frm = new fm_Qrepair();
            frm.Show();
        }
        private void tsim_Qrepairinfo_Click(object sender, EventArgs e)
        {
            //打开维修信息查询界面
            fm_Qrepairinfo frm = new fm_Qrepairinfo();
            frm.Show();
        }
        private void tsim_Qparts_Click(object sender, EventArgs e)
        {
            //打开仪器部件查询界面
            fm_Qparts frm = new fm_Qparts();
            frm.Show();
        }
        private void tsim_Qspare_Click(object sender, EventArgs e)
        {
            //打开备件信息查询界面
            fm_Qspare frm = new fm_Qspare();
            frm.Show();
        }
        private void tsim_Print_Click(object sender, EventArgs e)
        {
            //打开进度显示界面
            fm_Print frm = new fm_Print();
            frm.Show();
        }
        private void btn_Domestic_Click(object sender, EventArgs e)
        {
            //刷新列表读取并填入国产仪器归属信息
            dgv_Location.Rows.Clear();

        }
    }
}