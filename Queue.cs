namespace Solution;

public class Queue<T> : IQueue<T>
{
    private int front;
    private int back;
    private T[] data;
    private int _count = 0;

    public bool Empty => Count == 0;
    public bool Full => Count == Size;
    public int Count{get; set; }
    public int Size{get; }

    public Queue(int capacity = 5)
    {
        Size = capacity;
        data = new(capacity);
        back = -1;
        front = -1;
        Count = 0;
    }

    public void Enqueue(T element)
    {
        if (element != null && data.Length > 0){
            front = front < capacity-1 ? front+1 : 0;
            data[front] = element;
            Count++;
        }
        
    }

    public T? Dequeue()
    {
        if (element != null && data.Length > 0){
            back = back < capacity-1 ? back+1 : 0;
            var temp = data[back];
            data[back] = null;
            Count--;
            return temp;
        }
    }

}