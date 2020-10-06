using System;
namespace AbadiaFramework.Models.Agenda
{
    public class TelefonoModel
    {
        public int id { get; set; }
        public string numero {get; set; }
        public string tipo { get; set; } // Celular, Fino
        public string lada { get; set; } // clave lada




        public TelefonoModel()
        {
        }
    }
}
