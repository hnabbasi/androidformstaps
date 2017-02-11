using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AndroidMultiTaps
{
    public partial class PageAView : ContentPage
    {
        public PageAView ()
        {
            InitializeComponent ();
            this.BindingContext = new PageAViewModel (this);
        }
    }
}
