using System;
using System.Collections.Generic;
using System.Text;

namespace VTS.DataAccess
{
    public static class StoredProcedures
    {
        public static string getAllCategories = "SELECT CategoryID, CategoryName FROM public.\"MasterData.Categories\"";
    }
}
