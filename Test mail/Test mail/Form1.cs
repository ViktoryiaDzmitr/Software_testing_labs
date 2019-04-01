using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limilabs.Client.IMAP;
using Limilabs.Mail;


namespace Test_mail
{
    public partial class Form1 : Form
    {
        Dictionary<string, Flag> myDictionary = new Dictionary<string, Flag>();
        


       public string login;
       public string password;
        public Form1(string login, string password)
        {
            InitializeComponent();
            myDictionary.Add("All", Flag.All);
            myDictionary.Add("Unseen", Flag.Unseen);
            myDictionary.Add("Answered", Flag.Answered);



            using (Imap imap = new Imap())
        {
            imap.Connect("imap.mail.ru");   // or ConnectSSL for SSL
            imap.UseBestLogin(login, password);
            imap.SelectInbox();
            List<long> uids = imap.Search(Flag.All);
                int step = 0;
            foreach (long uid in uids)
            { if (step != 10)
                    {
                        var eml = imap.GetMessageByUID(uid);
                        IMail email = new MailBuilder()
                            .CreateFromEml(eml);
                        listBox1.Items.Add(email.Subject +" " + email.Text);
                        step++;
                    }
                    else continue;
                    
            }
            imap.Close();
        }




        }

        private void filterBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Flag selected = myDictionary[filterBox.Text];
            updateMails(selected);
        }

        private void updateMails(Flag selected)
        {

            using (Imap imap = new Imap())
            {
                listBox1.Items.Clear();
                imap.Connect("imap.mail.ru");   // or ConnectSSL for SSL
                imap.UseBestLogin(login, password);
                imap.SelectInbox();
                List<long> uids = imap.Search(selected);
                int step = 0;
                foreach (long uid in uids)
                {
                    if (step != 10)
                    {
                        var eml = imap.GetMessageByUID(uid);
                        IMail email = new MailBuilder()
                            .CreateFromEml(eml);
                        listBox1.Items.Add(email.Subject + " " + email.Text);
                        step++;
                    }
                    else continue;

                }
                imap.Close();
            }

        }
    }
}
