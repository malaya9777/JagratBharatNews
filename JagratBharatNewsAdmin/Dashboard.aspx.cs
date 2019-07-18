using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace JagratBharatNewsAdmin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        DataDataContext db = new DataDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCategoryGrid();

            }
        }

        private void loadCategoryGrid()
        {
            var categories = db.Categories.Select(n => new { n.Id, n.Name }).ToList();
            if (categories.Count > 0)
            {
                grdCategories.DataSource = categories;
            }
            else
            {
                var emptyCategory = new List<dynamic> { new { Id = 0, Name = "" } };
                grdCategories.DataSource = emptyCategory;
            }
            grdCategories.DataBind();
        }       

        protected void grdCategories_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdCategories.EditIndex = e.NewEditIndex;
            loadCategoryGrid();
        }

        protected void grdCategories_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = grdCategories.Rows[e.RowIndex];

            int Id = Convert.ToInt32((row.Cells[1].Text));
            string Name = ((TextBox)row.Cells[2].Controls[0]).Text;
            var category = db.Categories.Where(n => n.Id == Id).SingleOrDefault();
            category.Name = Name;
            db.SubmitChanges();
            grdCategories.EditIndex = -1;
            loadCategoryGrid();

        }

        protected void grdCategories_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdCategories.EditIndex = -1;
            loadCategoryGrid();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.Name = txtCategory.Text;
            db.Categories.InsertOnSubmit(category);
            db.SubmitChanges();
            loadCategoryGrid();
        }
    }
}