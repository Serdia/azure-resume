using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Company.Function
{
    public static class GetResumeCounter
    {
        [FunctionName("GetResumeCounter")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            // this first binding is gonna allow us to retrieve an item that has id=1
            // it's gonna connect to database using "AzureResumeConnectionString"
            // it's gonna look for that item in collection (container) named  "Counter" inside of the db named "AzureResume"
            [CosmosDB(databaseName:"AzureResume", collectionName: "Counter", ConnectionStringSetting = "AzureResumeConnectionString", Id = "1", PartitionKey = "1")] Counter counter,
            // now add another binding that will be used for "output" result. 
            // first we retrive an item, then we need to add 1 to increase additional visit and output that number to a database
            [CosmosDB(databaseName:"AzureResume", collectionName: "Counter", ConnectionStringSetting = "AzureResumeConnectionString", Id = "1", PartitionKey = "1")] out Counter updatedCounter,
            

            ILogger log)
        {
            // here is where the ounter gets updated!!
            log.LogInformation("C# HTTP trigger function processed a request.");
            // ** now we need to retrieve the counter, update the counter and return it as json

            // set updated counter object be the same as counter jbject
            updatedCounter = counter;
            // updatedCounter is the one that will be returned to the database to update the count information
            updatedCounter.Count += 1;
            // now structure the json that we want to return. so this is what we'll see in a browser
            var jsonToRetun = JsonConvert.SerializeObject(counter);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(jsonToRetun, Encoding.UTF8, "application/json")
            };
        }
    }
}
