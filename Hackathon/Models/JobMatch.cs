using Hackathon.Web.Models.Data;

namespace Hackathon.Web.Models
{
    public class JobMatch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MatchPercentage { get; set; }
        public Skill[] Skills { get; set; }
        public string Description { get; set; }
    }
}