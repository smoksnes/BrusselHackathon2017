﻿using System.Runtime.Serialization;

namespace Hackathon.Web.Models
{
    [DataContract]
    public class Job
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}