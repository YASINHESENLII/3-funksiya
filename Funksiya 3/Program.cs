namespace Yasincode
{

    internal class Program
    {


        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Func2(array);
        }
        public static int[] Func2(int[] array)
        {
            int x = 0;
            int[] newArray = new int[x];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j]) i == j)
            {
                newArray[x] = array[i];
                x++;
            }
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(newArray[i]);
            }
            return newArray;
        }

    }
}