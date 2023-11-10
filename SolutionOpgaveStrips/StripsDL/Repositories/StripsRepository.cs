using StripsBL.DTOs;
using StripsBL.Interfaces;
using StripsBL.Model;
using StripsDL.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Repositories
{
    public class StripsRepository : IStripsRepository
    {
        private string connectionString;

        public StripsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }        
    }
}
