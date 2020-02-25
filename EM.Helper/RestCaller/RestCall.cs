using EM.Helper.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EM.Helper.RestCaller
{
    public static class RestCall
    {
        private static string _contentType = "application/json";
        private static int _totalCount = 0;
        public static List<IndexModel> GetIndexModel(string url, string parameter)
        {
            var indexModel = new List<IndexModel>();

            url = url + parameter;
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = HttpWebRequestMethods.GET.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8))
                    {
                        string responseJSON = myStreamReader.ReadToEnd();
                        indexModel = JsonConvert.DeserializeObject<List<IndexModel>>(responseJSON);
                    }
                }
            }
            return indexModel;
        }

        public static void GetIndiceTotalCount(string url, string parameter)
        {
            var indexModel = new IndexSpesific();
            url = url + parameter;
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = HttpWebRequestMethods.GET.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8))
                    {
                        string responseJSON = myStreamReader.ReadToEnd();
                        indexModel = JsonConvert.DeserializeObject<IndexSpesific>(responseJSON);
                    }
                }
            }
            if (indexModel.count > 0)
            {
                _totalCount = indexModel.count;
            }
        }

        public static List<ElasticSearchDataModel> GetIndiceData(string url, string parameter)
        {
            var indexListModel = new List<ElasticSearchDataModel>();

            int size = 50;
            var forLength = (_totalCount / size) + 1;
            var urlWithParameter = url + parameter;
            int m = 0;
            for (int from = 0; from < forLength; from++)
            {
                var indexModel = new ElasticSearchDataModel();
                url = urlWithParameter;
                url = url + "?from=" + from + "&size=" + size;

                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = HttpWebRequestMethods.GET.ToString();

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8))
                        {
                            string responseJSON = myStreamReader.ReadToEnd();
                            indexModel = JsonConvert.DeserializeObject<ElasticSearchDataModel>(responseJSON);
                            indexListModel.Add(indexModel);
                        }
                    }
                }
            }
            return indexListModel;
        }

        public static void CreateNewIndex(string url, string parameter, string data)
        {
            url = url + parameter;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = _contentType;
            httpWebRequest.Method = HttpWebRequestMethods.POST.ToString();

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = data;
                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
            }
        }
    }
}
