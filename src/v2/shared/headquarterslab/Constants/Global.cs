using System;
using System.IO;



namespace headquarterslab.Constants
{

    /// <summary>
    /// class Global
    /// </summary>
    public static class Global
    {
        public const string DatabaseFilename = "pghq.db3";


        // open the database in read/write mode
        // create the database if it doesn't exist
        // enable multi-threaded database access
        public const SQLite.SQLiteOpenFlags DatabaseFlags = SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.Create | SQLite.SQLiteOpenFlags.SharedCache;


        /// <summary>
        /// DatabasePath
        /// </summary>
        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

    }
}
