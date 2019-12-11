using AlgodRESTAPI.Standard.Models;
namespace AlgodRESTAPI.Standard
{
    public partial class Configuration
    {


        //The base Uri for API calls
        public static string BaseUri = "http://localhost";

        //Generated header parameter. This token can be generated using the Goal command line tool. Example value ='b7e384d0317b8050ce45900a94a1931e28540e1f69b2d242b424659c341b4697'
        //TODO: Replace the XAlgoAPIToken with an appropriate value
        public static string XAlgoAPIToken = "";

    }
}