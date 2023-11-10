using StripsBL.Interfaces;
using StripsBL.Model;
using StripsDL.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StripsDL.Repositories
{
    public class StripsRepository : IStripsRepository
    {
        private readonly string connectionString;

        public StripsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Reeks GetReeksDetails(int reeksId)
        {
            string sql = @"
        SELECT 
            r.Id AS ReeksId,
            r.Naam AS ReeksNaam,
            s.Id AS StripId,
            s.Titel AS StripTitel,
            s.Nr AS StripNr
        FROM 
            Reeks r
        LEFT JOIN 
            Strip s ON r.Id = s.Reeks
        WHERE 
            r.Id = @reeksId;
    ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@reeksId", reeksId);

                    Reeks reeks = null;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (reeks == null)
                            {
                                // Set the ID here
                                reeks = new Reeks((int)dr["ReeksId"],(string)dr["ReeksNaam"]);
                            }

                            Strip strip = new Strip((int)dr["StripId"], (string)dr["StripTitel"], dr["StripNr"] != DBNull.Value ? (int?)dr["StripNr"] : null);

                            reeks.Strips.Add(strip);
                        }
                    }

                    return reeks;
                }
                catch (Exception ex)
                {
                    throw new StripsRepositoryException("GetReeksDetails", ex);
                }
            }
        }

    }
}
