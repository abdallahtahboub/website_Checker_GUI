using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Mail;


namespace website_Checker_GUI
{
    class checker
    {


        internal const string RequestUri = "http://www.google.de";
        internal const string server = "smtp.gmail.com";

        internal static void CreateMessage(string server)
        {

            string to = "tahboub252@gmail.com";
            string from = "tahboub252@gmail.com";
            string subject = "Alert!!";
            string body = "The Website might not be working. Check it.";
            SmtpClient client = new SmtpClient(server)
            {

                Port = 587,
                Credentials = new NetworkCredential("tahboub252@gmail.com", "lifehaschanged1"),
                EnableSsl = true,

            };
            client.Send(from, to, subject, body);



        }

        internal static bool checkWebsiteStatus(string domain)
        {
            bool isReachable = false;
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(domain);
            httpReq.AllowAutoRedirect = false;

            try
            {
                HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();

                if (httpRes.StatusCode != HttpStatusCode.NotFound)
                {


                    isReachable = true;



                }

                httpRes.Close();



            }
            catch (System.Exception)
            {

                isReachable = false;


            }



            return isReachable;

        }




    }
}
