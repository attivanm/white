using Northwind.Dal;
using Northwind.Framework.Engine;
using Northwind.Utils;
using System;
using TechTalk.SpecFlow;

namespace Northwind.Acceptance.Base
{
    [Binding]
    public sealed class BaseScenario
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            //Generate Key (random)
            SaveNorthwindSufixValue();
            //SetUp
            WindowRepository.Init();

            //DB
            DalManager.ClearDatabase();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Validate FINAL result


            //Close
            //WindowRepository.Close();
        }

        private void SaveNorthwindSufixValue()
        {
            Environment.SetEnvironmentVariable("NorthwindSufixValue", DataGenerator.Random);
        }
    }
}
