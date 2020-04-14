using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIN.Services
{
    public interface IVinService
    {
        Task<Models.VIN> GetAsync(string vin);
    }
}
