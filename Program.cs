using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string userName, password;
            FormLogin loginForm = new FormLogin();


            // Hiển thị form đăng nhập dưới dạng modal
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                userName = loginForm.userName;
                password = loginForm.password;

                // Nếu đăng nhập thành công thì mở MainForm
                loginForm.Close();
                Application.Run(new SumaryWindow());
                
            }

            else
            {
                Application.Exit();
            }
        }
    }
}
