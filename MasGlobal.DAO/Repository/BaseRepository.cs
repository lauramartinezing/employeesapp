using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.DAO.Repository
{
    public abstract class BaseRepository
    {
        HttpClient client = new HttpClient();

        private string URL = ConfigurationManager.AppSettings["ApiPath"];
       
        //Access Api 
        public HttpResponseMessage ApiClient(string parameters)
        {
            try
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(parameters).Result;
                client.Dispose();
                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
