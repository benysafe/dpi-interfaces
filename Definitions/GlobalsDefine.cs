
namespace Definitions
{
    public class App
    {
        public const string Module = "module";
        public const string Name = "name";
        public const string Id = "id";
        public const string Config = "configurator";
        public const string PathConfig = "pathConfig";
        public const string PathLibrary = "libraryPath";
        public const string Logger = "logger";
        public const string Subscriptions = "subscriptions";
        public const string Deserializer = "deserializer";
        public const string Processor = "processor";
        public const string Serializers = "serializers";
        public const string Publisher = "publisher";
    }
    public class Config
    {
        public const string Module = "module";
        public const string Name = "name";
        public const string Id = "id";
        public const string Subscriptors = "subscriptors";
        public const string Processor = "processors";
        public const string Publishers = "publishers";
        public const string Host = "host";
        public const string Port = "port";
        public const string Function = "function";
        public const string Priority = "Priority";
        public const string WorkerName = "workerName";
        public const string QueueName = "queueName";
        public const string TopicName = "topicName";
        public const string ConcurrentThread = "concurrentThread";
        public const string Uri = "uri";
        public const string ActiveMQTypeOut = "amqTypeOut";

        public enum GearmanClientPriorityTask { HIGH, NORMAL, LOW }

    }

    #region JsonMaker
    //Arbol de clases que describen el fichero Json conformador del modulo 


    public class ModuleMakerConfig
    {
        public Module module { get; set; }
        public Configurator configurator { get; set; }
        public Genericlogger genericLogger { get; set; }
        public Subscription[] subscriptions { get; set; }
    }

    public class Module
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Configurator
    {
        public string libraryPath { get; set; }
        public string pathConfig { get; set; }
    }

    public class Genericlogger
    {
        public string libraryPath { get; set; }
        public string pathConfig { get; set; }
    }

    public class Subscription
    {
        public string id { get; set; }
        public string name { get; set; }
        public string function { get; set; }
        public string libraryPath { get; set; }
        public Deserializer deserializer { get; set; }
    }

    public class Deserializer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string libraryPath { get; set; }
        public Processor processor { get; set; }
    }

    public class Processor
    {
        public string id { get; set; }
        public string name { get; set; }
        public string libraryPath { get; set; }
        public Serializer[] serializers { get; set; }
    }

    public class Serializer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string libraryPath { get; set; }
        public Publishers publishers { get; set; }
    }

    public class Publishers
    {
        public string id { get; set; }
        public string name { get; set; }
        public string libraryPath { get; set; }
    }


    #endregion JsonMaker

}


