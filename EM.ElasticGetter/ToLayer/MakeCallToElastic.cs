using EM.Helper.Models;
using EM.Helper.RestCaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.ElasticGetter.ToLayer
{
    public static class MakeCallToElastic
    {

        private static string _url;
        public static string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
            }
        }

        private static string _indiceParameter;
        public static string IndiceParameter
        {
            get { return _indiceParameter; }
            set { _indiceParameter = value; }
        }
        public static List<IndexModel> GetIndiceList()
        {
            var result = RestCall.GetIndexModel(_url, _indiceParameter);
            return result;
        }

        public static List<ElasticSearchDataModel> GetDataModelWithIndiceName(string indice)
        {
            RestCall.GetIndiceTotalCount(_url, "/" + indice + "/_count");

            indice = "/" + indice + "/_search";
            var result = RestCall.GetIndiceData(_url, indice);
            return result;
        }
    }
}
