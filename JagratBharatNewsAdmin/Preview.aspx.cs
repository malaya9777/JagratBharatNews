using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JagratBharatNewsAdmin
{
    public partial class Preview : System.Web.UI.Page
    {
        DataDataContext db = new DataDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var PreviewID = Request.QueryString["PreviewID"];
            if (!IsPostBack)
            {
                loadData(PreviewID);
            }
        }

        private void loadData(string PreviewID)
        {
            var post = db.TempPosts.Where(n => n.PreviewID == PreviewID).FirstOrDefault();
            var paragraphs = db.Paragraphs.Where(n => n.PostID == post.Id).ToList();
            if (post != null)
            {
                Page.Title = post.HeadLine;
                PostHeader.InnerText = post.HeadLine;
                category.InnerText = GlobalMethods.getCategoryName(post.Category);
                info.InnerText = post.NewsDate.Value.ToLongDateString();

                loadImage(post.ImagePath);
                loadParagraph(paragraphs, loadVideo(post.VideoPath));
            }
        }

        private void loadParagraph(List<Paragraph> paragraphs, string videoFrame)
        {
            foreach (var paragraph in paragraphs)
            {
                PostContent.InnerHtml += "<p class='justified'>" + paragraph.Paragraphs + "</p>";
                if (paragraphs[1] == paragraph)
                {
                    PostContent.InnerHtml += videoFrame;
                }

            }
        }

        private string loadVideo(string videoPath)
        {
            if (videoPath != "")
            {
                string[] splitedVideopath = videoPath.Split('/');
                return  "<iframe width='100%' height='315' src='https://www.youtube.com/embed/"+ splitedVideopath[splitedVideopath.Length - 1]
                      + "' frameborder='0' allow='accelerometer; autoplay; encrypted - media;" +
                        " gyroscope; picture -in-picture' allowfullscreen></iframe>";
               
            }
            return "";
        }

        private void loadImage(string imagePath)
        {
            string _imagePath = "";
            if (imagePath != "")
            {
                _imagePath = imagePath.Remove(0, 1);
            }
            else
            {
                _imagePath = "/images/default/1.jpg";
            }
                heading.Style.Add("background", "linear-gradient(rgba(0,0,0,.1),rgba(0,0,0,.6)),border-box,url(" + _imagePath + "), no-repeat, center");
                heading.Style.Add(" background-size", "cover");
        }
    }
}