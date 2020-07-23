using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Vehiculo
    {
        #region Atributos

        private State estado;                 // Estado actual del vehiculo (apagado, parado, en marcha, sin combustible)
        private int velocidadActual = 0;      // Velocidad actual del vehiculo
        private int combustibleActual = 0;    // Cantidad de combustible restante

        #endregion

        #region Properties

        // Asigna o recupera el estado del vehiculo
        public State Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // Asigna o recupera la velocidad actual del vehiculo
        public int VelocidadActual
        {
            get { return velocidadActual; }
            set { velocidadActual = value; }
        }

        // Obtiene la cantidad de combustible actual
        public int CombustibleActual
        {
            get { return combustibleActual; }
        }

        #endregion

        #region Constructores

        //// El constructor inserta el combustible del que dispondra el vehiculo
        //public Vehiculo(int combustible)
        //{
        //    this.combustibleActual = combustible;
        //    //TODO:
        //    //Indicar un estado inicial (Apagado)
        //}

        // El constructor inserta el combustible del que dispondra el vehiculo e instancia el
        // estado inicial (apagado)
        public Vehiculo(int combustible)
        {
            this.combustibleActual = combustible;

            //Indicar un estado inicial (Apagado)
            estado = new ApagadoState(this);
        }

        #endregion

        #region Metodos relacionados con los estados

        // Los metodos del contexto invocaran el metodo de la interfaz State, delegando las operaciones
        // dependientes del estado en las clases que los implementen.
        public void Acelerar()
        {
            estado.Acelerar();
            Console.WriteLine("Velocidad actual: " + velocidadActual + ". Combustible restante: " + combustibleActual);
        }

        public void Frenar()
        {
            estado.Frenar();
        }

        public void Contacto()
        {
            estado.Contacto();
        }

        #endregion

        #region Otros metodos

        public void ModificarVelocidad(int kmh)
        {
            velocidadActual += kmh;
        }

        public void ModificarCombustible(int decilitros)
        {
            combustibleActual += decilitros;
        }

        #endregion
    }
}
