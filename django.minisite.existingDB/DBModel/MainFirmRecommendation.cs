using System;
using System.Collections.Generic;

#nullable disable

namespace django.minisite.existingDB.DBModel
{
    public partial class MainFirmRecommendation
    {
        public int Id { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string Positioning { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Outperformance { get; set; }
        public string TimeHorizon { get; set; }
        public string BloombergTicker1 { get; set; }
        public string BloombergTicker2 { get; set; }
        public int UserId { get; set; }
        public Guid Uuid { get; set; }

        public virtual AuthUser User { get; set; }
    }
}
