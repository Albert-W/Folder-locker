using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace folderLocker
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            string startupPath = Application.StartupPath;

            string file = startupPath + @"\SQLFolder.db";

            // Creat the DB and table if not exist
            DBUtility.DbHelperSQLite.createDd(file);
            string sql = @"
        CREATE TABLE IF NOT EXISTS FolderInfo (
        folderName TEXT NOT NULL,
        folderpwd TEXT NOT NULL
        ); ";
            DBUtility.DbHelperSQLite.CreateTable(sql);





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mainform m = new Mainform();
            if (args.Length > 0)
            {
                m.initPath = args[0];
            }

            Application.Run(m);
        }
    }
}
