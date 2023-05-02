namespace SortingExercises
{
    public class Program
    {
        /// <summary>
        /// This function searches through a list entered until a value x is found.
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static int linearSearch(List<int> elements, int x)
        {
            int length = elements.Count;
            for (int i = 0; i < length; i++)
            {
                if (elements[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
       
    }
}