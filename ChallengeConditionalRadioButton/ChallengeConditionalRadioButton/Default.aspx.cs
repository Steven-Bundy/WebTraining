using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            itemImage.ImageUrl = "";

            resultLabel.Text = (pencilRadioButton.Checked) ? "You selected Pencil"
                : (penRadioButton.Checked) ? "You selected Pen"
                : (phoneRadioButton.Checked) ? "You selected Phone"
                : (tabletRadioButton.Checked) ? "You selected Tablet"
                : "Select one option";
            itemImage.ImageUrl = (pencilRadioButton.Checked) ? "~/Images/pencil.png"
                : (penRadioButton.Checked) ? "~/Images/pen.png"
                : (phoneRadioButton.Checked) ? "~/Images/phone.png"
                : (tabletRadioButton.Checked) ? "~/Images/tablet.png"
                : "";
        }
    }
}