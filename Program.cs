using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Extensions;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.Controllers;
using Tweetinvi.Core.Interfaces.DTO;
using Tweetinvi.Core.Interfaces.Models;
using Tweetinvi.Core.Interfaces.Models.Parameters;
using Tweetinvi.Core.Interfaces.oAuth;
using Tweetinvi.Core.Interfaces.Streaminvi;
using Tweetinvi.Json;
using Stream = Tweetinvi.Stream;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to twitter.com...");
            var jsonResult = SearchJson.SearchTweets("tweetinvi");
            TwitterCredentials.CreateCredentials("490599333-RkRqjA4Icbh0PVyQdllZyoD0Y2S6Cjc5F2eo6Tb6", "727vXKJyQ7bGoTjDNI3gJR5gJ4OUShsJhazaYDDkqs6jt", "XT6Xu6sNxnBxeDODPIawUA", "rI1aWSVDcNN4XnmUofkkaIvbzhTivkL0HSeonleDeZY");
            Console.WriteLine(ExceptionHandler.GetLastException().StatusCode);
            Console.WriteLine(ExceptionHandler.GetLastException().TwitterDescription);
            Console.WriteLine(ExceptionHandler.GetLastException().TwitterExceptionInfos.First().Message);
            Console.ReadKey();
        }
    }
}
