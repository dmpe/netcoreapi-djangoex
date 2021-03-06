﻿using System;
using System.Collections.Generic;

#nullable disable

namespace django.minisite.existingDB.DBModel
{
    public partial class AuthGroupPermission
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PermissionId { get; set; }

        public virtual AuthGroup Group { get; set; }
        public virtual AuthPermission Permission { get; set; }
    }
}
