var sortedList = new List<int>
{
    1, 4, 6, 7, 8, 10, 21, 24, 29
};
var indexOf1 = sortedList.FindIndexInSorted(1);
var indexOf8 = sortedList.FindIndexInSorted(8);
var indexOf21 = sortedList.FindIndexInSorted(21);
var indexOf4 = sortedList.FindIndexInSorted(4);
var indexOf2 = sortedList.FindIndexInSorted(2);


Console.ReadKey();

public static class ListExtension
{
    public static int? FindIndexInSorted<T>(
        this IList<T> list, T itemToFind) where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = list.Count - 1;
        while(leftBound <= rightBound)
        {
            int middleIndex = (leftBound + rightBound) / 2;
            if (itemToFind.Equals(list[middleIndex]))
            {
                return middleIndex;
            }
            else if(itemToFind.CompareTo(list[middleIndex]) < 0)
            {
                rightBound = middleIndex - 1;
            }
            else
            {
                leftBound = middleIndex + 1;
            }
        }
        return null;
    }
    
}