using System;

namespace GenericApplication
{

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class AgList<T>
    {
        public Node<T> Head { get; private set; }
        private Node<T> tail;

        public AgList()
        {
            Head = tail = null;
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Head == null)
                Head = tail = newNode;
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void ForEach(Action<T> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            Node<T> current = Head;
            while (current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }

        public double Sum(Func<T, double> selector)
        {
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            double sum = 0;
            Node<T> current = Head;
            while (current != null)
            {
                sum += selector(current.Data);
                current = current.Next;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            AgList<int> intList = new AgList<int>();
            for (int x = 0; x < 10; x++)
            {
                intList.Add(random.Next(1000));
            }

            intList.ForEach(n => Console.Write(n + "\t"));
            Console.WriteLine();

            double min = intList.Head == null ? double.NaN : intList.Sum(n => n);
            double max = min;
            double sum = 0;
            intList.ForEach(n => {
                min = Math.Min(min, n);
                max = Math.Max(max, n);
                sum += n;
            });

            Console.WriteLine($"min={min}, max={max}, sum={sum}");

            sum = intList.Sum(n => n);
            Console.WriteLine("sum=" + sum);

            AgList<String> strList = new AgList<String>();
            strList.Add("a");
            strList.Add("bc");
            strList.Add("def");
            double totalLen = strList.Sum(s => s.Length);
            Console.WriteLine("totalLen=" + totalLen);
        }
    }

}