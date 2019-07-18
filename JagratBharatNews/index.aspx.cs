using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JagratBharatNews
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setDateTime();
            loadScroller();
        }
        public void setDateTime()
        {
            txtDate.InnerText = DateTime.Now.Day.ToString();
            txtMonthYear.InnerText = getPostfix(txtDate.InnerText) + " " + DateTime.Now.Date.ToString("MMMM yyyy");
            txtEvent.InnerText = DateTime.Now.Date.ToString("dddd");
        }
        public string getPostfix(string num)
        {
            switch (num)
            {
                case "1":
                    return "st";
                case "2":
                    return "nd";
                case "3":
                    return "rd";
                default :
                    return "th";
            }
        }
        
        public void loadScroller()
        {
            para.InnerHtml = "Hello World Hello World Hello World Hello World Hello World Hello World!";
        }
    }
}