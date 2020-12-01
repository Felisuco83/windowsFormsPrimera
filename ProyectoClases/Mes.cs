﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        public Mes(string nombre, int maxima, int minima) {
            this.Nombre = nombre;
            this.Maxima = maxima;
            this.Minima = minima;
            this.Media = (maxima + minima) / 2;
        }
        #region properties
        public string Nombre { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }
        public double Media { get; set; }
        #endregion
    }
}
