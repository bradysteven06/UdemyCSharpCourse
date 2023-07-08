namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defining a queue of integers
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(4);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(5);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());

            while (queue.Count > 0)
            {
                // Dequeue() will return the element that was removed from the queue
                Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
                // print the queue count
                Console.WriteLine("Current queue count is: {0}", queue.Count);
            }

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in RecievedOrdersFromBranch1())
            {
                // add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecievedOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                // remove the order at the front of the queue
                // and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                // process the order
                currentOrder.ProcessOrder();
            }
        }

        static Order[] RecievedOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                // creating new orders array and initializing it with some objects of type Order
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10)
            };
            // return the array of orders that we created
            return orders;
        }

        static Order[] RecievedOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                // creating new orders array and initializing it with some objects of type Order
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10)
            };
            // return the array of orders that we created
            return orders;
        }
    }

    // a class named order that we will store instances of inside a queue
    class Order
    {
        // order Id
        public int OrderId { get; set; }
        // quantity of the order
        public int OrderQuantity { get; set; }

        // simpmle constructor
        public Order(int id, int quantity)
        {
            this.OrderId = id;
            this.OrderQuantity = quantity;
        }

        // print message on the screen that the order was processed
        public void ProcessOrder()
        {
            // print the message
            Console.WriteLine($"Order {OrderId} processed!.");
        }
    }
}