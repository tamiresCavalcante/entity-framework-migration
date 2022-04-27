using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Domais.Entity
{
    public static class BaseEntity
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
