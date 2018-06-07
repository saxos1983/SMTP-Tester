using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTP_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbHelo.Text = GetFQDN();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.tbErrorOutput.Text = string.Empty;
            this.SendMail(tbFrom.Text, tbTo.Text, tbSubject.Text, tbBody.Text, tbSMTP.Text, int.Parse(tbPort.Text), cbUseSSL.Checked, tbUsername.Text, tbPassword.Text);
            Cursor.Current = Cursors.Default;
        }

        private bool SendMail(string from, string to, string subject, string body, string smtp, int port, bool useSSL, string user, string password)
        {
            try
            {
                var client = new ExtendedSmtpClient(smtp, tbHelo.Text);
                client.Port = port;
                client.EnableSsl = useSSL;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(user, password);

                var mailmessage = new MailMessage(from, to, subject, body);
                mailmessage.BodyEncoding = System.Text.Encoding.UTF8;
                mailmessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mailmessage);
                tbErrorOutput.Text = "OK - Mail sent";
                return true;
            } catch (Exception e)
            {
                string error = e.ToString();
                
                if (e.InnerException != null)
                {
                    error += string.Format("InnerException is: {0}", e.InnerException);
                }

                tbErrorOutput.Text = e.ToString();
                return false;
            }
            
        }

        private static string GetFQDN()
        {
            string domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
            string hostName = Dns.GetHostName();

            domainName = "." + domainName;
            if (!hostName.EndsWith(domainName))
            {
                hostName += domainName;
            }

            return hostName;
        }
    }
}
