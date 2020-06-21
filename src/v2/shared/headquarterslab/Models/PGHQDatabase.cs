using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using headquarterslab.Constants;
using SQLite;

namespace headquarterslab.Models
{
    /// <summary>
    /// class PGHQDatabase
    /// </summary>
    public class PGHQDatabase
    {
        /// <summary>
        /// 
        /// </summary>
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Global.DatabasePath, Global.DatabaseFlags );
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;


        /// <summary>
        /// PGHQDatabase
        /// </summary>
        public PGHQDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(DBServerItem).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(DBServerItem)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }


        /// <summary>
        /// GetDBServersItemsAsync
        /// </summary>
        /// <returns></returns>
        public Task<List<DBServerItem>> GetDBServersItemsAsync()
        {
            return Database.Table<DBServerItem>().ToListAsync();
        }


        /// <summary>
        /// GetItemAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<DBServerItem> GetItemAsync(int id)
        {
            return Database.Table<DBServerItem>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Task<int> SaveItemAsync(DBServerItem item)
        {
            if (item.Id != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Task<int> DeleteItemAsync(DBServerItem item)
        {
            return Database.DeleteAsync(item);
        }



    }
}
