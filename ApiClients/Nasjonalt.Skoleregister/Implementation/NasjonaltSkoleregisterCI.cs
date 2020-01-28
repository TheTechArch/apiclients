using Nasjonalt.Skoleregister.Interface;
using Nasjonalt.Skoleregister.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using Newtonsoft.Json;
using System.Threading.Tasks;
using Nasjonalt.Skoleregister.Configuration;

namespace Nasjonalt.Skoleregister.Implementation
{
    public class NasjonaltSkoleregisterCI : INasjonaltSkoleregister
    {

        private NasjonaltSkoleregisterConfig _apiConfig;

        public NasjonaltSkoleregisterCI(NasjonaltSkoleregisterConfig apiConfig)
        {
            _apiConfig = apiConfig;
        }


        public async Task<List<Enhet>> GetAlleEnheterAsync()
        {
            string apiUrl = $"enheter";

            List<Enhet> result = new List<Enhet>();

            HttpClient client = new HttpClient() { BaseAddress = _apiConfig.GetBaseAddress() };

            HttpResponseMessage respons = await client.GetAsync(apiUrl);

            if (respons.StatusCode == System.Net.HttpStatusCode.OK)

            {
                string responseData = respons.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<List<Enhet>>(responseData);
            }

            return result;
        }

        public Enhet GetEnhet(string id)
        {
            throw new NotImplementedException();
        }

        public List<Enhet> GetEnheter(Enhetsok sok)
        {
            throw new NotImplementedException();
        }

        public List<Enhet> GetEnheterByDate(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
