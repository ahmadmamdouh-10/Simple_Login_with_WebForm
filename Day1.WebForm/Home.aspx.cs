using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1.WebForm
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsLoggedIn"] == null)
                Response.Redirect("Login.aspx");

                if (Request.QueryString["language"] != null)
                {
                    string Lang = Request.QueryString["language"].ToString();
                    string Name = Request.QueryString["Name"].ToString();

                    if (Lang.ToLower().Trim() == "arabic")
                    {
                        LblWelcome.Text = "مرحباً بك في موقعنا!";
                    }
                    else
                    {
                        LblWelcome.Text = $"Welcome to our Home Page! {Name}";
                    }
                    LblWelcome.ForeColor = Color.Green;

                LblVisitors.Text = Application["VisitorsCount"].ToString();


            }

            if (Page.PreviousPage != null)
                {
                    LblTimes.Text = ((Login)Page.PreviousPage).Counter.ToString();
                }




        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["IsLoggedIn"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}