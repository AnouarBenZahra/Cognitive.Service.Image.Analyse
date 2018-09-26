using Cognitive.Service.Image.Analyse.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cognitive.Service.Image.Analyse
{
    public class ImageInfo
    {
        public async Task<ImageInfoViewModel> MakeAnalysisRequest(string subscriptionKey, string imagePath, string endPoint = "https://westus.api.cognitive.microsoft.com/vision/v1.0/analyze")
        {
            var errorList = new List<string>();
            ImageInfoViewModel responeData = new ImageInfoViewModel();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                string requestParameters = "visualFeatures=Categories,Description,Color";
                string uri = endPoint + "?" + requestParameters;
                HttpResponseMessage httpResponseMessage;
                byte[] byteImage = ByteImage(imagePath);
                using (ByteArrayContent imageContent = new ByteArrayContent(byteImage))
                {
                    imageContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    httpResponseMessage = await client.PostAsync(uri, imageContent);
                }
                string responseResult = await httpResponseMessage.Content.ReadAsStringAsync();
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    responeData = JsonConvert.DeserializeObject<ImageInfoViewModel>(responseResult, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Include,
                        Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs earg)
                        {
                            errorList.Add(earg.ErrorContext.Member.ToString());
                            earg.ErrorContext.Handled = true;
                        }
                    });
                }
            }
            catch (Exception e)
            {
                return new ImageInfoViewModel();
            }
            return responeData;
        }
        static byte[] ByteImage(string imageFilePath)
        {
            using (FileStream stream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(stream);
                return binaryReader.ReadBytes((int)stream.Length);
            }
        }

    }
}
