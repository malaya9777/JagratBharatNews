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
            if (!IsPostBack)
            {
                setDateTime();
                using(dbDataContext db = new dbDataContext())
                {
                    var categories = db.Categories.ToList();
                    var posts = db.Posts.ToList();

                    loadScroller(posts);
                    loadCategory(categories);
                    loadCards(posts);
                    loadRecentVideo(posts);
                }
               
            }

        }

        private void loadRecentVideo(List<Post> posts)
        {
            var latestVieo = posts.OrderByDescending(n => n.Id).Select(n=>n.VideoPath).FirstOrDefault();
            string[] splitedVideopath = latestVieo.Split('/');
            videoFrame.InnerHtml= "<iframe width='100%' height='140px' src='https://www.youtube.com/embed/" + splitedVideopath[splitedVideopath.Length - 1]
                      + "' frameborder='0' allow='accelerometer; autoplay; encrypted - media;" +
                        " gyroscope; picture -in-picture' allowfullscreen></iframe>";
        }

        private void loadCards(List<Post> posts)
        {
            var cardsInfo = posts.OrderByDescending(n=>n.Id).Take(6);
            string infoString = "";
            foreach(var c in cardsInfo)
            {
                infoString += "<div class='card'><span class='catSpan'>" + globalMethods.getCategoryName(c.Category) + "</span><img src='getImage.ashx?PostID=" + c.Id + "&Size=thumbnail' alt='" +
                    c.HeadLine + "'><div class='cardHeadline'>" + c.HeadLine + " <a href='News.aspx?PostID=" + c.Id + "' target='_blank' style='font-size:10px'>Read more..</a></div></div>";
            }
            cards.InnerHtml = infoString;
        }

        private void loadCategory(List<Category> categories)
        {

            string listElement = "";
            foreach (var i in categories)
            {
                listElement += "<li><a href='CategoryWiseNews.aspx?categoryID=" + i.Id + "'>" + i.Name + " </a></li>";
            }
            categoryList.InnerHtml = listElement;

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
                default:
                    return "th";
            }
        }

        public void loadScroller(List<Post> posts)
        {

            string scrollerText = "";
            foreach (var i in posts.Where(n => n.SelectedScroller == true))
            {
                scrollerText += "<a href='News.aspx?PostID=" + i.Id + "' target='_blank'>" + i.HeadLine + "</a> || ";
            }
            para.InnerHtml = scrollerText;

        }
    }
}