using System;
using System.Collections.Generic;

#nullable disable

namespace SelfMadeDB.DBModel
{
    public partial class Author
    {
        public Author()
        {
            FirmRecommendations = new HashSet<FirmRecommendations>();
        }

        public int ID { get; set; }
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

        public virtual ICollection<FirmRecommendations> FirmRecommendations { get; set; }
    }
}
