
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
}


