using System;
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
            var tempPost = new TempPost();
            tempPost.HeadLine = txtHeadline.Text;

            tempPost.Category = Convert.ToInt32(ddlCategory.SelectedValue);
            tempPost.NewsDate = Convert.ToDateTime(txtNewsDate.Text);
            tempPost.PostedOn = DateTime.Now;
            tempPost.PostedBy = Convert.ToInt32(Session["LoginId"]);
            string imagePath = "";
            string previewID = string.Format("{0:ddMMyyyyHHmmssFFF}", DateTime.Now);
            //Upload Image
            uploadImage(fImage, previewID);

            tempPost.VideoPath = videoEmbed.Text;
            tempPost.PreviewID = previewID;
            tempPost.ImagePath = imagePath;
            db.TempPosts.InsertOnSubmit(tempPost);
            db.SubmitChanges();
            var postID = db.TempPosts.OrderByDescending(n => n.Id).Select(n => n.Id).OrderByDescending(n => n).FirstOrDefault();
            
            //Upload splited paragraph
            uploadParagraphs(splitText(txtBody.Text), postID);

            ClientScript.RegisterClientScriptBlock(Page.GetType(), "loadBlank", "window.open('Preview.aspx?PreviewID=" + previewID + "','_blank','location=yes,width=1000, height=800,scrollbars=yes,status=yes')", true);
            Session["PreviewID"] = previewID;
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
            Session.Remove("PreviewID");
        }
    }
}