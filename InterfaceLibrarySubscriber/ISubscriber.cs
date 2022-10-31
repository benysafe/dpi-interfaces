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
        /// Asigna un suscriptor su correspondiente objeto deserializador.
        /// </summary>
        /// <param name="suscription">Nombre del suscriptor.</param>
        /// <param name="deserializer">Objeto deserializador correspondiente.</param>
        void subscribe(string suscription, IDeserializer deserializer);

        /// <summary>
        /// Inicia el ciclo de espera de los mensajes a procesar por el modulo.
        /// </summary>
        void startLoop();

        /// <summary>
        /// Finaliza el ciclo de espera de los mensajes a procesar por el modulo.
        /// </summary>
        void endLoop();
    }
}
