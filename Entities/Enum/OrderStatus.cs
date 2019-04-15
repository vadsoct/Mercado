using System;
using System.Text;
using System.Globalization;
using System.Collections;
using Mercado.Entities.Enums;
using Mercado.Entities;
using System.Collections.Generic;

namespace Mercado.Entities.Enums
{
    public enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delived = 3
    }
}

    