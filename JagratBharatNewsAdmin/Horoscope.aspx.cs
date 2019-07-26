using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace JagratBharatNewsAdmin
{
    public partial class Horoscope : System.Web.UI.Page
    {
        DataDataContext db = new DataDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadInitialValues();
            }
        }

        // Load initial values
        private void loadInitialValues()
        {
            txtDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            loadDropdownLists();
            loadGridView(Convert.ToDateTime(ddlDate.SelectedValue));
        }

        private void loadGridView(DateTime dateTime)
        {
            var horoscope = db.Horoscopes.Where(n => n.Date == dateTime).Select(n => new
            {
                n.Id,
                zodiac = (db.Zodiacs.Where(m => m.Id == n.Zodiac_ID).Select(m => m.Zodiac_English + "(" + m.Zodiac_Odia + ")")).SingleOrDefault(),
                n.Horoscope_English,

            });
            grdHoroscope.DataSource = horoscope;
            grdHoroscope.DataBind();
        }

        // Load all Dropdowns
        private void loadDropdownLists()
        {
            loadZodiac();
            loadDates();


        }

        // Load dates to the date dropdown
        private void loadDates()
        {
            int m = 0;
            for (double i = 0; i > -7; i--)
            {
                ddlDate.Items.Insert(m, DateTime.Now.AddDays(i).ToString("dd-MMM-yyyy"));
                m++;
            }
        }
        // Load data to Zodiac dropdown
        private void loadZodiac()
        {
            var zodiacs = db.Zodiacs.Select(n => new
            {
                dataValue = n.Id,
                dataText = n.Zodiac_English + "(" + n.Zodiac_Odia + ")"
            }).ToList();
            ddlZodiac.DataTextField = "dataText";
            ddlZodiac.DataValueField = "dataValue";
            ddlZodiac.DataSource = zodiacs;
            ddlZodiac.DataBind();
            ddlZodiac.Items.Insert(0, new ListItem("Select Zodiac", "0"));
        }

        protected void ddlDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGridView(Convert.ToDateTime(ddlDate.SelectedValue));
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Horoscope horoscope = new Horoscope();
            horoscope.Zodiac_ID = Convert.ToInt32(ddlZodiac.SelectedValue);
            horoscope.Date = Convert.ToDateTime(txtDate.Text);
            horoscope.Horoscope_English = txtHoroscope.Text;
            db.Horoscopes.InsertOnSubmit(horoscope);
            db.SubmitChanges();
            Response.Redirect(Request.RawUrl);

        }
    }
}