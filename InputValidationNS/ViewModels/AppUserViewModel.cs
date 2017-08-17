using System;
using System.Collections.Generic;
using System.Text;
using InputValidationNS.Models;
using System.ComponentModel.DataAnnotations;

namespace InputValidationNS.ViewModels
{
    public class AppUserViewModel : IValidatableObject
    {
        private AppUser _AppUser;

        public AppUser CurrentAppUser {
            get {
                return _AppUser;
            }
        }

        public string FirstName
        {
            get { return _AppUser.firstName; }
            set
            {
                _AppUser.firstName = value;
            }
        }

        public string LastName
        {
            get { return _AppUser.lastName; }
            set
            {
                _AppUser.lastName = value;
            }
        }

        public AppUserViewModel()
        {
            _AppUser = new AppUser();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
