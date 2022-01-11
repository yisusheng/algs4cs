namespace algs
{
    class FixedCapacityStackOfStrings<Item>
    {
        private Item[] a;
        private int N;
        public FixedCapacityStackOfStrings(int cap)
        { a = new Item[cap]; }
        public bool isEmpty() { return N == 0; }
        public int size() { return N; }
        public void push(Item item)
        { a[N++] = item; }
        public Item pop()
        { return a[N--]; }
    }
}
