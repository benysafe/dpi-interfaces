using InterfaceLibraryConfigurator;
using InterfaceLibraryPublisher;
using System;
using InterfaceLibraryLogger;

namespace InterfaceLibrarySerializer
{
    public interface ISerializer
    {

        /// <summary>
        /// Inicializa la configuracion y parametros del serializador.
        /// </summary>
        /// <param name="id">Identificador del serializador usado.</param>
        /// <param name="configurator">Objeto que permite acceder a los parametros de configuracion del modulo.</param>
        /// <param name="publisher">Objeto mediante el cual se publicaran los resultados de la serializacion.</param>
        /// <param name="logger">Registrador.</param>
        void init(string id, IConfigurator configurator, IPublisher publisher, IGenericLogger logger);

        /// <summary>
        /// Serializa el mensaje resultante del procesamiento por modulo.
        /// </summary>
        /// <param name="recipient">Nombre del recipiente destino del mensaje.</param>
        /// <param name="payload">Mensaje resultado del procesamiento por el modulo.</param>
        /// <param name="priority">Nivel de prioridad con que debe ser atendido el mensaje resultante por el resipiente.</param>
        void serialize(string recipient, object payload, string priority = null);

    }
}
