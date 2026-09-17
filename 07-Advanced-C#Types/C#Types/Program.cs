var queue = new Queue<string>();

queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");
queue.Enqueue("d");
queue.Enqueue("e");

var first = queue.Dequeue();
var second = queue.Peek();

var priorityQueue = new PriorityQueue<string, int>();
priorityQueue.Enqueue("a", 5);
priorityQueue.Enqueue("b", 3);
priorityQueue.Enqueue("c", 4);
priorityQueue.Enqueue("d", 2);

var firstPriority = priorityQueue.Dequeue();

Console.ReadKey();