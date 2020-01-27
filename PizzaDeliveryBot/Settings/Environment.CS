using System.IO;

namespace PizzaDeliveryBot.Settings
{
    public class Environment   /* Environment Is A Singleton */
    {
        private static readonly string SourceFileDirectory = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "DATA";
        private const string SourceFileName = "ORDERS.TXT";
        public static string SourceFile = SourceFileDirectory + Path.DirectorySeparatorChar + SourceFileName;
    }
}
