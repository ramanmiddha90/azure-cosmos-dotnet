using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

namespace CosmosDbClient
{
    public class CosmosClientHelper
    {
        readonly string DataBaseId = "Airline";
        readonly string ContainerName = "AirlineData";

        private Database database;

        private Container container;
        public async Task InitializeCosmosDB(CosmosClient client)
        {
            this.database = client.GetDatabase(DataBaseId);
            //  client.ClientOptions.ConnectionMode = ConnectionMode.Gateway;

            await InitializeContainer();
        }

        public async Task InitializeContainer()
        {
            //this.container =  database.GetContainer(ContainerName);

            await Task.Run(() =>
            {

                //ContainerProperties containerProperties = new ContainerProperties()
                //{
                //    Id = Guid.NewGuid().ToString(),
                //    PartitionKeyPath = "/pk",
                //    IndexingPolicy = new IndexingPolicy()
                //    {
                //        Automatic = false,
                //        IndexingMode = IndexingMode.Lazy,
                //    }
                //};
                this.database.GetContainer(ContainerName);
            });
        }
        public async Task RunItemsDemo()
        {

        }

        public async Task Cleanup()
        {

        }


    }
}
