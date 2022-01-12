namespace algs
{
    class Stack<Item>
    {
        private Node first;
        private int N;
        private class Node
        {
            Item item;
            Node next;
        }

        public bool isEmpty() { return first == null; }
        public int size() { return N; }
    }
}
