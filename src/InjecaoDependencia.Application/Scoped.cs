using InjecaoDependencia.Application.Interfaces;

namespace InjecaoDependencia.Application
{
    public class Scoped : IScoped
    {
        private readonly Guid valor;
        public Scoped()
        {
            valor = Guid.NewGuid();
        }

        public Guid ObterScoped()
        {
            return valor;
        }
    }
}
