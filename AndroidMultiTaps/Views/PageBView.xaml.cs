using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AndroidMultiTaps
{
    public partial class PageBView : ContentPage
    {
        public PageBView ()
        {
            InitializeComponent ();
            this.BindingContext = new PageBViewModel (this);
        }
    }
}
