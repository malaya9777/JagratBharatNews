using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JagratBharatNews
{
    public class globalMethods
    {
        public static string getCategoryName(int? categoryID)
        {
            using(dbDataContext db = new dbDataContext())
            {
                return db.Categories.Where(n => n.Id == categoryID).Select(n=>n.Name).SingleOrDefault();
            }
        }
    }
}