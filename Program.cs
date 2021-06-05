using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
namespace HostFileEditor
{
    static class Program
    {
        private static string HostFile { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HostFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void AdminRelauncher()
        {
            if (!IsRunAsAdmin())
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Assembly.GetEntryAssembly().CodeBase;

                proc.Verb = "runas";

                try
                {
                    Process.Start(proc);
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("This program must be run as an administrator! \n\n" + ex.ToString());
                }
            }
        }

        private static bool IsRunAsAdmin()
        {
            try
            {
                WindowsIdentity id = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(id);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void BackupHostFile()
        {
            string destination =  HostFile + "_backup-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            File.Copy(HostFile, destination);
        }

        public static bool ModifyHostsFile(string entry)
        {
            try
            {
                BackupHostFile();
                using (StreamWriter w = File.AppendText(HostFile))
                {

                    w.WriteLine(entry);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static String[] ReadHostFile()
        {
           
            return File.ReadAllLines(HostFile);
           
        }

        public static bool RemoveHost(string selectedText)
        {
            string[] text = File.ReadAllLines(HostFile);
            bool success = false;
            for (int i = 0; i < text.Count(); i++)
            {
                if (text[i] == selectedText)
                {
                    text[i] = null;
                    success = true;
                }
            }
            if (success)
            {
                BackupHostFile();
                File.WriteAllLines(HostFile, text);
            }

            return success;
           
        }

    }
}
