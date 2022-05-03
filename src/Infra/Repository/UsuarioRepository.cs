using Core_Domain.Interface;
using Core_Domain.Interface.Repository;
using System;

namespace Infra.Repository
{
    public class UsuarioRepository : AbstractRepository<Usuario, int>, IUsuarioRepository
    {
        private readonly GestaoContext _context;

        public UsuarioRepository(GestaoContext context) : base(context)
        {
            _context = context;
        }
    }
}
