using System;
using System.Collections.Generic;

#nullable disable

namespace django.minisite.existingDB.DBModel
{
    public partial class DjangoSession
    {
        public string SessionKey { get; set; }
        public string SessionData { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
