using Microsoft.Office.Tools.Ribbon;

namespace CodeDebate.Samples.ConstructiveFeedback.AddIn
{
    public partial class SentimentFeedbackRibbon
    {
        private void SentimentFeedbackRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void AnalyizeSentimentButton_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new SentimentAnalysisResults();
            form.ShowDialog();
        }
    }
}
