using System.ComponentModel.DataAnnotations.Schema;

namespace ModelService_ArgusBackend.Models
{
    public class Log
    {
        [Column("logId")]
        public string LogId { get; set; }

        [Column("boxId")]
        public string BoxId { get; set; }

        [Column("itemType")]
        public string ItemType { get; set; }

        [Column("userId")]
        public string UserId { get; set; }
        
        [Column("totalCount")]
        public int TotalCount { get; set; }

        [Column("startTime")]
        public DateTime StartTime { get; set; }

        [Column("endTime")]
        public DateTime EndTime { get; set; }

        [Column("fullLogFile")]
        public string FullLogFile { get; set; }
    }
}