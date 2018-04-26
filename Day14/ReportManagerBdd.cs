using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System.IO;
using System.Reflection;

namespace *
{
    public sealed class ReportManagerBdd
    {
        private readonly ExtentReports _extent;
        private ExtentTest _feature;
        private ExtentTest _scenario;
        private ExtentTest _step;

        private ReportManagerBdd()
        {
            string local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var fileName = @"c:\Results\AutomationReport.html";
            var htmlReporter = new ExtentHtmlReporter(fileName);
            htmlReporter.LoadConfig(Path.Combine(local, @"extent-config.xml"));

            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
        }

        public void AddFeature(string featureName)
        {
            _feature = _extent.CreateTest<Feature>(featureName);
        }

        public void AddScenario(string testcaseName)
        {
            _scenario = _feature.CreateNode<Scenario>(testcaseName);
        }

        public void Fail(string error)
        {
            _step.Fail(error);
        }

        public void AddGiven(string given, string table = null)
        {
            if (table != null)
            {
                _step = _scenario.CreateNode<Given>(given).Pass(table);
            }
            else
            {
                _step = _scenario.CreateNode<Given>(given);
            }
        }

        public void AddWhen(string when, string table = null)
        {
            if (table != null)
            {
                _step = _scenario.CreateNode<When>(when).Pass(table);
            }
            else
            {
                _step = _scenario.CreateNode<When>(when);
            }
        }

        public void AddThen(string then)
        {
            _step = _scenario.CreateNode<Then>(then);
        }

        public void Flush()
        {
            _extent.Flush();
        }

        private static ReportManagerBdd _instance;
        public static ReportManagerBdd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReportManagerBdd();
                }

                return _instance;
            }
        }
    }
}