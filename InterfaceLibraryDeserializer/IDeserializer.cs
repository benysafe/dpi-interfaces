using InterfaceLibraryProcessor;
using InterfaceLibraryConfigurator;
using System;
using System.Collections.Generic;
using InterfaceLibraryLogger;

namespace InterfaceLibraryDeserializer
{
    public interface IDeserializer
    {
        /// <summary>
        /// Inicializa la configuracion y parametros del deserializador.
        /// </summary>
        /// <param name="id">Identificador del suscriptor usado.</param>
        /// <param name="configurator">Objeto que permite acceder a los parametros de configuracion del modulo.</param>
        /// <param name="logger">Registrador.</param>
        void init(string id, IConfigurator configurator, IGenericLogger logger);
        /// <summary>
        /// Agrega un objeto de procesador.
        /// </summary>
        /// <param name="processor">Objeto procesador a agregar.</param>
        void addProcessor(IProcessor processor);
        /// <summary>
        /// Deserializa el contenifdo de 'payload' para ser procesados por el procesador
        /// <param name="payload">Arreglo de bytes que se debe deserializar para ser procesados</param>
        /// <param name="metaDatas">Diccionario que contiene los metadatos proveidos por el suscriptor en caso de ser necesario, 'null' en casos donde el suscriptor no introduce metadatos para ser procesados</param>
        /// <returns>'true' indicando que la deserializacion y posteriormente procesamiento se completó correctamente, de lo contrario devuelve 'false'.</returns>
        /// </summary>
        bool deserialize( byte[] payload, Dictionary<string,object> metaDatas = null);

    }
}
