using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace JagratBharatNewsAdmin
{
    public partial class PostNews : System.Web.UI.Page
    {
        DataDataContext db = new DataDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCategories();
            }
        }
        private void loadCategories()
        {
            var categories = db.Categories.ToList();
            ddlCategory.DataSource = categories;
            ddlCategory.DataTextField = "Name";
            ddlCategory.DataValueField = "Id";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "0"));
            
        }
        protected void btnPreview_Click(object sender, EventArgs e)
        {
            var post = new Post();
            post.HeadLine = txtHeadline.Text;
            post.Category = Convert.ToInt32(ddlCategory.SelectedValue);
            post.NewsDate = Convert.ToDateTime(txtNewsDate.Text);
            post.PostedOn = DateTime.Now;
            post.PostedBy = Convert.ToInt32(Session["LoginId"]);
            post.Image = fImage.FileBytes;
            
            string imageName = string.Format("{0:ddMMyyyyHHmmssFFF}", DateTime.Now);
            //Upload Image
            string imagePath = uploadImage(fImage, imageName);

            post.VideoPath = videoEmbed.Text;            
            post.ImagePath = imagePath;
            post.Submitted = false;
            db.Posts.InsertOnSubmit(post);
            db.SubmitChanges();
            var postID = db.Posts.OrderByDescending(n => n.Id).Select(n => n.Id).OrderByDescending(n => n).FirstOrDefault();
            
            //Upload splited paragraph
            uploadParagraphs(splitText(txtBody.Text), postID);

            ClientScript.RegisterClientScriptBlock(Page.GetType(), "loadBlank", "window.open('Preview.aspx?ID=" + postID + "','_blank','location=yes,width=1000, height=800,scrollbars=yes,status=yes')", true);

        }

        private string uploadImage(FileUpload imageUploader, string previewID)
        {
            string imagePath = "";
           
            if (imageUploader.HasFile)
            {
                
                
                var name = imageUploader.FileName.Split('.');
                var fileType = name[name.Length - 1];
                var fileName = previewID;
                if (fileType.ToLower() == "jpg" || fileType.ToLower() == "jpeg")
                {           
                   
                    imagePath = "~/images/temp/" + fileName + "." + fileType.ToLower();
                    imageUploader.SaveAs(Server.MapPath(imagePath));

                }
                return imagePath;
            }
            return "";
        }

        private void uploadParagraphs(string[] msgs, int postID)
        {
            foreach (var msg in msgs)
            {
                if (msg != string.Empty)
                {
                    Paragraph p = new Paragraph();
                    p.PostID = postID;
                    p.Paragraphs = msg;
                    db.Paragraphs.InsertOnSubmit(p);
                    db.SubmitChanges();
                }
            }
        }

        public string[] splitText(string body)
        {
            var newText = body.Replace("\n", "`");
            return newText.Split('`');
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}