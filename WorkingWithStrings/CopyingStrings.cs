using System;

#pragma warning disable CA1062
#pragma warning disable SA1615
#pragma warning disable SA1611

namespace WorkingWithStrings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 0, source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, destination.IndexOf('*', StringComparison.CurrentCultureIgnoreCase), source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(2, destinationArray, Array.IndexOf(destinationArray, '*'), 6);

            return new string(destinationArray);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            char[] templateArray = template.ToCharArray();

            regionCode.CopyTo(1, templateArray, Array.IndexOf(templateArray, '*'), 1);

            locationCode.CopyTo(4, templateArray, Array.IndexOf(templateArray, '*'), 2);

            dateCode.CopyTo(3, templateArray, Array.IndexOf(templateArray, '*'), 3);

            factoryCode.CopyTo(2, templateArray, Array.IndexOf(templateArray, '*'), 4);

            return new string(templateArray);
        }
    }
}
