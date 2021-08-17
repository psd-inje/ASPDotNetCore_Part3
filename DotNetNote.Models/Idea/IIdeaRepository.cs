using System.Collections.Generic;

namespace DotNetNote.Models
{
    public interface IIdeaRepository
    {
        /// <summary>
        /// 출력
        /// </summary>
        List<Idea> GetAll();

        /// <summary>
        /// 입력
        /// </summary>
        Idea Add(Idea model);
    }
}
