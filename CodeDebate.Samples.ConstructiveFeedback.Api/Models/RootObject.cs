using System.Collections.Generic;

namespace CodeDebate.Samples.ConstructiveFeedback.Api.Models
{
    public class RootObject
    {
        public List<Document> Documents { get; set; }
        public List<object> Errors { get; set; }
    }
}