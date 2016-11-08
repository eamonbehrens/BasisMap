using System.Threading.Tasks;

namespace BasisMap.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
