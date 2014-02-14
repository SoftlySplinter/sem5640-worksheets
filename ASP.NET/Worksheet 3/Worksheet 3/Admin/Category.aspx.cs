using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusinessLayer.Admin
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.ToString());

            if (e.Exception != null)
            {
                System.Diagnostics.Debug.WriteLine("An exception was thrown.");

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("That was fine!");
            }
        }

        protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Here in inserting");
        }
    }
}