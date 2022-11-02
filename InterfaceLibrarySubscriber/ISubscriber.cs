using InterfaceLibraryConfigurator;
using InterfaceLibraryDeserializer;
using System;
using InterfaceLibraryLogger;

namespace InterfaceLibrarySubscriber
{
    public interface ISubscriber
    {
        /// <summary>
        /// Inicializa la configuracion y parametros del suscriptor.
        /// </summary>
        /// <param name="id">Identificador del suscriptor usado.</param>
        /// <param name="configurator">Objeto que permite acceder a los parametros de configuracion del modulo.</param>
        /// <param name="logger">Registrador.</param>
        void init(string id, IConfigurator configurator, IGenericLogger logger);

        /// <summary>
        /// Estableces las suscripciones y le asigan a cada una su deserializador correspondiente.
        /// </summary>
        void subscribe();

        /// <summary>
        /// Inicia el ciclo de espera de los mensajes a procesar por el modulo.
        /// </summary>
        void startLoop();

        /// <summary>
        /// Finaliza el ciclo de espera de los mensajes a procesar por el modulo.
        /// </summary>
        void endLoop();
        /// <summary>
        /// Agrega un objeto de deserializador.
        /// </summary>
        /// <param name="id">Idenificador del objeto deserializador a agregar.</param>
        /// <param name="deserializer">Objeto deserializador a agregar.</param>
        void addDeserializer(string id, IDeserializer deserializer);
    }
}
