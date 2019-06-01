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
        updatetext();
    }


    protected void btnGo_Click(object sender, EventArgs e)
    {
        displayBox.Text = firstWord.Text + " " + secondWord.Text;
        string newStr = "";

        using (StreamReader sr = new StreamReader(Server.MapPath("theFile.txt")))
        {
            string strContents = sr.ReadToEnd();
            newStr = strContents.Replace(firstWord.Text, secondWord.Text);
           
        }

        using (StreamWriter wr = new StreamWriter(Server.MapPath("theFile.txt"), false))
        {
            wr.WriteLine(newStr);
        }

        updatetext();
    }

    private void updatetext()
    {
        using (StreamReader sr = new StreamReader(Server.MapPath("theFile.txt")))
        {
            string strContents = sr.ReadToEnd();
            displayBox.Text = strContents;
        }
    }
}