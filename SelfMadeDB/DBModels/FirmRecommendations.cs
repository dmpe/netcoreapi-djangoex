using System;

namespace SelfMadeDB.DBModel
{
    public class FirmRecommendations
    {
        public int RecommendationID { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string Positioning { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Outperformance { get; set; }
        public string TimeHorizon { get; set; }
        public string BloombergTicker1 { get; set; }
        public string BloombergTicker2 { get; set; }
        public int UserID { get; set; }
        public Guid UUID { get; set; }

        public virtual Author User { get; set; }
    }
}
