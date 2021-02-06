using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace MoneyTale.Web
{
    internal class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
