using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;
using NSubstitute;

namespace NSubExample.UnitTests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void RecursiveFakes_work()
        {
            IPerson p = Substitute.For<IPerson>();

            Assert.IsNotNull(p.GetManager());
            Assert.IsNotNull(p.GetManager().GetManager());
            Assert.IsNotNull(p.GetManager().GetManager());
        }
      
    }
}
