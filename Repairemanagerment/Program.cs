using System;
using System.Windows.Forms;

namespace Repairemanagerment
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fm_login f = new fm_login();
            f.ShowDialog();
            if (f.r == DialogResult.OK)
            {
                Application.Run(new fm_main());
            }
        }
    }
}
