using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ClassLibrary;
using Newtonsoft.Json;

namespace RestCustomerConsumer
{
    class RestHandler
    {
        private string _customerUri = "http://localhost:59448/api/Customer";
        public IList<Customer> GetCustomers()
        {
            //create an instance of a HTTTPClient which can handle the request wth using it will close by itself 
            using (HttpClient client = new HttpClient())
            {
                //create an instane of a stringtype which takes the Httpclient and calls a method to get a value, it takes one parameter,
                //which is the REST uri location 
                string content = client.GetStringAsync(_customerUri).Result;
                //create a instance of a list which takes the type Customer from library, the JsonConvert method deserializes the jason object and 
                //output it to the system 
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }
    }
}
