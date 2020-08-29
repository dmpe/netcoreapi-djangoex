using System;
using System.Collections.Generic;

#nullable disable

namespace testcore.DBModel
{
    public partial class AuthtokenToken
    {
        public string Key { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }

        public virtual AuthUser User { get; set; }
    }
}
