using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversalcore2@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);


            MailboxAddress mailboxAddressTo= new MailboxAddress("User",mailRequest.RecieverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Subject= mailRequest.Subject;
            

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("traversalcore2@gmail.com", "123456aA-");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
        }
    }
}
