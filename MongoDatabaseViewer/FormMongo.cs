using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDatabaseViewer
{
    public partial class FormMongo : Form
    {

        MongoClient client;

        public FormMongo()
        {
            InitializeComponent();
            //starting here: https://www.mongodb.com/docs/guides/crud/install/
            client = GetConnectedMongoClient();
        }

        private MongoClient GetConnectedMongoClient()
        {
            // Replace the uri string with your MongoDB deployment's connection string.
            // mongodb://${CAP_STORAGE_PERSISTENTADDRESS:-mongo_linux}:${CAP_STORAGE_PORT:-27017}
            string mongoConn = "mongodb://localhost:27017";
            return new MongoClient(mongoConn);
        }

        async private void btnGetDatabase_Click(object sender, EventArgs e)
        {

            IAsyncCursor<string> dbNames = await client.ListDatabaseNamesAsync();
            foreach (var dbName in dbNames.ToList())
            {
                lvwDatabase.Items.Add(dbName);
                lvwDatabase.Items.Add("-----------------------------------------------------------------------------------------------------------------------");
                var db = client.GetDatabase(dbName);
                IAsyncCursor<string> collectionNames = await db.ListCollectionNamesAsync();
                foreach (var collName in collectionNames.ToList())
                {
                    var collection = db.GetCollection<BsonDocument>(collName);
                    lvwDatabase.Items.Add(collName);
                    var cursor = collection.AsQueryable();
                    foreach (var document in cursor)
                    {
                        lvwDatabase.Items.Add(document.ToString());
                    }
                    lvwDatabase.Items.Add("");
                }
                lvwDatabase.Items.Add("");
            }
        }

    }
}