using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Day1.WebForm
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            /* you need to handle this by get the value of vistorsCount before Application_End
             * and save this value in Database or File, then when I restart again my application 
             * I will get the value from file/Database 
             * and make it equal the last value of Application["VistorsCount"]
             */
            Application["VisitorsCount"] = 0;
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            int Count = int.Parse(Application["VisitorsCount"].ToString());
            Count++;
            Application["VisitorsCount"] = Count;

        }

        protected void Session_End(object sender, EventArgs e)
        {
        }



    }
}