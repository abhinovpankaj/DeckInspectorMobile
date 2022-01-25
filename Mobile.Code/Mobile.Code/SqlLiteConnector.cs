using Mobile.Code;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mobile.Code
{
    public class SqlLiteConnector : ISQLite
    {
        public SqlLiteConnector() { }
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = null;
            try
            {
                var dbase = "DeckInspectorsLocalDB.db";

                var dbpath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var path = Path.Combine(dbpath, dbase);
                connection = new SQLiteConnection(path);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString() );
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
            }
            return connection;
        }
    }
}
