using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.DAO.Repository
{
    public abstract class BaseRepository
    {
        static HttpClient client = new HttpClient();
        private const string URL = "http://masglobaltestapi.azurewebsites.net/";
       
        public HttpResponseMessage ApiClient(string parameters)
        {
            try
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(parameters).Result;
                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
