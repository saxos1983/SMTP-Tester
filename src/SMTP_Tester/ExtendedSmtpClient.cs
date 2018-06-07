using System.Net.Mail;
using System.Reflection;

namespace SMTP_Tester
{
    public class ExtendedSmtpClient : SmtpClient
    {
        private void SetClient(string client)
        {
            typeof(SmtpClient).GetField("clientDomain", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(this, client);
        }

        public ExtendedSmtpClient()
                : base() { }
        public ExtendedSmtpClient(string client)
                :base()
            {
            SetClient(client);
        }
        public ExtendedSmtpClient(string host, string client)
                :base(host)
            {
            SetClient(client);
        }
        public ExtendedSmtpClient(string host, int port, string client)
                :base(host,port)
            {
            SetClient(client);
        }
    }
}
