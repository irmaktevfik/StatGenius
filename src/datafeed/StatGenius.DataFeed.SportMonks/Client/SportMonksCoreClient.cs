using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace StatGenius.DataFeed.Models.Client;

public class SportMonksCoreClient : SportMonksClient
{
    public SportMonksCoreClient() : base(SportMonksFeedTypes.Core)
    {
                
    }


}