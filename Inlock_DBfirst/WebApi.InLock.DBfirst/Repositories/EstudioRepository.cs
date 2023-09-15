using Microsoft.EntityFrameworkCore;
using WebApi.InLock.DBfirst.Contexts;
using WebApi.InLock.DBfirst.Domains;
using WebApi.InLock.DBfirst.Interfaces;

namespace WebApi.InLock.DBfirst.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(Guid id, Estudio estudio)
        {
            Estudio estudioBuscado = ctx.Estudios.Find(id);

            if (estudioBuscado != null)
            {
                estudioBuscado.Nome = estudio.Nome;
            }

            ctx.Estudios.Update(estudioBuscado);

            ctx.SaveChanges();
        }

        public Estudio BuscarPorId(Guid id)
        {
            return ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id)!;
        }

        public void cadastrar(Estudio estudio)
        {
            //antes de cadastrar ele irá gerar um guid para o id
            //estudio.IdEstudio = Guid.NewGuid();

            ctx.Estudios.Add(estudio);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Estudio estudioBuscado = ctx.Estudios.Find(id)!;

            ctx.Estudios.Remove(estudioBuscado);

             ctx.SaveChanges();
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos()
        {
            return ctx.Estudios.Include(e => e.Jogos ).ToList();
        }
    }
}
