﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract  class Producto
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        EMarca marca;
        string codigoDeBarras;
        ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias
        {
            get;
        }

        /// <summary>
        /// Constructor de Producto
        /// </summary>
        /// <param name="patente">Recibe el codigo de barras</param>
        /// <param name="marca">Recibe la marca del producto</param>
        /// <param name="color">Recibe el color del empaque</param>
        protected Producto(string patente, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.codigoDeBarras = patente;
            this.colorPrimarioEmpaque = color;
        }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: ");
            sb.AppendLine(p.codigoDeBarras);
            sb.AppendLine();
            sb.AppendLine("MARCA          : ");
            sb.AppendLine(p.marca.ToString());
            sb.AppendLine();
            sb.AppendLine("COLOR EMPAQUE  : ");
            sb.AppendLine(p.colorPrimarioEmpaque.ToString());
            sb.AppendLine();
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1.codigoDeBarras == v2.codigoDeBarras);
        }

    }
}