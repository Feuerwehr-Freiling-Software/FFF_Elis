using System.Globalization;
using System.Text.Json.Nodes;
using EPAS.Core.BusinessObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nominatim.API.Address;
using Nominatim.API.Interfaces;
using Nominatim.API.Models;

namespace EPAS.Shared.Services;

public class GeocodingService
{
    public IAddressSearcher AddressSearcher { get; set; }
    public IForwardGeocoder ForwardGeocoder { get; }

    public GeocodingService(IAddressSearcher addressSearcher, IForwardGeocoder forwardGeocoder)
    {
        AddressSearcher = addressSearcher;
        ForwardGeocoder = forwardGeocoder;
    }
    
   public async Task<Waypoint?> GetWaypointAsync(string address)
   {
       if(string.IsNullOrWhiteSpace(address)) return null;
       var splitAdress = address.Replace(",", "").Split(' ');

       Console.WriteLine("Address: " + address);
       
       var waypoint = new Waypoint();
       var request = new ForwardGeocodeRequest()
       {
           BreakdownAddressElements = true,
            StreetAddress = address
       };
        var response = await ForwardGeocoder.Geocode(request);

        if (response == null || response.Length == 0) return null;

        var geocode = response.First();
        
        waypoint.lat = Convert.ToSingle(geocode.Latitude);
        waypoint.lon = Convert.ToSingle(geocode.Longitude);
        
       return waypoint;
   }
}