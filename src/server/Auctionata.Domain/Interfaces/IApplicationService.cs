﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctionata.Domain.Interfaces
{
    public interface IApplicationService
    {
        void Execute(object command);
    }
}
