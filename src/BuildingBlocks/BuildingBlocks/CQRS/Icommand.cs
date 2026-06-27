using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    public interface Icommand : Icommand<Unit>
    {
    }
    public interface Icommand<out TResponse> : IRequest<TResponse>
    {
    }
}
