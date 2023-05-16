using Microsoft.AspNetCore.Identity;

namespace FPTBookStore.Models
{
    public class UserRoleViewModel
    {
        public ApplicationUser applicationUser;
        public List<IdentityRole> applicationRole;

        public UserRoleViewModel(ApplicationUser applicationUser, List<IdentityRole> applicationRole)
        {
            this.applicationUser = applicationUser;
            this.applicationRole = applicationRole;
        }
    }
}
