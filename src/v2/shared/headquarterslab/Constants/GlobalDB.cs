using System;
using headquarterslab.Models;


namespace headquarterslab.Constants
{
    

    /// <summary>
    /// 
    /// </summary>
    public static class GlobalDB
    {
        private static PGHQDatabase database;

        /// <summary>
        /// PGHQDatabase Database
        /// </summary>
        public static PGHQDatabase Database
        {
            get
            {
                if (database == null)
                    database = new PGHQDatabase();
                
                return database;
            }
        }

    }
}
