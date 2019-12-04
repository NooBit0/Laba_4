using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Laba4
{
    internal static class FileExtensions
    {
        public static IEnumerable<Collection.AgronomistRecord> GetFromFile()
        {
            try
            {
                using (var reader = new StreamReader(@"..\..\..\FileExtensions\collection.csv"))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.RegisterClassMap<CollectionMap>();
                    return csv.GetRecords<Collection.AgronomistRecord>().ToArray();
                }
            }
            catch (FileNotFoundException massage)
            {
                Console.WriteLine(massage.Message);
                return null;
            }
        }

        internal static void RecordToFile(Collection.AgronomistRecord[] arr)
        {
            try
            {
                using (var writer = new StreamWriter(@"..\..\..\FileExtensions\collection.csv"))
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(arr);
                }
            }
            catch (DirectoryNotFoundException massage)
            {
                Console.WriteLine(massage.Message);
            }
        }
    }
}
