using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JagratBharatNews
{
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string serachTerm = Request.QueryString["search"];
                FindResult(serachTerm);
            }
        }
        private void FindResult(string searchTerm)
        {
            var posts = new List<Post>();
            using (dbDataContext db = new dbDataContext())
            {
                var splitedSearch = searchTerm.Split(' ');
                foreach(var s in splitedSearch)
                {
                    posts.AddRange(db.Posts.Where(n => n.HeadLine.Contains(s)).ToList()); 
                }
                loadResults(posts);
            }
        }

        private void loadResults(List<Post> posts)
        {
            string empty = "";
            foreach(var s in posts)
            {
                empty += "<div class='result'><img src = 'getImage.ashx?PostID=" + s.Id + "&Size=thumbnail' alt ='" + s.HeadLine + "' /><h5>" + s.HeadLine + "</ h5 >" +
                    "<a href=News.aspx?ID=" + globalMethods.EncodeID(s.Id) + "> Read more...</a ></div>";
            }
            results.InnerHtml = empty;
        }
    }
}