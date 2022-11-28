﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
    class stack  
    {
        node top;
        public stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
            {
                return true;
            }
            else
                return false;
        }
        public void push(int element)
        {
            node fresh;
            fresh = new node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed");
        }
        public void pop()
        {
            Console.WriteLine("\nThe poped elements is: " + top.info);
            top = top.next; // make top point to the next node in squence
        }
        public void display()
        {
            node tmp;
            if (empty())
                Console.WriteLine("\nStack empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            stack s = new stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n---Stack menu---");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':

                        break;
                }
            }
        }
    }
}