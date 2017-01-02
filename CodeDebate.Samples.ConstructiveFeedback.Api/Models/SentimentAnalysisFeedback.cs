namespace CodeDebate.Samples.ConstructiveFeedback.Api.Models
{
    public class SentimentAnalysisFeedback
    {
        public int Score { get; set; }
        public string Description { get; set; }
        public string VisualUri { get; set; }

        public SentimentAnalysisFeedback() { }
    }
}