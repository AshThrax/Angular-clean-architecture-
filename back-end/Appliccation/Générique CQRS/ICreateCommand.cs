using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Générique_CQRS
{
    public interface ICreateCommand<out TEntity> : IRequest<TEntity> where TEntity : class, new() { }
    public abstract class CreateCommandHandler<TEntity, TCommand> : IRequestHandler<TCommand, TEntity>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        protected CreateCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TEntity> Handle(TCommand request, CancellationToken cancellationToken)
        {
           var entity =_mapper.Map<TCommand,TEntity>(request);
            //
           _context.Set<TEntity>()
                .Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
