using LoginRadiusSDK.V2.Common;

namespace LoginRadiusSDK.V2
{
    public static class LoginRadiusSdkGlobalConfig
    {
        public static string ProxyAddress { get; set; }
        public static string ProxyCredentials { get; set; }
        public static int ConnectionTimeout { get; set; }
        public static int RequestRetries { get; set; }
        public static string ApiRegion { get; set; }


        public static string _hostPath { get; set; }

        public static string _optionalDarkWebTemplate { get; set; }

        public static string _requiredDarkWebTemplate { get; set; }

        public static string _darkWebUrl { get; set; }

        public static string _darkWebUserName { get; set; }

        public static string _darkWebPassword { get; set; }

        private static string _apiKey;

        public static string ApiKey
        {
            get
            {

                return string.IsNullOrWhiteSpace(_apiKey) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.LoginRadiusApiKey]
                    : _apiKey;
            }
            set { _apiKey = value; }
        }

        public static string HostPath
        {
            get
            {

                return string.IsNullOrWhiteSpace(_hostPath) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.HostPath]
                    : _hostPath;
            }
            set { _hostPath = value; }
        }
        public static string OptionalDarkWebTemplate
        {
            get
            {

                return string.IsNullOrWhiteSpace(_optionalDarkWebTemplate) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.OptionalDarkWebTemplate]
                    : _optionalDarkWebTemplate;
            }
            set { _optionalDarkWebTemplate = value; }
        }
        public static string RequiredDarkWebTemplate
        {
            get
            {

                return string.IsNullOrWhiteSpace(_requiredDarkWebTemplate) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.RequiredDarkWebTemplate]
                    : _requiredDarkWebTemplate;
            }
            set { _requiredDarkWebTemplate = value; }
        }


        public static string ApiSecret { get; set; }
        public static string ApiRequestSigning { get; set; }

        private static string _appName;

        public static string AppName
        {
            get
            {
                return string.IsNullOrWhiteSpace(_appName) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.LoginRadiusAppName]
                    : _appName;
            }
            set { _appName = value; }
        }

        private static string _domainName;

        public static string DomainName
        {
            get
            {
                return string.IsNullOrWhiteSpace(_domainName) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.DomainName]
                    : _domainName;
            }
            set { _domainName = value; }
        }


        public static string DarkWebUrl
        {
            get
            {

                return string.IsNullOrWhiteSpace(_darkWebUrl) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.DarkWebUrl]
                    : _darkWebUrl;
            }
            set { _darkWebUrl = value; }
        }

        public static string DarkWebUserName
        {
            get
            {

                return string.IsNullOrWhiteSpace(_darkWebUserName) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.DarkWebUserName]
                    : _darkWebUserName;
            }
            set { _darkWebUserName = value; }
        }

        public static string DarkWebPassword
        {
            get
            {

                return string.IsNullOrWhiteSpace(_darkWebPassword) && LoginRadiusResource.ConfigDictionary != null
                    ? LoginRadiusResource.ConfigDictionary[LRConfigConstants.DarkWebPassword]
                    : _darkWebPassword;
            }
            set { _darkWebPassword = value; }
        }
    }
}