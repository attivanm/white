using System;

namespace Northwind.Utils
{
    public static class DataGenerator
    {
        public static string Name => Guid.NewGuid().ToString("N").Substring(1, 15);
        public static int Number => new Random().Next(1000, 10000);
        public static string Random => Guid.NewGuid().ToString("N").Substring(1, 10);
    }
}
