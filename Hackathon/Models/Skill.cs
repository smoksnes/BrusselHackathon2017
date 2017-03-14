using System.Runtime.Serialization;

namespace Hackathon.Web.Models
{
    [DataContract]
    public class Skill
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}