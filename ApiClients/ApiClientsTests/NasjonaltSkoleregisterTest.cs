using Nasjonalt.Skoleregister.Implementation;
using Nasjonalt.Skoleregister.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApiClientsTests
{
    public class NasjonaltSkoleregisterTest
    {
        [Fact]
        public async System.Threading.Tasks.Task Test1Async()
        {

            NasjonaltSkoleregisterCI target = new NasjonaltSkoleregisterCI();

            List<Enhet> result = await target.GetAlleEnheterAsync();

            Assert.NotNull(result);
        }
    }
}
