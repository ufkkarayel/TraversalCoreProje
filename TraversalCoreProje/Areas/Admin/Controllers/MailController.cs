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
            MailboxAddress mailboxAddressFrom = new MailboxAddress(mailRequest.Name, mailRequest.SenderMail);
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo= new MailboxAddress("User",mailRequest.RecieverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Subject= mailRequest.Subject;
            

            return View();
        }
    }
}
