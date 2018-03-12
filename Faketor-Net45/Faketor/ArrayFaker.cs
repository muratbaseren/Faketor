namespace Faketor
{
    public static class ArrayFaker
    {
        public static T SelectFrom<T>(params T[] array)
        {
            int num = NumberFaker.Number(0, (int)array.Length);
            return (T)array.GetValue(num);
        }

        public static T[] SelectFrom<T>(int numElements, params T[] array)
        {
            T[] tArray = new T[numElements];
            while (numElements > 0)
            {
                tArray[numElements - 1] = ArrayFaker.SelectFrom<T>(array);
                numElements--;
            }
            return tArray;
        }
    }
}
