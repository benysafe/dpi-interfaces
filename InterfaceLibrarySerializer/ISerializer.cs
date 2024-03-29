﻿using InterfaceLibraryConfigurator;
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
        /// <param name="logger">Registrador.</param>
        void init(string id, IConfigurator configurator, IGenericLogger logger);

        /// <summary>
        /// Serializa el mensaje resultante del procesamiento por modulo.
        /// </summary>
        /// <param name="mssgType">Tipo de mensaje al que corresponde el payload.</param>
        /// <param name="payload">Mensaje resultado del procesamiento por el modulo.</param>
        /// <param name="priority" value = "["LOW", "NORMAL", "HIGH"]" default= "NORMAL">Nivel de prioridad con que debe ser atendido el mensaje resultante por el resipiente, si no se espesifica se asume "NORMAL"</param>
        void serialize(string mssgType, object payload, string priority = "NORMAL");

        /// <summary>
        /// Agrega un Objeto de publicacion para que sea usado como mecanismo de salida en el serializador.
        /// </summary>
        /// <param name="id">Idenificador del objeto publisher a agregar.</param>
        /// <param name="publisher">Objeto publicador a agregar.</param>
        void addPublisher(string id, IPublisher publisher);

        /// <summary>
        /// Serializa el mensaje resultante del procesamiento por modulo. Pero en este caso ademas recipe por
        /// por parametro el recipiente al que se debe publicar ignorando lo espesificado en el fichero de 
        /// confuguracion funcional, solo es recomendable para serializadores que tienen asociado un unico publicador, 
        /// y ese publicador debe permitir publicar en el recipiente indicado sin tener que rehacer el proceso de inicialización. 
        /// </summary>
        /// <param name="recipent">Recipiente al que se va a publicar el resultado de la serialización.</param>
        /// <param name="payload">Mensaje resultado del procesamiento por el modulo.</param>
        /// <param name="priority" value = "["LOW", "NORMAL", "HIGH"]" default= "NORMAL">Nivel de prioridad con que debe ser atendido el mensaje resultante por el resipiente, si no se espesifica se asume "NORMAL"</param>
        void dynamicSerialize(string recipent, object payload, string priority = "NORMAL");
    }
}
