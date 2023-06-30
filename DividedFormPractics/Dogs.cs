using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DividedFormPractics
{
    public class Dogs: AnimalPicProvider
    {
        public string GetAnimalPic()
        {
            
            string url = $"https://random.dog/woof.json";


            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string responsePicture;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responsePicture = streamReader.ReadToEnd();
            }
            JObject jsonObject = JObject.Parse(responsePicture);
            return jsonObject["url"].ToString();
        }
    }
}
