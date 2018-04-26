using Northwind.Dal;
using Northwind.Framework.Engine;
using NUnit.Framework;

namespace Northwind.Tests.Base
{
    [TestFixture]
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            //SetUp
            WindowRepository.Init();

            //DB
            DalManager.ClearDatabase();
        }

        [TearDown]
        public void CleanUp()
        {
            //Validate FINAL scenario


            //Close
            WindowRepository.Close();
        }
    }
}