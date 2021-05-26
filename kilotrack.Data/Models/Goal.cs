using System;

namespace kilotrack.Data.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public double startWeight { get; set; }
        public double targetWeight { get; set; }
        public DateTime RecordedDate { get; set; }
    }
}