using StripsBL.DTOs;
using StripsBL.Exceptions;
using StripsBL.Interfaces;
using StripsBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Managers
{
    public class StripsManager
    {
        private IStripsRepository stripsRepository;

        public StripsManager(IStripsRepository stripsRepository)
        {
            this.stripsRepository = stripsRepository;
        }

       
    }
}
