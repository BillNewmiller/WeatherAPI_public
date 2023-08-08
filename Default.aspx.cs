using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Linq;
using Microsoft.Ajax.Utilities;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        
        private readonly string api_key; //replace with your api key
        private readonly string api_secret; //replace with your api secret
        private readonly string stationId; replace with your stationID
        private readonly string url;
        private string jsonCurrentWx;
        private int[] lsids = { 62412, 624144, 624131, 624130 }; //modify to represent your lsids
        private HttpResponseMessage jsonResponse;
        private static RootObject rootObject;
        private Type rootObjectType;
        private PropertyInfo[] properties;
        private Object rootObjectValues;
        private static string[] strSensorData = new string[99];


        public WebForm1()
        {
            api_key = "YOUR_API_KEY";
            api_secret = "YOUR_API_SECRET";
            stationId = "YOUR_STATIONID";
            url = "https://api.weatherlink.com/v2/current?" + stationId + "&" + api_key;
            rootObjectType = typeof(RootObject);
         }



        protected void Page_Load(object sender, EventArgs e)
        {
 
        }


        public class MyHttpClient
        {
            private static readonly HttpClient httpClient;

            static MyHttpClient()
            {
                httpClient = new HttpClient();
                // Set any global headers, timeouts, base addresses etc. here
            }

            public static HttpClient Instance
            {
                get { return httpClient; }
            }
        }

        protected async void btnGetJson_Click(object sender, EventArgs e)
        {
            var response = await MyHttpClient.Instance.GetAsync("https://api.weatherlink.com/v2/current/\" + stationId + \"?api-key=\" + api_key");


            //HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.weatherlink.com/v2/current/" + stationId + "?api-key=" + api_key);

            request.Headers.Add("X-Api-Secret", api_secret);

            jsonResponse = await MyHttpClient.Instance.SendAsync(request);
            if (jsonResponse.IsSuccessStatusCode)
            {
                jsonCurrentWx = await jsonResponse.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject(jsonCurrentWx);
                string prettyJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                txtJson.Text = prettyJson;
                btnPopulateClass.Enabled = true;
                btnSensorValues.Enabled = true;
 
            }
            else
                txtJson.Text = $"Request failed with status code: {jsonResponse.StatusCode}";
         }

        protected void btnPopulateClass_Click(object sender, EventArgs e)
        {
            rootObject = JsonConvert.DeserializeObject<RootObject>(txtJson.Text);
            // Get the type of the RootObject class
            //Type rootObjectType = typeof(RootObject);

            // Get all properties of the RootObject class
            properties = rootObjectType.GetProperties();

            // Iterate over each property
            foreach (PropertyInfo property in properties)
            {
                // Get the property name and value
                string propertyName = property.Name;
                object propertyValue = property.GetValue(rootObject);

                // Print the property name and value
                lstRootObject.Items.Add((propertyName + ": " + propertyValue));
            }
            EnableAllButtons();
        }

        protected void btnSensorValues_Click(object sender, EventArgs e)
        {
            dynamic jsonObj = JObject.Parse(txtJson.Text);
            foreach (var sensor in jsonObj.sensors)

                foreach (var data in sensor.data)
                {
                    foreach (var property in data)
                    {
                        lstAllSensorValues.Items.Add(property.Name + ": " + property.Value);
                    }

                }
            EnableAllButtons();
        }

        protected void btnSensorList_Click(object sender, EventArgs e)
        {
            for (int i=0; i < lsids.GetLength(0); i++)
                lblSensorList.Text += lsids[i].ToString() + " ";
            EnableAllButtons() ;
        }

        protected void btnSensorValues1_Click(object sender, EventArgs e)
        {
            Sensor sensor = rootObject.sensors.FirstOrDefault(s => s.sensor_type == 504);
            int idx = 0;

            var data504 = JsonConvert.DeserializeObject<List<SensorData504>>(sensor.data.ToString());

            foreach (var data in data504)
            {
                Type type = data.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    lstSensor1.Items.Add(property.Name + ": " + property.GetValue(data));
                    idx++;

                }
            }
            EnableAllButtons();
        }

        protected void btnSensorValues2_Click(object sender, EventArgs e)
        {
            Sensor sensor = rootObject.sensors.FirstOrDefault(s => s.sensor_type == 43); ;

            var data43 = JsonConvert.DeserializeObject<List<SensorData43>>(sensor.data.ToString());

            foreach (var data in data43)
            {
                Type type = data.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    lstSensor2.Items.Add(property.Name + ": " + property.GetValue(data));
                }
            }
            EnableAllButtons();
        }

        protected void btnSensorValues3_Click(object sender, EventArgs e)
        {
            Sensor sensor = rootObject.sensors.FirstOrDefault(s => s.sensor_type == 243); ;

            var data243 = JsonConvert.DeserializeObject<List<SensorData243>>(sensor.data.ToString());

            foreach (var data in data243)
            {
                Type type = data.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    lstSensor3.Items.Add(property.Name + ": " + property.GetValue(data));
                }
            }
            EnableAllButtons();
        }


            protected void btnSensorValues4_Click(object sender, EventArgs e)
        {
            Sensor sensor = rootObject.sensors.FirstOrDefault(s => s.sensor_type == 242); ;
            var data242 = JsonConvert.DeserializeObject<List<SensorData242>>(sensor.data.ToString());

            foreach (var data in data242)
            {
                Type type = data.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    lstSensor4.Items.Add(property.Name + ": " + property.GetValue(data));
                }
            }
            EnableAllButtons();
        }

        protected void PopulateListBox(ListBox lst, int lsid)
        {

            EnableAllButtons();
        }

        protected void EnableAllButtons()
        {
            btnSensorList.Enabled = true;
            btnSensorValues1.Enabled = true;
            btnSensorValues2.Enabled = true;
            btnSensorValues3.Enabled = true;
            btnSensorValues4.Enabled = true;
        }

   }
}

 
