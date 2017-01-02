using CodeDebate.Samples.ConstructiveFeedback.Api.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace CodeDebate.Samples.ConstructiveFeedback.Api.Controllers
{
    public class SentimentFeedbackController : ApiController
    {
        public async Task<HttpResponseMessage> Get(HttpRequestMessage request)
        {
            var response = 
                new HttpResponseMessage();

            var sentimentAnalysisFeedback = 
                new SentimentAnalysisFeedback();

            try
            {
                var addInRequest =
                    request.Content.ReadAsStringAsync().Result;

                var sentimentAnalysisRequest =
                    JsonConvert.DeserializeObject<SentimentAnalysisRequest>(addInRequest);

                var client =
                    new HttpClient
                    {
                        BaseAddress =
                    new Uri(ConfigurationManager.AppSettings["CSTAAPI-BaseUrl"])
                    };

                client.DefaultRequestHeaders.Add(
                    "Ocp-Apim-Subscription-Key",
                    ConfigurationManager.AppSettings["CSTAAPI-Key"]);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var byteData =
                    Encoding.UTF8.GetBytes(
                        "{\"documents\":[{\"id\":\"1\",\"text\":\"" +
                        sentimentAnalysisRequest.EmailContent +
                        "\"},]}");

                var uri = "text/analytics/v2.0/sentiment";

                var content = new ByteArrayContent(byteData);

                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var csResponse = await client.PostAsync(uri, content);

                var sentimentResponse = await csResponse.Content.ReadAsStringAsync();

                var sentiment = JsonConvert.DeserializeObject<RootObject>(sentimentResponse);

                if (sentiment.Documents[0] != null)
                {
                    sentimentAnalysisFeedback.Score = 
                        (int) (sentiment.Documents[0].Score * 100);
                }
                else
                {
                    sentimentAnalysisFeedback.Score = -1;
                }

                if (sentimentAnalysisFeedback.Score < 0)
                {
                    sentimentAnalysisFeedback.Description = ConfigurationManager.AppSettings["Invalid-Description"];
                    sentimentAnalysisFeedback.VisualUri = ConfigurationManager.AppSettings["Invalid-VisualUri"];
                }
                else if(
                    sentimentAnalysisFeedback.Score > 0 
                    && sentimentAnalysisFeedback.Score < 35)
                {
                    sentimentAnalysisFeedback.Description = ConfigurationManager.AppSettings["Low-Description"];
                    sentimentAnalysisFeedback.VisualUri = ConfigurationManager.AppSettings["Low-VisualUri"];
                }
                else if (
                    sentimentAnalysisFeedback.Score > 35 
                    && sentimentAnalysisFeedback.Score < 70)
                {
                    sentimentAnalysisFeedback.Description = ConfigurationManager.AppSettings["Meduim-Description"];
                    sentimentAnalysisFeedback.VisualUri = ConfigurationManager.AppSettings["Meduim-VisualUri"];
                }
                else if (sentimentAnalysisFeedback.Score > 70)
                {
                    sentimentAnalysisFeedback.Description = ConfigurationManager.AppSettings["High-Description"];
                    sentimentAnalysisFeedback.VisualUri = ConfigurationManager.AppSettings["High-VisualUri"];
                }

                response.StatusCode = HttpStatusCode.OK;
                response.Content = 
                    new StringContent(JsonConvert.SerializeObject(sentimentAnalysisFeedback));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Content = new StringContent(ex.ToString());
            }

            return response;
        }

    }
}