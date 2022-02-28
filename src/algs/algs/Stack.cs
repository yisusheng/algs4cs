namespace algs
{
    class Stack<Item>
    {
        private Node first;
        private int N;
        private class Node
        {
            public Item item;
            Node next;
        }

        public bool isEmpty() { return first == null; }
        public int size() { return N; }
        public void push(Item item)
        {
            Node oldfirst = first;
            first = new Node();
            first.item = item;
        }
    }
}
