using System;

namespace Laba4
{
    internal class CreateItem
    {
        private const int _rightBorder = 12;

        public static Collection.AgronomistRecord CreateNewItem()
        {
            string nameCulture, nameFertilizer;
            int applicationRate, dateEntry, сontentInVolume;

            Console.WriteLine("Input name culture");
            nameCulture = InputExtensions.InputStringVariable();

            Console.WriteLine("Input name fertilizer");
            nameFertilizer = InputExtensions.InputStringVariable();

            Console.WriteLine("Input application rate");
            applicationRate = InputExtensions.InputVariable();

            Console.WriteLine("Input date entry (0-12)");
            dateEntry = InputExtensions.InputIntVariable(_rightBorder);

            Console.WriteLine("Input content in Volume");
            сontentInVolume = InputExtensions.InputVariable();

            return new Collection.AgronomistRecord(nameCulture, nameFertilizer, applicationRate, dateEntry, сontentInVolume);
        }
    }
}
