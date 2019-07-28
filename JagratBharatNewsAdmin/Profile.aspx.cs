using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JagratBharatNewsAdmin
{
    public partial class Profile : System.Web.UI.Page
    {
        DataDataContext db = new DataDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadProfileInformation(Convert.ToInt32(Session["LoginID"]));
            loadGridview();
        }

        private void loadGridview()
        {
            var user = db.Users.Where(n => n.Reset_Request == true).Select(n => new { n.Id, n.Name, Role = n.Role == 1 ? "Admin" : "User" });
            grdUsers.DataSource = user;
            grdUsers.DataBind();
        }

        private void loadProfileInformation(int v)
        {
            var user = db.Users.Where(n => n.Id == v).SingleOrDefault();
            userName.InnerText = user.Name;
            role.InnerText = user.Role == 1 ? "Admin" : "User";
            email.InnerText = user.Email;
            mobile.InnerText = user.Mobile;
            createdOn.InnerText = Convert.ToDateTime(user.CreatedOn).ToString("dd-MMM-yyyy");
            createdBy.InnerText = GlobalMethods.getUserName(user.Id);

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

            user_p.InnerText = "UserName : "+ GlobalMethods.getUserName(Convert.ToInt32(Session["LoginID"]));
            mpe1.Show();
        }

        private void ResetPassword(int userID, string newPassword)
        {

            var hashedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(newPassword, "SHA1");
            var user = db.Users.Where(n => n.Id == userID).SingleOrDefault();
            if (user != null)
            {
                user_p.InnerText = user.Name;
                user.LastPassword = user.Password;
                user.Password = hashedPassword;
                db.SubmitChanges();
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "Success", "alert('Password Changed successfully');", true);
            }
            else
            {
                
            }


        }
        


        protected void btnChange_Click(object sender, EventArgs e)
        {
            var UserID = Convert.ToInt32(Session["LoginID"]);
            ResetPassword(UserID, txtNewPassword.Text);
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            mpe1.Hide();
        }
    }
}