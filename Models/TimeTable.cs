﻿namespace SMSWEBAPI.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Subject { get; set; }
        public string TeacherId { get; set; }
    }
}
