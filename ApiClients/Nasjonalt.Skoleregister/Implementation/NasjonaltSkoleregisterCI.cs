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

        private HttpClient _apiClient;

        public NasjonaltSkoleregisterCI(NasjonaltSkoleregisterConfig apiConfig)
        {
            _apiConfig = apiConfig;
        }


        public async Task<List<Enhet>> GetAlleEnheterAsync()
        {
            string apiUrl = $"enheter";

            List<Enhet> result = new List<Enhet>();
           
            HttpResponseMessage respons = await ApiClient.GetAsync(apiUrl);

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


        public HttpClient ApiClient

        {
            get
            {
                if (_apiClient != null)
                {
                    return _apiClient;
                }

                _apiClient = GetNewHttpClient(_apiConfig.ApiBaseUrl);

                return _apiClient;
            }
        }

        private HttpClient GetNewHttpClient(string apiEndpoint)
        {
            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(apiEndpoint)
            };

            return httpClient;
        }
    }
}
