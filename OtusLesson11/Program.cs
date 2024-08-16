namespace OtusLesson11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task 1
			var stack = new Stack("a","b","c");
			Console.WriteLine($"=====\nStack size: {stack.Size}\nTop = {stack.Top}");

			var deleted = stack.Pop();
			Console.WriteLine($"Извлёк верхний элемент \"{deleted}\"\nStack size = {stack.Size}");

			stack.Add("d");
			Console.WriteLine($"=====\nStack size: {stack.Size}\nTop = {stack.Top}");

			stack.Pop();
			stack.Pop();
			stack.Pop();
			Console.WriteLine($"=====\nStack size: {stack.Size}\nTop = {(stack.Top == null ? "null" : stack.Top)}");


			//Task 2 - Merge method
			stack = new Stack("a","b","c");
			stack.Merge(new Stack("1", "2","3"));
			Console.WriteLine($"=====\nStack size: {stack.Size}\nTop = {stack.Top}");

			//Task 3 - ConcatMethod
			var stack2 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
			Console.WriteLine($"=====\nStack size: {stack2.Size}\nTop = {stack2.Top}");

			//Task 4 - see in Stack.cs
		}
	}
}
