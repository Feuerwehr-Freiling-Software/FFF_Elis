using System.Globalization;
using System.Text.Json.Nodes;
using FFF_Elis.Components.BusinessObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nominatim.API.Address;
using Nominatim.API.Interfaces;
using Nominatim.API.Models;

namespace FFF_Elis.Components.Services;

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
       var splitAdress = address.Replace(",", "").Split(' ');

       Console.WriteLine("Address: " + address);
       
       var waypoint = new Waypoint();
       var request = new ForwardGeocodeRequest()
       {
            StreetAddress = splitAdress[0] + " " + splitAdress[1],
            PostalCode = splitAdress[2],
       };
        var response = await ForwardGeocoder.Geocode(request);

        if (response == null || response.Length == 0) return null;

        var geocode = response.First();
        
        waypoint.lat = Convert.ToSingle(geocode.Latitude);
        waypoint.lon = Convert.ToSingle(geocode.Longitude);
        
       return waypoint;
   }
}