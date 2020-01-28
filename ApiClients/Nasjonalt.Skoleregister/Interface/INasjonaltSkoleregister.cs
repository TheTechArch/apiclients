using Nasjonalt.Skoleregister.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nasjonalt.Skoleregister.Interface
{
    public interface INasjonaltSkoleregister
    {
        Task<List<Enhet>> GetAlleEnheterAsync();

        Enhet GetEnhet(string id);

        List<Enhet> GetEnheterByDate(DateTime date);

        List<Enhet> GetEnheter(Enhetsok sok);
    }
}
