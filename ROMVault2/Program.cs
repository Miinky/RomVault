/******************************************************
 *     ROMVault2 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2014                                 *
 ******************************************************/

using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ROMVault2
{
    internal static class Program
    {
        public const string Version = "2.6";
        public const int SubVersion = 3;
        public static readonly Encoding Enc = Encoding.GetEncoding(28591);

        public static SynchronizationContext SyncCont;

        public static Settings rvSettings;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            rvSettings = new Settings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if !DEBUG
            Application.ThreadException += ReportError.UnhandledExceptionHandler;
#endif

            FrmSplashScreen progress = new FrmSplashScreen();
            progress.ShowDialog();

            progress.Dispose();

            Application.Run(new FrmMain());
        }
    }
}