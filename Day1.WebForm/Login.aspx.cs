using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1.WebForm
{
    public partial class Login : System.Web.UI.Page
    {
        public int Counter = 0;
        protected void Page_PreInit(object sender, EventArgs e)
        {

        }
        protected void Page_Init(object sender, EventArgs e)
        {

        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {

        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false) 
            {
                DDLLanguages.Items.Add("Arabic");
                DDLLanguages.Items.Add("English");
                ViewState["Count"] = Counter;
                if(Request.Cookies["CookieRM"] != null)
                {
                    txtUName.Text = Request.Cookies["CookieRM"].Values["UserName"].ToString();
                }
            }
            Counter = int.Parse(ViewState["Count"].ToString());
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {

        }

        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
        }

        protected void check_Login(object sender, EventArgs e)
        {
            if(Page.IsValid == true)
            {
                if (int.Parse(ViewState["Count"].ToString()) <= 5)
                {

                    string userName = txtUName.Text;
                    string uPassword = txtUPassword.Text;

                    if (string.IsNullOrEmpty(userName)
                        || string.IsNullOrEmpty(uPassword))
                    {
                        LblMessage.Text = "Invalid User Name or Password!";
                        LblMessage.Visible = true;
                        Counter = int.Parse(ViewState["Count"].ToString());
                        Counter++;
                        ViewState["Count"] = Counter;

                        return;
                    }

                    if (ChKRM.Checked == true)
                    {
                        HttpCookie RMCookie = new HttpCookie("CookieRM");
                        RMCookie.Values.Add("UserName", txtUName.Text);

                        Response.Cookies.Add(RMCookie);
                    }
                    else
                    {
                        Response.Cookies["CookieRM"].Expires = DateTime.Now.AddDays(-1);
                    }


                    Session["IsLoggedIn"] = true;
                    //Server.Transfer($"Home.aspx?language={DDLLanguages.Text}&Name={txtUName.Text}");
                    Response.Redirect($"Home.aspx?language={DDLLanguages.Text}&Name={txtUName.Text}");
                }
                else
                {
                    LblMessage.Text = "Try Again Later";
                    LblMessage.Visible = true;
                }
            }
            

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Contains("@iti.gov.eg"))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}