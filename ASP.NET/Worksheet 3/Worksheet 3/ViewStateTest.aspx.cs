using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Worksheet_3
{
    public partial class ViewStateTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PostbackButton1_Click(object sender, EventArgs e)
        {
            PostBackLabel1.Text = "Set At: " + DateTime.Now;
        }

        protected void PostbackButton2_Click(object sender, EventArgs e)
        {
            PostBackLabel2.Text = "Set At: " + DateTime.Now;
        }
    }
}