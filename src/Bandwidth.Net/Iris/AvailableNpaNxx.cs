﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bandwidth.Net.Iris
{
  public interface IAvailableNpaNxx
  {
    Task<AvailableNpaNxx[]> ListAsync(AvailableNpaNxxQuery query = null, CancellationToken? cancellationToken = null);
  }

  internal class AvailableNpaNxxApi : ApiBase, IAvailableNpaNxx
  {
    public async Task<AvailableNpaNxx[]> ListAsync(AvailableNpaNxxQuery query = null,
      CancellationToken? cancellationToken = null)
    {
      return (await Api.MakeXmlRequestAsync<AvailableNpaNxxResult>(HttpMethod.Get, $"/accounts/{Api.AccountId}/availableNpaNxx", cancellationToken, query))
        .AvailableNpaNxxList;
    }
  }

  public class AvailableNpaNxxQuery
  {
    public string AreaCode { get; set; }
  }

  [XmlType("SearchResultForAvailableNpaNxx")]
  public class AvailableNpaNxxResult
  {
    public AvailableNpaNxx[] AvailableNpaNxxList { get; set; }
  }

  public class AvailableNpaNxx
  {
    public string City { get; set; }
    public string State { get; set; }
    public string Npa { get; set; }
    public string Nxx { get; set; }
    public int Quantity { get; set; }
  }
}