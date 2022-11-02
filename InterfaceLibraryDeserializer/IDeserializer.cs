using InterfaceLibraryProcessor;
using InterfaceLibraryConfigurator;
using System;
using System.Collections.Generic;
using InterfaceLibraryLogger;

namespace InterfaceLibraryDeserializer
{
    public interface IDeserializer
    {

        void init(string id, IConfigurator configurator, IGenericLogger logger);

        void addProcessor(string processorName, IProcessor processor);

        void deserialize(string processorName, byte[] payload, Dictionary<string,object> metaDatas = null);

    }
}
