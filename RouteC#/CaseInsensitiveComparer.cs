using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        int IComparer<string>.Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}
