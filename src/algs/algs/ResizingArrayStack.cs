using System.Collections.Generic;

namespace algs
{
    class ResizingArrayStack<Item>//:IEnumerable<Item>
    {
        private Item[] a = new Item[1];
        private int N = 0;
        public bool isEmpty() { return N == 0; }
        public int size() { return N; }
        private void resize(int max)
        {
            Item[] temp = new Item[max];
            for (int i = 0; i < N; i++)
                temp[i] = a[i];
            a = temp;
        }
        public void push(Item item)
        {
            if (N == a.Length) resize(2 * a.Length);
            a[N++] = item;
        }
        public Item pop()
        {
            Item item = a[--N];
            if (N > 0 && N == a.Length / 4) resize(a.Length / 2);
            return item;
        }
        //public IEnumerator<Item> GetEnumerator()
        //{

        //}
        
    }
}
