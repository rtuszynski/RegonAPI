using RegonAPI.GUS;
using RegonAPI.Interfaces;
using System.Data;
using System.IO;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace RegonAPI.Services
{
    public class BusinessSearchService : IBusinessSearchService
    {
        private readonly UslugaBIRzewnPublClient _client;

        public BusinessSearchService(UslugaBIRzewnPublClient client)
        {
            _client = client;
        }

        public DataSet SearchEntities(string nipList)
        {
            string sid = _client.Zaloguj("abcde12345abcde12345");
            try
            {
                using (var scope = new OperationContextScope(_client.InnerChannel))
                {
                    var requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers.Add("sid", sid);
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;

                    var parametryWyszukiwania = new ParametryWyszukiwania { Nipy = nipList };
                    var sr = new StringReader(_client.DaneSzukajPodmioty(parametryWyszukiwania));
                    var dataSet = new DataSet();
                    dataSet.ReadXml(sr);
                    return dataSet;
                }
            }
            finally
            {
                _client.Wyloguj(sid);
            }
        }
    }
}
