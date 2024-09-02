using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace FFF_Elis.Components.Services;

public class GoogleService
{
    string[] Scopes = { CalendarService.Scope.Calendar };
    string ApplicationName = "Google Calendar Sync with Blazor Scheduler";
    CalendarService Service;
    public GoogleService()
    {
        UserCredential credential;
        using (FileStream stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
        {
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "admin", CancellationToken.None, new FileDataStore("token.json", true)).Result;
        }
        Service = new CalendarService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
    }
}