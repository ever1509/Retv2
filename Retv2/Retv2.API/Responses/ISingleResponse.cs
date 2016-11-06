using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.API.Responses
{
    public interface ISingleResponse<TModel>:IResponse
    {
        TModel Model { get; set; }
    }
}
