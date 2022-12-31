using System;
namespace Aimo.Models
{
    public class Explore
    {
        public Explore()
        {
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Requester { get; set; }
        public string Accepted_By { get; set; }
        public DateTime Due_Date { get; set; }
        public string Status { get; set; }
    }
}