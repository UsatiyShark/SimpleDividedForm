using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DividedFormPractics
{
    public class Foxes: AnimalPicProvider
    {
        public string GetAnimalPic()
        {

            string url = $"https://randomfox.ca/floof/";


            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string responsePicture;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responsePicture = streamReader.ReadToEnd();
            }
            JObject jsonObject = JObject.Parse(responsePicture);
            return jsonObject["image"].ToString();
        }
    }
}
