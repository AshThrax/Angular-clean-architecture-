using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ActualitéCQRS.Command
{
    public class UpdateActualité : IRequest<ActualitéDto>
    {
    }
    public class UpdateActualitéCommand
    {
        public UpdateActualitéCommand()
        {
        }
    }
}
