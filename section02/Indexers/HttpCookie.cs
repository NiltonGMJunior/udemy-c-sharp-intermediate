using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            this._dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get => this._dictionary[key];
            set => this._dictionary[key] = value;
        }
    }
}
