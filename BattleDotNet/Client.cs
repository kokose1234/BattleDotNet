using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet
{
    public abstract class Client
    {
        // This will help ensure the main constructor is used
        private Client()
        {
        }

        public Client(string baseUrl, string publicKey = null, string signature = null)
        {
            if (baseUrl == null)
                throw new ArgumentNullException("baseUrl");

            _baseUrl = NormalizePath(baseUrl);
            UseHttps = true;

            _requestManager = new RequestManager(publicKey, signature);
        }

        private readonly RequestManager _requestManager;

        /// <summary>
        /// Gets or sets a value that indicates if HTTPS should be used.
        /// </summary>
        public bool UseHttps { get; private set; }

        private readonly string _baseUrl;
        protected string BaseUrl
        {
            get { return _baseUrl; }
        }

        private string NormalizePath(string path)
        {
            return path.TrimEnd('/').TrimStart('/');
        }

        protected T Get<T>(string path, IEnumerable<KeyValuePair<string, string>> parameters = null)
        {
            if (path == null)
                throw new ArgumentNullException(path);

            string url = string.Format(
                    "{0}://{1}.battle.net/api/{2}/{3}",
                    UseHttps ? "https" : "http",
                    "us",
                    BaseUrl,
                    path
                );            

            return _requestManager.Get<T>(url);
        }
    }

    public enum ClientRegion
    {
        /// <summary>
        /// United States
        /// </summary>
        US,
        /// <summary>
        /// Europe
        /// </summary>
        EU,
        /// <summary>
        /// Korea
        /// </summary>
        KR,
        /// <summary>
        /// Taiwan
        /// </summary>
        TW
    }
}