﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string  RazonSocial { get; set; }
        public int Ruc { get; set; }
        public Usuario oUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoPago { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> oDetalleCompra { get; set; }
        public string FechaRegistro { get; set; }
    }
}
