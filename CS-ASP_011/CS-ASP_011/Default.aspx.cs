using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            //if (firstTextBox.Text == secondTextBox.Text)
            //{
            //    resultLabel.Text = "Yes!   They are equal!";
            //}
            //else
            //{
            //    resultLabel.Text = "No!  They are not equal!";
            //}

            /*if (coolCheckBox.Checked)
            {
                resultLabel.Text = "Yes, you are definitely cool.";
            }
            else
            {
                resultLabel.Text = "Don't be so hard on yourself.";
            }
            */

            if (pizzaRadioButton.Checked)
            {
                resultLabel.Text = "You must be from Chicago!";
            }
            else if (crabLegsRadioButton.Checked)
            {
                resultLabel.Text = "You must be from Boston!";
            }
            else if (cheeseburgerRadioButton.Checked)
            {
                resultLabel.Text = "You must be an American!";
            }
            else
            {
                resultLabel.Text = "Please select one of the options.";
            }
        }
    }
}