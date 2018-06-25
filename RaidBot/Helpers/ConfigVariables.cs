using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Helpers {
   public static class ConfigVariables {
      public static string DebugToken => GetAppConfig("Token.Debug");
      public static string ReleaseToken => GetAppConfig("Token.Release");
      public static string PokemonIconURL => GetAppConfig("PokemonIconURL");
      public static string EggIconURL1 => GetAppConfig("EggIconURL");
      public static string EggIconURL2 => GetAppConfig("EggIconURL2");
      public static string EggIconURL3 => GetAppConfig("EggIconURL3");
      private static string GetAppConfig(string key) => ConfigurationManager.AppSettings[key];
   }
}
