using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public int Credit { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual Register Register { get; set; }
    }
}
