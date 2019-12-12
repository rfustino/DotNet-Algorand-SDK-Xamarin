using ForKMDHTTPAPI.Standard.Models;
namespace ForKMDHTTPAPI.Standard
{
    public partial class Configuration
    {


        //The base Uri for API calls
        public static string BaseUri = "http://localhost";

        //Generated header parameter. This value can be found in `/kmd/data/dir/kmd.token`. Example value: '330b2e4fc9b20f4f89812cf87f1dabeb716d23e3f11aec97a61ff5f750563b78'
        //TODO: Replace the XKMDAPIToken with an appropriate value
        public static string XKMDAPIToken = "";

    }
}