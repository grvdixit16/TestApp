using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

    public interface IStackable
    {
        string GetStackableInfo();
    }
    public class GenericsStackImplementation<T> where T : IStackable
    {
        public List<T> stack = new List<T>();

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            var item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }

        public int count => stack.Count;
    }

    public class StackableItem : IStackable
    {
        public string Name { get; set; }
        public string GetStackableInfo()
        {
            return $"Item:{Name}";
        }
    }
}
