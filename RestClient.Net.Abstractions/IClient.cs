using System;
using System.Threading.Tasks;

namespace RestClient.Net.Abstractions
{
    public interface IClient
    {
        ISerializationAdapter SerializationAdapter { get; }
        Task<Response<TResponseBody>> SendAsync<TResponseBody, TRequestBody>(Request<TRequestBody> request);
        IHeadersCollection DefaultRequestHeaders { get; }
        TimeSpan Timeout { get; set; }
        Uri BaseUri { get; set; }
    }
}