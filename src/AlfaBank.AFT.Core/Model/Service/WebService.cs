﻿using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;

namespace AlfaBank.AFT.Core.Model.Service
{
    public class WebService
    {
        public string Url { get; set; }
        public NameValueCollection HeadersCollection { get; set; }
        public Dictionary<string, string> ParametersCollection { get; set; } = null;
        public string Body { get; set; }
        public Core.Data.Services.Service Service { get; set; }
        public HttpStatusCode? StatusCode { get; set; }
        public IEnumerable<Exceptions.Error> Errors { get; set; } = null;
    }
}
