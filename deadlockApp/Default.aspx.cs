using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
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
        loadImg.Visible = true;
        startMain();
    }


    private void startMain()
    {
        if (firstWord.Text == "" || secondWord.Text == "")
        {
            loadImg.Visible = false;
            return;
        }

        //check for lock here
        if (File.Exists(Server.MapPath("theFile.lock")))
        {
            ErrorLabel.Text = "File currently in use, please try again.";
            return;
        }


        //create lock here
        try
        {
            if (!File.Exists(Server.MapPath("theFile.lock")))
            {
                FileStream strm = File.Create(Server.MapPath("theFile.lock"));
                strm.Close();
            }
        }
        catch (Exception err)
        {
            ErrorLabel.Text = "File currently in use, please try again.";
            return;
        }


        string newStr = "";
        using (FileStream stroom = new FileStream(Server.MapPath("theFile.txt"), FileMode.Open, FileAccess.Read, FileShare.None))  //new StreamReader(Server.MapPath("theFile.txt")))
        {
            using (StreamReader sr = new StreamReader(stroom))
            {
                string strContents = sr.ReadToEnd();
                newStr = strContents.Replace(firstWord.Text, secondWord.Text);

            }

        }

        
        using (FileStream stroom = new FileStream(Server.MapPath("theFile.txt"), FileMode.Open, FileAccess.Write, FileShare.None))  //new StreamReader(Server.MapPath("theFile.txt")))
        {
            using (StreamWriter wr = new StreamWriter(stroom))
            {
                wr.Write(newStr);
            }
        }


        Thread.Sleep(5000);

        updatetext();


        //delete lock here
        try
        {
            File.Delete(Server.MapPath("theFile.lock"));
        }
        catch (Exception err)
        {
            ErrorLabel.Text = "File currently in use, please try again.";
            return;
        }

        ErrorLabel.Text = "";
    }


    private void updatetext()
    {
        loadImg.Visible = false;
        using (FileStream stroom = new FileStream(Server.MapPath("theFile.txt"), FileMode.Open, FileAccess.Read, FileShare.None))  //new StreamReader(Server.MapPath("theFile.txt")))
        {
            using (StreamReader sr = new StreamReader(stroom))
            {
                string strContents = sr.ReadToEnd();
                displayBox.Text = strContents;
            }
        }
    }
}