using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using VTS.Models;

namespace VTS.DataAccess
{
    public static class CategoryDB
    {
        public static async Task<List<Category>> getAllCategories()
        {   
            DBContext db = new DBContext();
            
            db.Query = StoredProcedures.getAllCategories;
            var ds = await db.GetDataSet();
            var categories = ds.Tables[0].ConvertToList<Category>();

            return categories;
        }
    }
}
