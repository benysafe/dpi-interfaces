using InterfaceLibraryConfigurator;
using InterfaceLibrarySerializer;
using System;
using InterfaceLibraryLogger;

namespace InterfaceLibraryProcessor
{
    public interface IProcessor
    {
        /// <summary>
        /// Inicializa la configuracion y parametros del procesador.
        /// </summary>
        /// <param name="configurator">Objeto que permite acceder a los parametros de configuracion del modulo.</param>
        /// <param name="logger">Reistrador </param>
        /// <param name="id">Identificador del procesador usado</param>
        void init(IConfigurator configurator, IGenericLogger logger, string id );

        /// <summary>
        /// Agrega un Objeto de serializacion para que sea usado como mecanismo de salida en el procedor.
        /// </summary>
        /// <param name="serializer">Objeto serializador a agregar.</param>
        void addSerializer( ISerializer serializer);

        /// <summary>
        /// Inicia el procesamiento del mensaje introducido al procesador.
        /// </summary>
        /// <param name="payload">Contendo del mensaje que se debe procesar.</param>
        /// <param name="metadata">Metadato proveniente del suscriptor en caso de ser necesario.</param>
        /// <returns>'true' indicando que se proceso correctamente de lo contrario devuelve 'false'.</returns>
        bool proccess(object payload, object metadata = null);

        /// <summary>
        /// Reconfigura los parametros del procesador
        /// </summary>
        /// <returns>'true' indicando que se reconfiguro correctamente el modulo, de lo contrario devuelve 'false'.</returns>
        bool reConfig();
    }
}
