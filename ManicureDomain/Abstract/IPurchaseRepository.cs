﻿using ManicureDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManicureDomain.Abstract
{
    public interface IPurchaseRepository : IRepository<Purchase>
    {
        ICollection<Purchase> GetByPlace(PurchasePlace place);
        ICollection<Purchase> GetByItem(Item item);
    }
}
