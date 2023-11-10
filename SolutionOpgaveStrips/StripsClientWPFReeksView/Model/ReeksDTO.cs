using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsClientWPFReeksView.Model
{
    public class ReeksDTO
    {
        public string Naam { get; set; }
        // Other properties as needed
        public List<StripDTO> Strips { get; set; }
    }
}
