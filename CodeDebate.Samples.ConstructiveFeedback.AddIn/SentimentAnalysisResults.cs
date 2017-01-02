using Microsoft.Office.Interop.Outlook;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace CodeDebate.Samples.ConstructiveFeedback.AddIn
{
    public partial class SentimentAnalysisResults : Form
    {
        public SentimentAnalysisResults()
        {
            InitializeComponent();
        }

        private void SentimentAnalysisResults_Load(object sender, EventArgs e)
        {
            var apiHttpClient = new HttpClient();
            var consutrictiveFeedbackApiUri = "https://constructivefeedbackaddin.azurewebsites.net/api/sentimentfeedback";
            var feedbackRequest = new SentimentAnalysisRequest();

            try
            {
                Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();
                if (inspector != null)
                {
                    if (inspector.CurrentItem != null)
                    {
                        if (inspector.CurrentItem is MailItem)
                        {
                            var mailItem = (MailItem)inspector.CurrentItem;
                            feedbackRequest.EmailContent = mailItem.Body;
                        }
                    }
                }

                    var response = 
                        apiHttpClient.PostAsync(consutrictiveFeedbackApiUri, 
                        new StringContent(
                            JsonConvert.SerializeObject(
                                feedbackRequest))).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var sentimentFeedbackString =
                            response.Content.ReadAsStringAsync().Result;

                        var sentimentFeedback =
                            JsonConvert.DeserializeObject<SentimentAnalysisFeedback>(sentimentFeedbackString);

                        SentimentDescription.Text =
                            string.Format("{0} ({1}).",
                            sentimentFeedback.Description,
                            sentimentFeedback.Score.ToString());

                        SentimentVisual.ImageLocation = sentimentFeedback.VisualUri;
                    }
                    else
                    {
                        SentimentDescription.Text =
                            string.Format(
                                "Opps.! Something went wrong in the Web API: {0} \n- Web API status code: {1}",
                                response.Content.ReadAsStringAsync(),
                                response.StatusCode);
                    }
            }
            catch (System.Exception ex)
            {
                SentimentDescription.Text =
                    string.Format(
                        "Opps.! Something went wrong: {0}", ex.ToString());
            }
        }
    }
}
