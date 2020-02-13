using System.IO;

namespace PizzaDeliveryBot.Settings
{
    internal static class Environment
    {
        private const string SourceFileName = "ORDERS.TXT";
        private static readonly string SourceFileDirectory = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "DATA";
        internal static string SourceFile = SourceFileDirectory + Path.DirectorySeparatorChar + SourceFileName;
    }
}