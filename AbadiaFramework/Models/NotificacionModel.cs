using System;
using AbadiaFramework.Notificaciones;
using Newtonsoft;

namespace AbadiaFramework.Models
{

    public class NotificacionModel : INotificacion
    {
        
        /// Todo: mejorar modelo para NewtonJson

        public double ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Sound { get; set; }
        public DateTime FechaLectura { get ; set; }
        public DateTime FechaEnvio { get; set; }
        public bool EsLeido { get; set; }

        public NotificacionModel()
        {
        }

    }
}
