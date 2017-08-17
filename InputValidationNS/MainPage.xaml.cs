using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using InputValidationNS.ViewModels;

namespace InputValidationNS
{
    public partial class MainPage : ContentPage
    {
        private AppUserViewModel _vm;

        public AppUserViewModel Vm;

        public MainPage()
        {
            InitializeComponent();

            _vm = new AppUserViewModel();
            BindingContext = Vm;
        }
    }
}
