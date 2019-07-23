using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Services;

namespace JagratBharatNewsAdmin
{
    public partial class Preview : System.Web.UI.Page
    {
        DataDataContext db = new DataDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var ID = Request.QueryString["ID"];
            if (!IsPostBack)
            {
                loadData(Convert.ToInt32(ID));
            }

        }

        private void loadData(int ID)
        {
            var post = db.Posts.Where(n => n.Id == ID).FirstOrDefault();
            var paragraphs = db.Paragraphs.Where(n => n.PostID == post.Id).ToList();
            if (post != null)
            {
                Page.Title = post.HeadLine;
                PostHeader.InnerText = post.HeadLine;
                category.InnerText = GlobalMethods.getCategoryName(post.Category);
                info.InnerText = post.NewsDate.Value.ToLongDateString();
                loadImageFromPath("GetImage.aspx?PostID=" + post.Id+"&Size=orginal");
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
                return "<iframe width='100%' height='450vh' src='https://www.youtube.com/embed/" + splitedVideopath[splitedVideopath.Length - 1]
                      + "' frameborder='0' allow='accelerometer; autoplay; encrypted - media;" +
                        " gyroscope; picture -in-picture' allowfullscreen></iframe>";

            }
            return "";
        }

        private void loadImageFromPath(string imagePath)
        {
            heading.Style.Add("background", "linear-gradient(rgba(0,0,0,.1),rgba(0,0,0,.6)),border-box,url(" + imagePath + "), no-repeat, center");
            heading.Style.Add(" background-size", "cover");
        }        
    }
}