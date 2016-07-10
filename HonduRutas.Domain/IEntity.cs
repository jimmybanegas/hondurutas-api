using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Domain
{
    /// <summary>
    /// Define comportamiento que deben exponer todas las entidades.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Verifica si las propiedades de la Entidad son validas.
        /// Por consiguiente evalua si la entidad misma es valida.
        /// </summary>
        /// <param name="erroresValidacion">Una lista donde se almacenarán los errores que se encuentren.</param>
        /// <returns>True si la entidad es válida, False de lo contrario.</returns>
        bool IsValid(out ICollection<string> erroresValidacion);
    }
}
