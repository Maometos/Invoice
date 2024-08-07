﻿using Commerce.Core.Common.Abstractions;

namespace Commerce.Core.Sale.Entities;

public class SalePayment : Payment
{
    public int SaleInvoiceId { get; set; }

    public SaleInvoice SaleInvoice { get; set; } = null!;
}