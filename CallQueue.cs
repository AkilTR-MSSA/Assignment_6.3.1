using System;

public class CallNode
{
	public CallNode(Caller caller, CallNode next) 
	{
		this.caller = caller;
		this.next = next;
	}
	public Caller caller;
	public CallNode next;
}

public class CallQueue
{
	public CallQueue()
	{
		front = null;
		rear = null;
		size = 0;
	}
	private CallNode front;
	private CallNode rear;
	private int size;
	public int Size { get { return size; } }
    public bool IsEmpty()
    {
        return size == 0;
    }
	public void Enqueue(Caller caller)
	{
		CallNode callNode = new CallNode(caller, null);
		if (IsEmpty())
		{
			front = callNode;
		}
		else
		{
			rear.next = callNode;
		}
		rear = callNode;
		size++;
	}
	public Caller? Dequeue()
	{
		if (IsEmpty())
		{
            Console.WriteLine("Queue is empty!");
			return null;
		}
		Caller caller = front.caller;
		front = front.next;
		size--;
		return caller;
	}
}
