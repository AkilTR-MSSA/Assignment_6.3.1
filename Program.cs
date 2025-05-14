Caller caller1 = new Caller("Alex", "(123)456-7890");
Caller caller2 = new Caller("John", "(123)246-8101");
Caller caller3 = new Caller("Mary", "(123)369-1215");
Caller caller4 = new Caller("Sally", "(123)481-2162");
Caller caller5 = new Caller("Sue", "(123)510-1520");

CallQueue callQueue = new CallQueue();
callQueue.Enqueue(caller1);
callQueue.Enqueue(caller2);
callQueue.Enqueue(caller3);
callQueue.Enqueue(caller4);
callQueue.Enqueue(caller5);

Console.WriteLine($"Queue Size: {callQueue.Size}");

while (!callQueue.IsEmpty())
{
    Console.WriteLine(callQueue.Dequeue().ToString());
}

Console.WriteLine($"Queue Size: {callQueue.Size}");
