using System;
using System.Collections.Generic;

#nullable disable

namespace django.minisite.existingDB.DBModel
{
    public partial class AuthtokenToken
    {
        public string Key { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }

        public virtual AuthUser User { get; set; }
    }
}
