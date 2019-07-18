using System;
using System.Web.Security;

namespace JagratBharatNewsAdmin
{
    public partial class Signout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session.Abandon();
            Session.Clear();
            FormsAuthentication.SignOut();
            Response.Redirect("login.aspx", false);

        }
    }
}