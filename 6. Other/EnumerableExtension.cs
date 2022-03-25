using ClassLibrary;

public static class EnumerableExtension
{
    // Custom method for collection of students
    public static IEnumerable<Student> WhereAbove21(this IEnumerable<Student> query)
    {
        return query.Where((student) => student.Age > 21);
    }

    // Custom method for counting items in collection
    public static int CustomCountItems(this IEnumerable<Student> query)
    {
        int amountOfItems = query.Count();
        return amountOfItems;
    }

    // Generic custom method that removes first three elements
    public static IEnumerable<T> RemoveFirstThree<T>(this IEnumerable<T> query)
    {
        int index = 0;
        foreach (T element in query)
        {
            if (index >= 3)
            {
                yield return element;
            }

            index++;
        }
    }
}
