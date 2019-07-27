using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace JagratBharatNewsAdmin
{
    public class GlobalMethods
    {

        public static int getUserID(string UserName)
        {
            using (DataDataContext db = new DataDataContext())
            {
                var user = db.Users.Where(n => n.Name == UserName).FirstOrDefault();
                if (user != null)
                {
                    return user.Id;
                }
                else
                {
                    return 0;
                }
            }
        }
        public static string Truncate(string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
        public static Image BinaryToImage(byte[] imageBytes)
        {
            if (imageBytes == null)
            {
                return null;
            }

            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            return Image.FromStream(ms);

        }

        public static int? getUserRole(int? UserID)
        {
            using (DataDataContext db = new DataDataContext())
            {
                var user = db.Users.Where(n => n.Id == UserID).FirstOrDefault();
                if (user != null)
                {
                    return user.Role;
                }
                else
                {
                    return null;
                }
            }
        }

        public static string getUserName(int? UserID)
        {
            using (DataDataContext db = new DataDataContext())
            {
                var user = db.Users.Where(n => n.Id == UserID).FirstOrDefault();
                if (user != null)
                {
                    return user.Name;
                }
                else
                {
                    return "default";
                }
            }
        }
        public static bool checkUserExists(string UserName)
        {
            using (DataDataContext db = new DataDataContext())
            {
                var user = db.Users.Where(n => n.Name == UserName).SingleOrDefault();
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string getCategoryName(int? categoryID)
        {
            using(DataDataContext db = new DataDataContext())
            {
                var category = db.Categories.Where(n => n.Id == categoryID).SingleOrDefault();
                if(category != null)
                {
                    return category.Name;
                }
                else
                {
                    return "Not Found";
                }
            }
        }

    }
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message)
        {
        }
    }
}