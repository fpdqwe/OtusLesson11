namespace OtusLesson11
{
	public static class StackExtensions
	{
		public static Stack Merge(this Stack first, Stack second)
		{
			for(int i = second.Size -1; i >= 0; i--)
			{
				first.Add(second.Pop());
			}
			return first;
		}
	}
}
