using Xamarin.Forms;
namespace AndroidMultiTaps
{
    public class PageBViewModel : BaseViewModel
    {
        public PageBViewModel (Page page)
        {
            Title = "Page B";
            Message = "Welcome to Page B";
            CurrentPage = page;
        }
    }
}
