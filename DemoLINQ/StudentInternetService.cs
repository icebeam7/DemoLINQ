using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace DemoLINQ
{
    public static class StudentInternetService
    {
        static string url = "https://gist.githubusercontent.com/icebeam7/db34f8ea90cdaa6d40f769893cf6ea13/raw/a913b83f5b97c9331074f37c16dbd3919c428f5c/Students.json";

        public static async Task<List<Student>> GetStudents()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Student>>(json);
                }
            }

            return null;
        }
    }
}
