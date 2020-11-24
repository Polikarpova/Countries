using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Countries.Iterfaces;
using Countries.Logic;
using Countries.Model;
using Countries.Model.Connectors;

namespace Countries
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Work with MySQL
            //Connector connector = new MySQLConnector();

            //Work with MSSQL
            Connector connector = new MSSQLConnector();

            string errorMessage = "";
            IDatabase db = null;

            try
            {
                db = new Database(connector, out errorMessage);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please edit config and reconnect to database!", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ILogic manager = new LogicManager(db);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(manager));
        }
    }
}
