using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prism.Navigation
{
    public interface IDynamicNavigation
    {
        //Shell navigation
        Task GoToAsync(ShellNavigationState state, INavigationParameters param = null);
    }
}
