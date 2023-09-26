using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_Builder.Models
{

    public interface IClassModel
    {
        int Id { get; set; }
    }

    public class Pokemon : IClassModel
    {
        public int Id { get; set; }
        
    }

    public class BannedGame : IClassModel
    {
        public int Id { get; set; }
        
    }
}

