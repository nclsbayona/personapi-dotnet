﻿using System;
using System.Collections.Generic;

namespace personapi_dotnet.Models.entities;

public partial class Telefono
{
    public string Num { get; set; } = null!;

    public string Oper { get; set; } = null!;

    public int Duenio { get; set; }
}
