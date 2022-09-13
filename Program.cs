using System;

namespace More_Linked_Lists
{
    internal class Program
    {
        //Doubly Linked Lists:
            //Advantage
            //Quicker to go backwards
        //Disadvantage
            //Move memory for the 2nd pointer
            //Code is more complicated
        //Stack ADT
            //Linear Collection
            //Data added and removed from one end <-- called the top
                //older elements near bottom
                //newerr elements near top
            //Operations
            //Push
                //add a value to the top
            //Pop
                //remove item from the top
            //Peek or Top
                //look at value on the top but don't pop it
            //Used extensively in programming languages
            //Example:
                //1. Executing method 1
                    //It has 2 local variables
                //2. Call method 2
                    //push parameter, return address, add space for local variables
            //Implementation Option 1: use OurList
                //1. Push --> call AddFirst
                //2. Pop --> call RemoveFirst
                //3. Peek --> new method that returns first.Data
                //Disadvantages:
                    //1. user can call any list method
            //Implementation oprion #2: linked list version
                class OurStack<T>
                {
                    //.....
                    //private Node top;
                    //public void Push(T value)
                    //{
                        //top = new Node(value, top);
                    //}
                    //public T Pop()
                    //{
                        //if(top == null)
                        //{
                            //throw new ......
                        //}
                        //T RemoveData = top.Data;
                        //top = top.Next;
                        //return removeData;
                    //}
            //Implementation open #3: use an array
                //class OurArrayStack<T>
                //{
                    //private T[] array;
                    //private int top = 0;
                    //public OurArrayStack(int size = 10)
                    //{
                        //if(size <= 0)
                        //{
                            //throw new .....
                        //}
                        //else
                        //{
                            //array = new T[size];
                        //}
                    //}
                    //public void Push(T value)
                    //{
                        //if(top < array.Length)
                        //{
                            //array[top++] = value;
                        //}
                        //else
                        //{
                            //Resize();
                        //}
                    //}
                    //public T Pop()
                    //{
                        //if(top == 0)
                        //{
                            //throw new .....
                        //}
                        //return array[--top];
                    //}
                    //public T Peek()
                    //{
                        //if(top == 0)
                        //{
                            //throw new .....
                        //}
                        //return array[top];
                    //}
                    }
                    
                    //Example app: Palindrome
                    //In main
                    
                        public static void Main(string[] args)
                        {
                            Console.WriteLine("Enter a word.");
                            string word = Console.ReadLine().ToLower();
                            OurStack<char> aStack - new OurStack<char>(50);
                            foreach (char ch in word)
                            {
                                aStack.Push(ch);
                                bool isPal = true;
                                int pos = 0;
                                while (aStack.IsEmpty() == false && isPal == true)
                                {
                                    if (aStack.Pop != word[pos])
                                    {
                                        isPal = false;
                                    }

                                    pos++;
                                }

                                if (aStack.IsEmpty() && isPal == true)
                                {
                                    Console.WriteLine(word + " is a palindrome");
                                }
                                else
                                {
                                    Console.WriteLine(word + " is not a palindrome");
                                }
                            }
                        }
    }
}