using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace RMotownFestival.Functions
{
    public class AnalyzationFunction
    {
        private static readonly List<VisualFeatureTypes?> Features = new List<VisualFeatureTypes?> { VisualFeatureTypes.Adult };

        [FunctionName("AnalyzationFunction")]
        public async Task Run([BlobTrigger("picsin/{name}", Connection = "BlobStorageConnection")] byte[] myBlob, string name, ILogger log, Binder binder)
        {
            ImageAnalysis analysis = await VisionClient.AnalyzeImageInStreamAsync(new MemoryStream(myBlob), Features);
            Attribute[] attributes;
            if(analysis.Adult.IsAdultContent || analysis.Adult.IsGoryContent || analysis.Adult.IsRacyContent)
            {
                attributes = new Attribute[]
                {
                    new BlobAttribute($"picsrejected/{name}", FileAccess.Write),
                    new StorageAccountAttribute("BlobStorageConnection")
                };
            }
            else
            {
                attributes = new Attribute[]
                {
                    new BlobAttribute($"festivalpics/{name}", FileAccess.Write),
                    new StorageAccountAttribute("BlobStorageConnection")
                };
            }

            using Stream fileOutputStream = await binder.BindAsync<Stream>(attributes);
            fileOutputStream.Write(myBlob);
        }

        public ComputerVisionClient VisionClient { get; set; }

        public AnalyzationFunction(ComputerVisionClient visionClient)
        {
            VisionClient = visionClient;
        }
    }
}
