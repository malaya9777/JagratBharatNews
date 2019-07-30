using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public static string EncodeID(int ID)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(ID.ToString()));
        }
        public static int DecodeID(string EncodedID)
        {
            return Convert.ToInt32(Encoding.UTF8.GetString(Convert.FromBase64String(EncodedID)));
        }
    }
}