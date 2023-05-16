using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FPTBookStore.Models
{
    public class UserRoleViewModel
    {
        public ApplicationUser applicationUser;
        public List<SelectListItem> applicationRole;
        public string? selectedRole { get; set; }

        public UserRoleViewModel(ApplicationUser applicationUser, List<SelectListItem> applicationRole)
        {
            this.applicationUser = applicationUser;
            this.applicationRole = applicationRole;
        }

        public UserRoleViewModel() { }
    }
}
