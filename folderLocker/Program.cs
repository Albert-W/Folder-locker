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
      //查看数据库是否存在
      string startupPath = Application.StartupPath;

      string file = startupPath + @"\SQLFolder.db";

      if (File.Exists(file) != true)
      {
        DBUtility.DbHelperSQLite.createDd(file);
        string sql = @"
        CREATE TABLE IF NOT EXISTS FolderInfo (
        folderName TEXT NOT NULL,
        folderpwd TEXT NOT NULL
        ); ";
        DBUtility.DbHelperSQLite.CreateTable(sql);
      }



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
