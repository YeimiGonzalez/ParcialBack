using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Dueño
{
    public int IdDueños { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Telefono { get; set; }

    public string? Direccion { get; set; }
}
