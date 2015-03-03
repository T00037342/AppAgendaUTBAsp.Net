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
        public Personas():base()
        {
            this.id = "T000XXXXX" ;
            this.nombre = "Nombre";
            this.apellido = "Apellido";
            this.emailP = "XXXXX@DOMINIO.NET";
            this.emailW = "XXXXX@DOMINIO.NET";
            this.telefonoP = "XXXXXXXXXX";
            this.telefonoW = "XXXXXXXXXx";
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "Id:"+this.id +
                "Nombre: " + this.nombre +
                "Apellido:" +this.apellido+
                "Email:"+this.emailW+
                "Email:" + this.emailP;

        }
        public override bool Equals(object obj)
        {
            Personas c = (Personas)obj;
            bool result = false;
            if (base.Equals(c) &&
               (this.id == c.id)&&
               (this.nombre == c.nombre)&&
               (this.apellido == c.apellido)&&
               (this.telefonoP == c.telefonoP)&&
               (this.telefonoW == c.telefonoW)&&
               (this.emailP == c.emailP)&&
               (this.emailW == c.emailW));
               
            result = true;
            return result;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
    }
}