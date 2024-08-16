namespace OtusLesson11
{
	public class Stack
	{
		private List<StackItem> _items;

        public int Size {  get { return _items.Count; } }
        public string Top
        {
            get
            {
                if (_items == null || _items.Count == 0) return null;
                return _items.Last().Value;
            }
        }

        public Stack()
        {
            _items = new List<StackItem>();
        }
        public Stack(params string[] values)
        {
            _items = StackItem.ArrayToItems(values);
        }

        public void Add(string value)
        {
            _items.Add(new StackItem() { Value = value, PreviousItem = _items.Count == 0 ? null : _items.Last() });
            //Console.WriteLine($"To stack {this} added new StackItem with value {value}");
        }

        public string Pop()
        {
            if (_items == null || _items.Count == 0) return "Стек пустой";
            var result = _items.Last();
            _items.Remove(result);
            return result.Value;
        }
        public static Stack Concat(params Stack[] values)
        {
            var result = new Stack();
            foreach(var value in values)
            {
                result.Merge(value);
            }
            return result;
        }


        //Task 4 - StackItem
        private class StackItem()
        {
            public string? Value { get; set; }
            public StackItem? PreviousItem { get; set; }

            public static List<StackItem> ArrayToItems(IList<string> strings)
            {
                var result = new List<StackItem>();
                for (int i = 0; i < strings.Count(); i++)
                {
                    if (i == 0) result.Add(new StackItem() { Value = strings[i], PreviousItem = null });
                    else result.Add(new StackItem() { Value = strings[i], PreviousItem = result[i - 1] });
                }
                return result;
            }
        }
    }
}
