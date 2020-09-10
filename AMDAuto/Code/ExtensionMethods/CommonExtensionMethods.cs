using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code.ExtensionMethods
{
    public static class CommonExtensionMethods
    {
        public static byte[] GetBytes(this IFormFile form)
        {
            if (form == null)
                return null;

            using(var stream = new MemoryStream())
            {
                form.CopyTo(stream);

                return stream.ToArray();
            }
        }
    }
}
