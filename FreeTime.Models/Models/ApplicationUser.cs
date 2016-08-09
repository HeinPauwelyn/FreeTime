using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeTime.Common.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    [Table("Users")]
    public class ApplicationUser : IdentityUser
    {
        private DateTime _creation = DateTime.MinValue;

        [DataType(DataType.ImageUrl)]
        public string ProfilePictureUrl { get; set; }

        [DataType(DataType.Text)]
        public string AboutMe { get; set; }
        
        public DateTime Creation
        {
            get
            {
                if (_creation == DateTime.MinValue)
                {
                    return DateTime.Now;
                }
                return _creation;
            }
            set
            {
                _creation = value;
            }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            ClaimsIdentity userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> userManager, string authenticationType)
        {
            return await GenerateUserIdentityAsync(userManager);
        }
    }
}