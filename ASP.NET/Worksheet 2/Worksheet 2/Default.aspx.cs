using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Worksheet_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IsbnButton_Click(object sender, EventArgs e)
        {
            if (IsbnText.Text.Trim() != "")
            {
                if (IsbnText.Text == "1234")
                {
                    ResultsLabel.Text = "The book is 'Programming ASP.NET woth C#'";
                }
                else
                {
                    ResultsLabel.Text = String.Format("Sorry, but the ISBN {0} has not been found", IsbnText.Text);
                }
            }
        }
    }
}