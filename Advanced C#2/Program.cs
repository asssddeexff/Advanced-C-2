using System.Collections;
using System.Collections.Generic;

namespace Advanced_C_2
{
    internal class Program
    {
        public static void PrintArrayList(ArrayList arraylist)
        {
            Console.WriteLine();
            foreach (int item in arraylist)
            {
                Console.Write($" {item} ");
            }

            Console.WriteLine();


        }

        public static int SumArrayList(ArrayList list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is int) 
                    {
                        Sum += (int)list[i];// UnBoxing [Reference Type ] To [Value Type] - UnSafe
                    }


                   
                }
         
            }
            return Sum;
        }

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($" item");
            }
            Console.WriteLine();
        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    
                    
                        Sum += list[i];
                    



                }

            }
            return Sum;
        }


        public static void PrintLinkedList(LinkedList<int> linkedlist)
        {
            Console.Write("null");
            foreach (int item in linkedlist)
            {
                Console.Write($"<- {item} ->");
            }
            Console.WriteLine("null");
            Console.WriteLine();
        }


        public static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine();
            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }



        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }


        static void Main(string[] args)
        {


            #region What Is Collection
            //Collections:Built-Ds In C#
            //Array : Container

            //Collections In C#
            //Lists 
            //HashTables

            //Generic-Non Generic
            //Lists:
            //Non-Generic Lists : ArrayList - Stack - Queue
            //Generics Lists : List, LinkedList,Stack , Queue

            //HashTables:
            //Non-Generic HashTables : HashTable
            //Generics HashTables: Dictionary - SortedDictionary


            #endregion

            #region Non Generic Lists : ArrayList

            //  //Lists
            //  //Non-Generic Lists : ArrayList


            //  //ArrayList Like Array
            //  //Array Based
            //  //Index


            //  // Array     Indexed Collection : Fixed Size
            //  // ArrayList Indexed Collection : Dynamic Size



            //  //Index : 0 1 2 3 4 5 
            //  //items : 4 5 6 7 8 1
            //  //Size  : 6

            //  //Arr[1] ---> 5

            //  //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };

            //  //Console.WriteLine(Numbers[1]);
            //  //Numbers[1] = 12;
            //  //Console.WriteLine(Numbers[1]);

            //  //ArrayList List = new ArrayList(new int[] {1,2,3,4,5});
            //  //Console.WriteLine($"Count : {List.Count},Capacity:{List.Capacity}");
            //  //List.Add( 6 );
            //  //List.Add(6);
            //  //List.Add(6);
            //  //List.Add(6);
            //  //List.Add(6);
            //  //List.Add(6);
            //  //List.Add(6);
            //  //List.Add(6);
            //  //List.Add(6);
            //  //List.Add(6);
            //  //Console.WriteLine($"Count : {List.Count},Capacity:{List.Capacity}");



            //  //ArrayList List = new ArrayList();
            //  //List.Add( 1 );
            //  //////Console.WriteLine($"Count : {List.Count},Capacity:{List.Capacity}");
            //  //List.Add(2);
            //  //List.Add(3);
            //  //List.Add(4);
            //  //Console.WriteLine($"Count : {List.Count},Capacity:{List.Capacity}");
            //  //List.Add(5);
            //  //Console.WriteLine($"Count : {List.Count},Capacity:{List.Capacity}");
            //  //List.Add(6);
            //  //List.Add(7);
            //  //List.Add(8);
            //  //List.Add(9);
            //  //Console.WriteLine($"Count : {List.Count},Capacity:{List.Capacity}");


            //  //Console.WriteLine(List.IsFixedSize);
            //  ////Console.WriteLine(List.IsReadOnly);
            //  //Console.WriteLine(List[1]);
            //  //List[1] = 12;
            //  //Console.WriteLine(List[1]);


            //  //List.AddRange(new[] { 10, 11, 12 });
            //  //PrintArrayList(List);

            //  ////  int Index = List.BinarySearch(2);
            //  //  int Index = List.BinarySearch(2);


            //  //  Console.WriteLine(Index);

            //  //  Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
            //  //  Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
            //  //  Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 35 };
            //  //  Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 14000, Age = 32 };

            //  //  ArrayList list = new ArrayList();

            //  //  list.AddRange(new Employee[] { E01, E02, E03, E04 });
            //  //  //int Index = list.BinarySearch(new Employee() {Name = "Ali"},new EmployeeComparerName());
            //  //  ////Console.WriteLine($"Index:{Index}");

            //  //int index= list.BinarySearch(0, 2, new Employee() { Name = "Ali" }, new EmployeeComparerName());
            //  //  Console.WriteLine(index);

            //  //  Console.WriteLine("=============");
            //  //  foreach (Employee item in list)
            //  //  {
            //  //      Console.WriteLine(item);
            //  //  }

            //  ArrayList list = new ArrayList();

            //  list.Add(7);
            //  list.Add(2);
            //  list.Add(3);
            //  list.Add(4);
            //  list.Add(9);//4
            //  list.Add(5);//5
            //  list.Add(6);
            //  list.Add(5);
            //  list.Add(8);

            //  //Console.WriteLine($"Count : {list.Count},Capacity:{list.Capacity}");
            //  //list.Clear();
            //  //Console.WriteLine($"Count : {list.Count},Capacity:{list.Capacity}");


            //  //bool flag =list.Contains(20);
            //  //Console.WriteLine(flag);



            //  //int[] Arr = new int[10];
            //  //list.CopyTo( 2,Arr ,3,1);
            //  //foreach (int item in Arr)
            //  //{
            //  //    Console.WriteLine(item);
            //  //}

            //  //ArrayList arrayList = list.GetRange(0, 2);

            //  //foreach (int item in arrayList)
            //  //{
            //  //    Console.WriteLine(item);
            //  //}

            //  //int i = list.IndexOf(5,4,5);
            //  //Console.WriteLine(i);

            //  //list.Insert(0, 100);
            //  //PrintArrayList(list);

            //  // list.InsertRange(0, new int[] { 10, 20, 30, 40 });
            //  //PrintArrayList(list);


            //  //int i = list.LastIndexOf(5);
            //  //Console.WriteLine(i);
            //  //list.Remove(5);
            //  // list.RemoveAt(0);
            //  // list.RemoveRange(0, 3);
            // // list.SetRange(0,new int[] { 1, 2, 3 });
            //// list.Sort();
            ////list.TrimToSize();//Delete | Release

            //  //Console.WriteLine($"Count : {list.Count},Capacity:{list.Capacity}");
            // // PrintArrayList(list); 
            #endregion


            #region Problem With Non Generic Lists [ArrayList]

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //list.Add("Hello World");
            //list.Add(new Employee());
            //list.Add(2.3);



            //int Sum = SumArrayList(list);
            //Console.WriteLine(Sum);

            #endregion

            #region Generic Lists : List
            //  //Generic Lists : List
            //  //List : Version Generic Of ArrayList
            //  //List Like ArrayList Like Array Generic - Dynamic Size

            ////  List<int> list = new List<int>(new int[] { 1, 2, 3, 3 });
            //  List<int> list = new List<int>();

            //  list.Add(1);
            //  list.Add(2);
            //  list.Add(3);
            //  list.Add(4);
            //  // list.Add("Hello World");//Compailer




            //  //PrintList(list);


            //  //int Sum = SumList(list);
            //  //Console.WriteLine(Sum);


            //  //list.AddRange(new List<int> () { 10, 20, 30, 40, 50 });

            //  //list.AsReadOnly();
            //  //int i = list.BinarySearch(20);

            //  //PrintList(list);
            //  //Console.WriteLine(i);





            //  //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
            //  //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
            //  //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 35 };
            //  //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 14000, Age = 32 };


            //  //List<Employee> employees = new List<Employee> {E01,E02,E03,E04 };

            //  //int i = employees.BinarySearch(E01 , new EmployeeComparerName() );
            //  ////Console.WriteLine(i);

            //  //Console.WriteLine($"Count:{list.Count},Capcaity:{list.Capacity}");
            //  //list.EnsureCapacity(10);

            //  //Console.WriteLine($"Count:{list.Count},Capcaity:{list.Capacity}");




            //  //List<int> result = list.GetRange(0, 2);
            //  //PrintList(result);



            //  //list.Sort();
            //  //Console.WriteLine($"Count:{list.Count},Capcaity:{list.Capacity}");

            // // list.TrimExcess();

            //  //Console.WriteLine($"Count:{list.Count},Capcaity:{list.Capacity}"); 
            #endregion

            #region Generic Lists : LinkedList

            // //Generic Lists : LinkedList
            // //LinkedList<>
            // //LinkedList

            //LinkedList<int> Linkedlist = new LinkedList<int>();
            // Linkedlist.AddFirst(1);
            // Linkedlist.AddFirst(2);
            // //Linkedlist.AddLast(1);
            // //Linkedlist.AddLast(2);



            // LinkedListNode<int> node = new LinkedListNode<int>(3);

            // Linkedlist.AddLast(node);
            //// Linkedlist.AddAfter(node, 4);

            // LinkedListNode<int> result = Linkedlist.Find(1);
            // Linkedlist.AddBefore(result, 4);
            // PrintLinkedList(Linkedlist);



            // //Console.WriteLine(Linkedlist.First.Value);
            // //Console.WriteLine(Linkedlist.Last.Value);


            // // Linkedlist.Clear();
            // // Console.WriteLine(Linkedlist.First.Next.Value);
            // Linkedlist.Remove(Linkedlist.First);
            // Linkedlist.Remove(2);
            // Linkedlist.RemoveLast();
            // Linkedlist.Remove(Linkedlist.Last);


            // PrintLinkedList(Linkedlist); 
            #endregion

            #region Generic Lists : Stack

            ////Generic Lists : Stack
            //Stack<int> stack = new Stack<int>();

            ////stack.Push(1);
            ////stack.Push(2);
            ////stack.Push(3);
            ////stack.Push(4);
            ////stack.Push(5);

            ////int top = stack.Pop();
            ////Console.WriteLine(top);

            ////int top = stack.Peek();
            ////  Console.WriteLine(top);

            //// // stack.Peek();
            ////// bool flag = stack.TryPeek( out int top);
            ////stack.Pop();

            //// bool flag = stack.TryPop(out int top);
            //// Console.WriteLine(top);
            //// PrintStack(stack);
            ////  Console.WriteLine(top);

            ////Undo : ctrl + z 
            #endregion

            #region Generic Lists : Queue
            ////Generic Lists : Queue
            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //queue.Dequeue();

            //queue.Peek();

            //PrintQueue (queue); 
            #endregion

        }
    }
}
