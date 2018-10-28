using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using ClassLibrary;
using Newtonsoft.Json;

namespace RestCustomerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {

            RestHandler handler = new RestHandler();
            IList<Customer> clist = handler.GetCustomers();

            foreach (var c in clist)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

        }
    }
} 
