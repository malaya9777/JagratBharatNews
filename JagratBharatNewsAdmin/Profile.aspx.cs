using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            var user = db.Users.Where(n => n.Reset_Request == true);
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
    }
}