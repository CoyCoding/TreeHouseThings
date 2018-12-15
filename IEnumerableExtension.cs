static class EnumerableUtil
{
    public static EnumerableUtil<T> Create<T>(params IEnumerable<T>[] collection)
    {
        return new EnumerableUtil<T>(collection);
    }  
}

class EnumerableUtil<T> : Ienumerable<T>
{
    private List<IEnumerable<T>> _collections;
    
    public EnumerableUtil(){
        _collections = new List<IEnumerable<T>>();
    }

    public EnumerableUtil(IEnumerable<IEnumerable<T>> collections)
    {
        _collections = collections.ToList();
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        foreach(var collection in _collections)
        {
            foreach(var item in collection)
            {
                yield return item;
            }
        }
    }
    
    IEnumerator Ienumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
