using AutomatedQA.script;
using System;
using System.Threading;

namespace AutomatedQA.TestComplete
{
	public class Connect
	{
		public class TBaseTCClass : var
		{
			private const string TestCompleteApplication = "TestComplete.TestCompleteApplication.9";

			private const string TestExecuteApplication = "TestExecute.TestExecuteApplication.9";

			protected static bool isInit = false;

			protected var GetTestCompleteIntegration()
			{
				return new var().GetObjectAlternative("TestComplete.TestCompleteApplication.9", "TestExecute.TestExecuteApplication.9");
			}

			protected object GetTestCompleteObjectByName(string Name)
			{
				return this.GetTestCompleteIntegration()["Integration", new var[0]]["GetObjectByName", new var[0]].Call(new var[]
				{
					Name
				}).UnWrap();
			}
		}

		public class TCClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteIntegration().UnWrap();
				}
			}
		}

		public class IntegrationClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteIntegration()["Integration", new var[0]].UnWrap();
				}
			}
		}

		public class ManagerClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteIntegration()["Manager", new var[0]]["ManagersByString", new var[0]].Call(new var[]
					{
						"{6FD84F86-DA2B-4902-BD72-1E0A9A85146D}"
					}).UnWrap();
				}
			}
		}

		public class ProjectClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Project");
				}
			}
		}

		public class ProjectSuiteClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("ProjectSuite");
				}
			}
		}

		public class ADOClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("ADO");
				}
			}
		}

		public class BDEClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("BDE");
				}
			}
		}

		public class BuiltInClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("BuiltIn");
				}
			}
		}

		public class DBClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("DB");
				}
			}
		}

		public class DbgServicesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("DbgServices");
				}
			}
		}

		public class DllClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Dll");
				}
			}
		}

		public class dotNETClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("dotNET");
				}
			}
		}

		public class FilesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Files");
				}
			}
		}

		public class IndicatorClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Indicator");
				}
			}
		}

		public class LoadTestingClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("LoadTesting");
				}
			}
		}

		public class LogClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Log");
				}
			}
		}

		public class NetSuiteClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("NetworkSuite");
				}
			}
		}

		public class ObjectsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Objects");
				}
			}
		}

		public class OCRClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("OCR");
				}
			}
		}

		public class ODTClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("ODT");
				}
			}
		}

		public class RegionsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Regions");
				}
			}
		}

		public class RunnerClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Runner");
				}
			}
		}

		public class StoragesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Storages");
				}
			}
		}

		public class SysClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Sys");
				}
			}
		}

		public class TestedAppsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("TestedApps");
				}
			}
		}

		public class OptionsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Options");
				}
			}
		}

		public class UtilitiesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Utilities");
				}
			}
		}

		public class UtilsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Utils");
				}
			}
		}

		public class Win32APIClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Win32API");
				}
			}
		}

		public class NameMappingClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("NameMapping");
				}
			}
		}

		public class ConstsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Consts");
				}
			}
		}

		public class AliasesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Aliases");
				}
			}
		}

		public class KeywordTestsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("KeywordTests");
				}
			}
		}

		public class DDTClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("DDT");
				}
			}
		}

		public class aqStringClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqString");
				}
			}
		}

		public class aqConvertClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqConvert");
				}
			}
		}

		public class aqDateTimeClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqDateTime");
				}
			}
		}

		public class aqFileSystemClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqFileSystem");
				}
			}
		}

		public class aqFileClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqFile");
				}
			}
		}

		public class aqEnvironmentClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqEnvironment");
				}
			}
		}

		public class aqObjectClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqObject");
				}
			}
		}

		public class aqUtilsClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("aqUtils");
				}
			}
		}

		public class DBTablesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("DBTables");
				}
			}
		}

		public class IssueTrackingClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("IssueTracking");
				}
			}
		}

		public class LLPlayerClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("LLPlayer");
				}
			}
		}

		public class TablesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("Tables");
				}
			}
		}

		public class WebTestingClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("WebTesting");
				}
			}
		}

		public class WebServicesClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("WebServices");
				}
			}
		}

		public class XMLClass : Connect.TBaseTCClass
		{
			protected override void Init()
			{
				if (!Connect.TBaseTCClass.isInit)
				{
					this.Object = base.GetTestCompleteObjectByName("XML");
				}
			}
		}

		public const int pmLowest = 100;

		public const int pmLower = 200;

		public const int pmNormal = 300;

		public const int pmHigher = 400;

		public const int pmHighest = 500;

		public const int fmBold = 1;

		public const int fmItalic = 2;

		public const int fmUnderline = 4;

		public const int fmStrikeOut = 8;

		public const int skShift = 8192;

		public const int skAlt = 32768;

		public const int skCtrl = 16384;

		public const int cbUnchecked = 0;

		public const int cbChecked = 1;

		public const int cbGrayed = 2;

		public static Connect.TCClass TC = new Connect.TCClass();

		public static Connect.ADOClass ADO = new Connect.ADOClass();

		public static Connect.BDEClass BDE = new Connect.BDEClass();

		public static Connect.BuiltInClass BuiltIn = new Connect.BuiltInClass();

		public static Connect.DBClass DB = new Connect.DBClass();

		public static Connect.DbgServicesClass DbgServices = new Connect.DbgServicesClass();

		public static Connect.DllClass Dll = new Connect.DllClass();

		public static Connect.dotNETClass dotNET = new Connect.dotNETClass();

		public static Connect.FilesClass Files = new Connect.FilesClass();

		public static Connect.IndicatorClass Indicator = new Connect.IndicatorClass();

		public static Connect.LoadTestingClass LoadTesting = new Connect.LoadTestingClass();

		public static Connect.LogClass Log = new Connect.LogClass();

		public static Connect.NetSuiteClass NetworkSuite = new Connect.NetSuiteClass();

		public static Connect.ObjectsClass Objects = new Connect.ObjectsClass();

		public static Connect.OCRClass OCR = new Connect.OCRClass();

		public static Connect.ODTClass ODT = new Connect.ODTClass();

		public static Connect.OptionsClass Options = new Connect.OptionsClass();

		public static Connect.ProjectClass Project = new Connect.ProjectClass();

		public static Connect.IntegrationClass Integration = new Connect.IntegrationClass();

		public static Connect.ManagerClass Manager = new Connect.ManagerClass();

		public static Connect.ProjectSuiteClass ProjectSuite = new Connect.ProjectSuiteClass();

		public static Connect.RegionsClass Regions = new Connect.RegionsClass();

		public static Connect.RunnerClass Runner = new Connect.RunnerClass();

		public static Connect.SysClass Sys = new Connect.SysClass();

		public static Connect.StoragesClass Storages = new Connect.StoragesClass();

		public static Connect.TestedAppsClass TestedApps = new Connect.TestedAppsClass();

		public static Connect.UtilitiesClass Utilities = new Connect.UtilitiesClass();

		public static Connect.UtilsClass Utils = new Connect.UtilsClass();

		public static Connect.Win32APIClass Win32API = new Connect.Win32APIClass();

		public static Connect.NameMappingClass NameMapping = new Connect.NameMappingClass();

		public static Connect.ConstsClass Consts = new Connect.ConstsClass();

		public static Connect.AliasesClass Aliases = new Connect.AliasesClass();

		public static Connect.KeywordTestsClass KeywordTests = new Connect.KeywordTestsClass();

		public static Connect.DDTClass DDT = new Connect.DDTClass();

		public static Connect.aqStringClass aqString = new Connect.aqStringClass();

		public static Connect.aqConvertClass aqConvert = new Connect.aqConvertClass();

		public static Connect.aqDateTimeClass aqDateTime = new Connect.aqDateTimeClass();

		public static Connect.aqFileSystemClass aqFileSystem = new Connect.aqFileSystemClass();

		public static Connect.aqFileClass aqFile = new Connect.aqFileClass();

		public static Connect.aqEnvironmentClass aqEnvironment = new Connect.aqEnvironmentClass();

		public static Connect.aqObjectClass aqObject = new Connect.aqObjectClass();

		public static Connect.aqUtilsClass aqUtils = new Connect.aqUtilsClass();

		public static Connect.DBTablesClass DBTables = new Connect.DBTablesClass();

		public static Connect.IssueTrackingClass IssueTracking = new Connect.IssueTrackingClass();

		public static Connect.LLPlayerClass LLPlayer = new Connect.LLPlayerClass();

		public static Connect.TablesClass Tables = new Connect.TablesClass();

		public static Connect.WebTestingClass WebTesting = new Connect.WebTestingClass();

		public static Connect.WebServicesClass WebServices = new Connect.WebServicesClass();

		public static Connect.XMLClass XML = new Connect.XMLClass();

		public static Connect.TCClass TCFunc()
		{
			return null;
		}

		public static void StopTest()
		{
			Connect.Runner["Stop", new var[0]].Do(new var[0]);
		}

		public static void RunTest(string LogName, string ProjectName, string SuiteName)
		{
			if (Connect.Integration["IsRunning", new var[0]].Do(new var[0]))
			{
				throw new Exception("TestComplete is already in the playing state.");
			}
			Connect.Integration["OpenProjectSuite", new var[0]].Do(new var[]
			{
				SuiteName
			});
			var var = Connect.TC["Manager", new var[0]]["ManagersByString", new var[0]].Do(new var[]
			{
				"{555A3A53-8D35-4F93-9570-00662CF627C6}"
			});
			var["RunConnected", new var[0]].Do(new var[]
			{
				LogName,
				ProjectName
			});
			long num = 0L;
			while (Connect.Runner.UnWrap() == null)
			{
				Thread.Sleep(500);
				num += 500L;
				if (num > 5000L)
				{
					throw new Exception("Playing back start failed.");
				}
			}
		}
	}
}
