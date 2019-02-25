using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();

            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length ; j++ )
                    if (array[j].Length < array[i].Length)
                    {
                        string elem = array[j];
                        array[j] = array[i];
                        array[i] = elem;
                    }
            }
        }
    }
}