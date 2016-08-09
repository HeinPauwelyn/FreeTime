using FreeTime.Common.Models;

namespace FreeTime.WebApp.ViewModels
{
    internal class UserIndexViewModel
    {
        public ApplicationUser User { get; set; }

        public UserIndexViewModel(ApplicationUser applicationUser)
        {
            User = applicationUser;
        }
    }
}