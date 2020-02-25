using EM.Helper.RestCaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.ElasticPusher.FromLayer
{
    public class MakeCallFromElastic
    {
        private static string _url;
        public static string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        private static string _indiceParameter;
        public static string IndiceParameter
        {
            get { return _indiceParameter; }
            set { _indiceParameter = value; }
        }

        private static dynamic data;
        public static dynamic Data
        {
            get { return data; }
            set { data = value; }
        }

        public static void CreateNewIndex()
        {
            RestCall.CreateNewIndex(_url, _indiceParameter, data);
        }
    }
}
