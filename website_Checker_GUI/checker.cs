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

        internal static int checkWebsiteStatus(string domain)
        {
            int isReachable = 0;


            if (!domain.Contains("http://www.") || domain == string.Empty || !domain.Contains(".com"))
            {
                return isReachable;
            }

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(domain);
            httpReq.AllowAutoRedirect = false;

            try
            {

                HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();

                if (httpRes.StatusCode != HttpStatusCode.NotFound)
                {


                    isReachable = 1;
                    return isReachable;

                }

                httpRes.Close();



            }
            catch (System.Exception)
            {

                isReachable = 2;
                return isReachable;


            }



            return isReachable;

        }




    }
}
