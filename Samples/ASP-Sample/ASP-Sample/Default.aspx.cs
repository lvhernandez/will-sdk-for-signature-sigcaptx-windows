using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.IO;

namespace ASP_Sample {
 //   [System.Web.Script.Services.ScriptService]
 [WebService]
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        /// <summary>
        /// This is called when the check sigcaptX button is called. This calls back into the javascript library and 
        /// checks to see if the SigCaptX server is running on the client machine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CheckSigcaptX_Click(object sender, EventArgs e) {
            // textBox.Text = "Toot";
            //Call the JS function
            ScriptManager.RegisterStartupScript(this, GetType(), "checksigcapt", "startSession();", true);
        }

        protected void Capture_Sigature_Click(object sender, EventArgs e) {
            //Get the data from the text boxes
            ScriptManager.RegisterStartupScript(this, GetType(), "captsig", "captureSignature(\"" + nameBox.Text + "\", \"" + reasonBox.Text + "\");", true);
        }

  
        /// <summary>
        /// This method is called when a signature text fss is received 
        /// </summary>
        /// <param name="text"></param>
        [WebMethod]
        public static void ReceivedSignatureText(string signature, string guid) {
            Page page = (Page)HttpContext.Current.Handler;

            //In this sample we just write the last signature text to a file
            var fileLocation = page.Server.MapPath("~/" + guid + ".txt");

            if(File.Exists(fileLocation)) {
                File.Delete(fileLocation);
            }

            using (StreamWriter w = new StreamWriter(fileLocation, true)) {
                w.WriteLine(signature); // Write the text
            }


        }

        protected void Reset_Click(object sender, EventArgs e) {
            //Reset state here
        }

      
    }
}