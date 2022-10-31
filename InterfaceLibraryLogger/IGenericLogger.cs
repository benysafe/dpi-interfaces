using System;


namespace InterfaceLibraryLogger
{
    public interface IGenericLogger
    {
        /// <summary>
        /// Carga la configuracion definida para hacer los registros definidos.
        /// </summary>
        /// <param name="logConfigPath">Ruta del fichero de configuracion donde esta definida la configuracion para hacer registros definidos</param>
        void loadConfig(string logConfigPath);
        /// <summary>
        /// Inicializa el registrador asignandole un nombre. 
        /// </summary>
        /// <param name="loggerName">Nombre que se le asigna al registrador, debe coincidir con el nobre definido en el ficgero de configuracion de logs</param>
        /// <returns>Devuelve una instancia al registrador inicializado, el resultado debe ser casteado al tipo de dato unsado por el registrador definido. </returns>
        object init(string loggerName = null);
    }
}
