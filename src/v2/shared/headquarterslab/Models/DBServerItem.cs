using System;
namespace headquarterslab.Models
{

    /// <summary>
    /// class ServerItem
    /// </summary>
    public class DBServerItem
    {
        private int id;
        private string servername;
        private string description;
        private string schema;
        private string dbport;
        private string username;
        private string password;

        public int Id               { get => id; set => id = value; }
        public string Servername    { get => servername; set => servername = value; }
        public string Description   { get => description; set => description = value; }
        public string Schema        { get => schema; set => schema = value; }
        public string Dbport        { get => dbport; set => dbport = value; }
        public string Username      { get => username; set => username = value; }
        public string Password      { get => password; set => password = value; }

        /// <summary>
        /// 
        /// </summary>
        public DBServerItem()
        {   id = 0;
            servername = "";
            description = "";
            schema = "";
            dbport = "";
            username = "";
            password = "";
        }

    }
}
