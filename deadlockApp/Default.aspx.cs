using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (StreamReader sr = new StreamReader(Server.MapPath("theFile.txt")))
        {
            string strContents = sr.ReadToEnd();
            displayBox.Text = strContents;
        }
       
    }


    protected void btnGo_Click(object sender, EventArgs e)
    {
        displayBox.Text = firstWord.Text + " " + secondWord.Text;

        using (StreamReader sr = new StreamReader(Server.MapPath("theFile.txt")))
        {
            string strContents = sr.ReadToEnd();
            strContents.Replace(firstWord.Text, secondWord.Text);
            displayBox.Text = strContents;
        }

    }
}