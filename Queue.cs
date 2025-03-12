namespace Solution;

public class Queue<T> : IQueue<T>
{
    private int front;
    private int back;
    private T[] data;
    private int _count = 0;

    public bool Empty => throw new NotImplementedException();
    public bool Full => throw new NotImplementedException();
    public int Count => throw new NotImplementedException();
    public int Size => throw new NotImplementedException();

    public Queue(int capacity = 5)
    {
        throw new NotImplementedException();
    }

    public void Enqueue(T element)
    {
        throw new NotImplementedException();
    }

    public T? Dequeue()
    {
        throw new NotImplementedException();
    }

}