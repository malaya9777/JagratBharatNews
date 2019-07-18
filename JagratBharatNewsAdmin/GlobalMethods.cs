﻿using System;
using System.Collections.Generic;
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