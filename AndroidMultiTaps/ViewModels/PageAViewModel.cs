using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;

namespace AndroidMultiTaps
{
    public class PageAViewModel : BaseViewModel
    {
        public PageAViewModel (Page page)
        {
            Title = "Page A";
            Message = "Welcome to Page A";
            CurrentPage = page;
        }

        public ICommand GoToPageBCommand => new Command (OnGoToPageBTapped);

        async void OnGoToPageBTapped (object obj)
        {
            await CurrentPage.Navigation.PushAsync (new PageBView ());
        }

    }
}
