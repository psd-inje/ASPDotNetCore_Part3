using System.Collections.Generic;
using System.Linq;

namespace DotNetNote.Models
{
    public class IdeaRepositoryEF : IIdeaRepository
    {
        private readonly IdeaContext _context;

        public IdeaRepositoryEF(IdeaContext context)
        {
            this._context = context;
        }

        public Idea Add(Idea model)
        {
            _context.Ideas.Add(model);
            _context.SaveChanges();

            return model;
        }

        public List<Idea> GetAll()
        {
            //var ideas = new List<Idea>();
            //{
            //    ideas = _context.Ideas.ToList();
            //}
            //return ideas;


            return _context.Ideas.ToList();
        }
    }
}
