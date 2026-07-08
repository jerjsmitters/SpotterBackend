using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapping
{
    internal interface IMapper<E, D>
    {
        E ToEntity(D dto);
        D ToDto(E entity);
    }
}
