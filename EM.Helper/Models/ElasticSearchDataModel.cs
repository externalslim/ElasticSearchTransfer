using System;
using System.Collections.Generic;

namespace EM.Helper.Models
{
    public class ElasticSearchDataModelWithIndex
    {
        public string index { get; set; }
        public List<ElasticSearchDataModel> ElasticSearchDataModels { get; set; }
    }
    public class ElasticSearchDataModel
    {
        public Hits hits { get; set; }
    }

    public class Hits
    {
        public List<Hit> hits { get; set; }
    }

    public class Hit
    {
        public string _type { get; set; }
        public string _id { get; set; }
        public dynamic _source { get; set; }
    }

    //public class Source
    //{
    //    public dynamic Object { get; set; }
    //}
}
