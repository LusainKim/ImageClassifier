using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace csMain
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { Application.Run(new Form1()); }
            catch (System.ObjectDisposedException exnocatch) { }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().ToString()); }
        }
    }
}
