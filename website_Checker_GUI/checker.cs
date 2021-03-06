﻿using System;
using System.Net;
using System.Net.Mail;
using System.Windows;


namespace website_Checker_GUI
{
    class checker
    {



        internal const string server = "smtp.gmail.com";
        internal string domain;

        internal static int CreateMessage(string server)
        {



            string to = "tahboub252@gmail.com";
            string from = "tahboub252@gmail.com";
            string subject = "Alert!!";
            string body = "The Website might not be working. Check it.";


            try
            {

                SmtpClient client = new SmtpClient(server)
                {

                    Port = 587,
                    Credentials = new NetworkCredential("email", "password"),
                    EnableSsl = true,

                };
                client.Send(from, to, subject, body);
                return 1;
            }
            catch (Exception ex)
            {

                // to do: showing error when chtching a problem
                //System.Windows.Application.Current.Shutdown();
                MessageBox.Show("Authintication Error: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);


                return 0;
            }

        }

        internal static int checkWebsiteStatus(string domain)
        {
            int isReachable = 0;


            if (!domain.Contains("http://www.") || domain == string.Empty || domain == "http://www.")
            {
                return isReachable;
            }



            try
            {
                HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(domain);
                httpReq.AllowAutoRedirect = false;
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
