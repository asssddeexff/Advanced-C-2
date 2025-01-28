using System.Collections;

namespace Assignment
{
    internal class Program
    {


        static void ReverseQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (int item in queue)
            {
                Console.Write($" {item} ");
            }

            Console.WriteLine();

        }


        static void CheckParentheses()
        {

        }

        public static void PrintArrayList(ArrayList arraylist)
        {
            Console.WriteLine();
            foreach (int item in arraylist)
            {
                Console.Write($" {item} ");
            }

            Console.WriteLine();


        }



        public static void PrintQueue(Queue<object> queue)
        {
            Console.WriteLine();
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }




        public static void PrintStack(Stack<int> stack)
        {
            int Count = 0;
            if (stack.Count > 0)
            {
                foreach (int item in stack)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Target is found");
            }
            return ;
        }

        static void Main(string[] args)
        {
            #region Q3
            //Queue<int> queue = new Queue<int>(new int[] {1,2,3,4} );

            // ReverseQueue(queue);
            // Stack<int> stack = new Stack<int>();
            // stack.Reverse( );
            // ReverseQueue(queue); 
            #endregion
            #region Q5

            //int[] Numbers = {1,1,3,3,5,5,7,8};
            //ArrayList List = new ArrayList(new int[] { 1, 1, 3, 3, 5,5,7,8 });
            //PrintArrayList(List);

            #endregion

            #region Q7

            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //PrintQueue(queue); 
            #endregion
            #region Q8

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine("Enter the target ");

            //int target= int.Parse (Console.ReadLine());
            //PrintStack(stack); 
            #endregion





        }
    }
}
