using System;
using System.Collections.Generic;
using System.Text;
using InputValidationNS.Models;

namespace InputValidationNS.ViewModels
{
    public class AppUserViewModel
    {
        private AppUser _AppUser;

        public AppUser CurrentAppUser {
            get {
                return _AppUser;
            }
        }
                
        public AppUserViewModel()
        {
            _AppUser = new AppUser();
        }
    }
}
