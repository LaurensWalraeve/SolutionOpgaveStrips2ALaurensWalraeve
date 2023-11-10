using StripsBL.Model;
using StripsREST.Model.Output;
using System.Linq;

namespace StripsREST.Mappers
{
    public static class ReeksMapper
    {
        public static ReeksDTO MapToReeksDTO(Reeks reeks)
        {
            return new ReeksDTO
            {
                Naam = reeks.Naam,
                Url = $"http://localhost:5044/api/strips/beheer/reeks/{reeks.ID}",
                Strips = reeks.Strips.Select(strip => new StripDTO
                {
                    Nr = strip.Nr ?? 0, // If Nr is nullable, provide a default value
                    Titel = strip.Titel,
                    Url = $"http://localhost:5044/api/strips/beheer/strip/{strip.ID}"
                }).ToList()
            };
        }
    }
}
