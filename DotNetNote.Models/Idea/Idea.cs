using System.ComponentModel.DataAnnotations;

namespace DotNetNote.Models
{
    public class Idea
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 노트
        /// </summary>
        [Required]
        public string Note { get; set; }
    }
}
