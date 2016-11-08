using System.Threading.Tasks;

namespace BasisMap.Interfaces
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
