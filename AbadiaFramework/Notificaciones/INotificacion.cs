using System;
namespace AbadiaFramework.Notificaciones
{
    public interface INotificacion
    {
        /// <summary>
        /// ID  double valor del identificador de notificación
        /// </summary>
         double ID { get; set; }

        /// <summary>
        /// Title  string del titulo a usar en la notificación
        /// </summary>
         string Title { get; set; }

        /// <summary>
        /// Description string con la descripción del mensaje que leera el usuario al ver la notificación
        /// </summary>
         string Description { get; set; }

        //Todo: implementar data values de android e IOS

        /// <summary>
        /// Icon   string del resouce que usara para mostrar la notificación
        /// </summary>
        string Icon { get; set; }

        /// <summary>
        /// Sound  string del sonido de la notificación  
        /// </summary>
        string Sound { get; set; }

        /// <summary>
        /// FechaEnvio  DateTime con la fecha de envio desde el servidor 
        /// </summary>
        DateTime FechaEnvio { get; set; }

        /// <summary>
        /// FechaLectura DateTime  fecha en que se vio la notificación
        /// </summary>
        DateTime FechaLectura { get; set;  }

        /// <summary>
        /// EsLeido  bool del estado para identificar si el usuario lo leyo
        /// </summary>
        bool  EsLeido { get; set; }


    }
}
