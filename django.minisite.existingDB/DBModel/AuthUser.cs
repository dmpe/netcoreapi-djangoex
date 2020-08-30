using System;
using System.Collections.Generic;

#nullable disable

namespace django.minisite.existingDB.DBModel
{
    public partial class AuthUser
    {
        public AuthUser()
        {
            AuthUserGroups = new HashSet<AuthUserGroup>();
            AuthUserUserPermissions = new HashSet<AuthUserUserPermission>();
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
            MainFirmRecommendations = new HashSet<MainFirmRecommendation>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsSuperuser { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsStaff { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateJoined { get; set; }

        public virtual AuthtokenToken AuthtokenToken { get; set; }
        public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual ICollection<MainFirmRecommendation> MainFirmRecommendations { get; set; }
    }
}
