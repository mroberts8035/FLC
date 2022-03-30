using System.Web.Mvc;
using StoreFront.UI.MVC.Models; //Access to ContactViewModel
using System.Net.Mail; //Access to MailMessage
using System.Net; //Access to SMTP

namespace StoreFront.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]        
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel cvm)
        {
            if (!ModelState.IsValid)
            {
                return View(cvm);
            }

            string message = $"You have received an email from {cvm.Name}.<br />" +
                $"Subject: {cvm.Subject}<br />" +
                $"Message: {cvm.Message}<br />" +
                $"Please reply to {cvm.Email} with your response at your earliest convience.";

            //MailMessage - WHat sends the email
            //Overload for MailMesage - FROM, TO, SUBJECT, BODY
            MailMessage mm = new MailMessage("administrator@mattroberts-dev.com", "mroberts8035@outlook.com", cvm.Subject, message);

            //MailMessage Property Tweaks
            mm.IsBodyHtml = true;
            mm.Priority = MailPriority.High;
            //Reply to the sender, and not our website/webmail
            mm.ReplyToList.Add(cvm.Email);

            //SmtpClient - Info from the host that allows emails to be sent (usually in the secret keys and config)
            SmtpClient client = new SmtpClient("mail.mattroberts-dev.com");

            //Client Credentials (email login info in secret keys)
            client.Credentials = new NetworkCredential("administrator@mattroberts-dev.com", "P@ssw0rd");

            //Port options -- SMTP uses two ports 25 and 8889. Test with both to determine
            //if your internet provider blockes/does not use one of these.
            //client.Port = 25;
            client.Port = 8889;

            //Try to send the email
            try
            {
                //Attempt to send the email
                client.Send(mm);
            }
            catch (System.Exception ex)
            {

                ViewBag.CustomerMessage = $"We're sorry, but your request could not be completed at this time." +
                     $"Please try again later. If the issue persists, please contact your site adminstrator and provide" +
                     $"the following info:<br /><br /> {ex.StackTrace}";
                return View(cvm);
            }

            return View("EmailConfirmation", cvm);

        }

    }
}
