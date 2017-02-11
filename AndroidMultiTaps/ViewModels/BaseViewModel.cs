using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AndroidMultiTaps
{
    public class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        public string Title { get; set; }

        public string Message { get; set; }
        
        public bool IsBusy { get; set; }

        public bool CanNavigate { get; set; }

        public Xamarin.Forms.Page CurrentPage { get; set; }

        public BaseViewModel ()
        {
            Xamarin.Forms.MessagingCenter.Subscribe<object, bool>(this, "IsBusyChanged", OnIsBusyChanged);
        }

        void OnIsBusyChanged (object sender, bool isBusy)
        {
            IsBusy = isBusy;
            CanNavigate = !IsBusy;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberNameAttribute] string propertyName = "")
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
        }

        public void Dispose()
        {
            Xamarin.Forms.MessagingCenter.Unsubscribe<object, bool> (this, "IsBusyChanged");
        }
    }
}
