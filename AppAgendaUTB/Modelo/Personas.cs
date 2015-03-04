using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAgendaUTB
{
    public class Personas
    {
        #region "Atributos"
        private string id;
        private string nombre;
        private string apellido;
        private string emailP;
        private string emailW;
        private string telefonoP;
        private string telefonoW;
        #endregion

        #region "Propiedades"
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string EmailP
        {
            get { return emailP; }
            set { emailP = value; }
        }
        public string EmailW
        {
            get { return emailW; }
            set { emailW = value; }
        }
        public string TelefonoP
        {
            get { return telefonoP; }
            set { telefonoP = value; }
        }
        public string TelefonoW
        {
            get { return telefonoW; }
            set { telefonoW = value; }
        }
        #endregion

        #region "Costructores"
        public Personas(string id, string nombres, string apellidos, string emailP, string emailW, string telefonoP, string telefonoW)
        {
            this.id = id;
            this.nombre = nombres;
            this.apellido = apellidos;
            this.emailP = emailP;
            this.emailW = emailW;
            this.telefonoP = telefonoP;
            this.telefonoW = telefonoW;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "\n_______________________________________" +
            "\nIdentificacion: " + this.id +
            "\nNombres: " + this.nombre +
            "\nApellidos: " + this.apellido +
            "\nEmail P: " + this.emailP +
            "\nEmail W: " + this.emailW +
            "\nTelefono P: " + this.telefonoP +
            "\nTelefono W: " + this.telefonoW +
            "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Personas o = (Personas)obj;
            bool result = false;
            if ((this.id == o.id) &&
                (this.nombre == o.nombre) &&
                (this.apellido == o.apellido) &&
                (this.emailP == o.emailP) &&
                (this.emailW == o.emailW) &&
                (this.telefonoP == o.telefonoP) &&
                (this.telefonoW == o.telefonoW))
           
                result = true;

            return result;
        }
        #endregion
    }
}