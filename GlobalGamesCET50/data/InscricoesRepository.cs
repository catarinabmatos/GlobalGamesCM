using GlobalGamesCET50.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.data
{
    public class InscricoesRepository : GenericRepository<Inscricoes>, IInscricoesRepository
    {
        public InscricoesRepository(DataContext context) : base(context)
        {

        }
    }
}
