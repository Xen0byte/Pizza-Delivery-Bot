using System.IO;

namespace PizzaDeliveryBot.Settings
{
    public static class Environment
    {
        private const string SourceFileName = "ORDERS.TXT";
        private static readonly string SourceFileDirectory = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "DATA";
        public static string SourceFile = SourceFileDirectory + Path.DirectorySeparatorChar + SourceFileName;
    }
}