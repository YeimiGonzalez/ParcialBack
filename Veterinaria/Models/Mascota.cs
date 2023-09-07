using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Mascota
{
    public int IdMascotas { get; set; }

    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public string? Raza { get; set; }

    public string? Color { get; set; }

    public string? Tamaño { get; set; }
}
