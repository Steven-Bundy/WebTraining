﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013b
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisonTypeLabel.Text = " equal to ";
            //comparisonTypeLabel.Text = " not equal to ";
            //comparisonTypeLabel.Text = " greater than ";
            //comparisonTypeLabel.Text = " not equal to ";
        }

        protected void okayButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";

            //resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ? "Yes" : "No";

            //int first = int.Parse(firstTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);
            //resultLabel.Text = (first > second) ? "Yes" : "No";
            //resultLabel.Text = (first < second) ? "Yes" : "No";

            //resultLabel.Text = (!CheckBox1.Checked) ? "NO" : "YES";

            //resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ? "Yes" : "No";

            //if (CheckBox1.Checked
            //    && firstTextBox.Text == "Bob"
            //    && secondTextBox.Text == "Tabor")
            //{
            //    resultLabel.Text = "Perfect trifecta!";
            //}
            //else resultLabel.Text = "NO";

            //if (CheckBox1.Checked 
            //    || firstTextBox.Text == "Bob" 
            //    || secondTextBox.Text == "Tabor")
            //{
            //    resultLabel.Text = "One out of three ain't bad.";
            //}

            if (CheckBox1.Checked
                || firstTextBox.Text == "Bob"
                && secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "Two out of three ain't bad.";
            }
        }
    }
}