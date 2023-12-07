using InterfaceLibraryLogger;
using System;
using System.Collections.Generic;

namespace InterfaceLibraryConfigurator
{
    public interface IConfigurator
    {
        /// <summary>
        /// Inicializa la los parametros necesarios para el funcionamiento.
        /// </summary>
        /// <param name="logger">Registrador usado en la biblioteca.</param>
        void init(IGenericLogger logger);

        /// <summary>
        /// Carga la configuracion funcional desde un fichero externo.
        /// </summary>
        /// <param name="path">Ruta del fichero de configuracion a cargar.</param>
        void load(string path);
        
        /// <summary>
        /// Obtiene el mapa solicitado de la configuracion.
        /// </summary>
        /// <param name="masterKey">Llave asociada al valor en la configuracion que se quiere obtener.</param>
        /// <param name="id">Identificador del que se quiere obtener su configuracion.</param>
        /// <returns>Un mapa de tipo Dictionary<string, object> con toda la configuracion solicitada, manteniendo la estructura definida en el fichero de configuracion</returns> 
        Dictionary<string, object> getMap(string masterKey, string id = null);
        
        /// <summary>
        /// Obtiene el valor solicitado de la configuracion.
        /// </summary>
        /// <param name="masterKey">Llave asociada al valor en la configuracion que se quiere obtener.</param>
        /// <param name="id">Identificador del que se quiere obtener su configuracion.</param>
        /// <returns>Una cadena con toda la configuracion solicitada, manteniendo la estructura definida en el fichero de configuracion</returns>
        string getValue(string masterKey, string id = null);
        
        /// <summary>
        /// Agrega un parametro a la configuracion del procesador.
        /// </summary>
        /// <param name="parameter">Valor que se quiere agregar a la configuracion.</param>
        /// <param name="key">Llave asociada al valor en la configuracion que se quiere agregar.</param>
        void addParameter(string parameter, string key);

        /// <summary>
        /// Verifica si corresponde o no realizar una reconfiguración de los parámetros del fichero.
        /// </summary>
        /// <returns>Un booleano en 'true' indicando que se debe reconfigurar los parámetros desde fichero, de lo contrario devuelve 'false'</returns>
        bool hasNewConfig();
    }
}
