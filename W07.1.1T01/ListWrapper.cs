public class ListWrapper<T>
{
    private List<T> _myList;

    public ListWrapper()
    {
        _myList = new List<T>();
    }

    public void Add(T item)
    {
        _myList.Add(item);
    }

    public T Get(int index)
    {
        return _myList[index];
    }

    public int Count
    {
        get { return _myList.Count; }
    }
}