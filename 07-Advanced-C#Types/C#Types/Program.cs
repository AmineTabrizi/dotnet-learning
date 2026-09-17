var stack = new Stack<string>();
stack.Push("a");
stack.Push("b");
stack.Push("c");

var top = stack.Pop();
var secondToTop = stack.Peek();

Console.ReadKey();