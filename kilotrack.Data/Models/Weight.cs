using System;

namespace kilotrack.Data.Models
{
    public class Weight
    {
        public int Id { get; set; }
        public double usersRecentWeight { get; set; }
        public DateTime RecordedDate { get; set; }
    }
}