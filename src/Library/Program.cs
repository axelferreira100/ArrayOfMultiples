namespace Library
{
    public class Program
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = (num * (i + 1));
            }
            return multiples;
        }
    }
}