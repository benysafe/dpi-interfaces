using InterfaceLibraryConfigurator;
using InterfaceLibraryLogger;
using System;

namespace InterfaceLibraryPublisher
{
    public interface IPublisher
    {
        /// <summary>
        /// Inicializa la configuracion y parametros del publicador.
        /// </summary>
        /// <param name="id">Identificador del publicador usado.</param>
        /// <param name="configurator">Objeto que permite acceder a los parametros de configuracion del modulo.</param>
        /// <param name="logger">Registrador.'</param>
        void init(string id, IConfigurator configurator, IGenericLogger logger);

        /// <summary>
        /// Publica el mensaje resultante de la serializacion del mensajeresultante del procesamiento por modulo.
        /// </summary>
        /// <param name="recipient">Nombre del recipiente destino del mensaje.</param>
        /// <param name="payload">Mensaje resultado de la serializacion por el modulo.</param>
        /// <param name="priority" value = "["LOW", "NORMAL", "HIGH"]" default= "NORMAL">Nivel de prioridad con que debe ser atendido el mensaje resultante por el resipiente, si no se espesifica se asume "NORMAL"</param>
        /// <returns>'true' si la publicacion ocurrio con exito, de lo contrario 'false'</returns>
        bool publish(string recipient, byte[] payload, string priority = "NORMAL");
    }
}
