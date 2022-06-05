using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prism.Navigation
{
    public interface INavigationService
    {
        //Shell navigation
        Task GoToAsync(ShellNavigationState state, INavigationParameters param = null);
    }
}
