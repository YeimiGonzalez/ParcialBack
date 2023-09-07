using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Comidum
{
    public int IdComida { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public int? Precio { get; set; }

    public string? Marca { get; set; }
}
