﻿using System;
using System.Collections.Generic;

#nullable disable

namespace django.minisite.existingDB.DBModel
{
    public partial class DjangoMigration
    {
        public int Id { get; set; }
        public string App { get; set; }
        public string Name { get; set; }
        public DateTime Applied { get; set; }
    }
}
