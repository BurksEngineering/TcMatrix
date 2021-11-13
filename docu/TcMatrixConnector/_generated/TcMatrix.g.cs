using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using TcMatrixConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MatrixCsvReader\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MatrixCsvWriter\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"DynamicMatrix\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"ExternalStaticMatrix\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"Matrix\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MatrixAccessor\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"ShrunkMatrixAccessor\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"SubMatrixAccessor\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"TransposeMatrixAccessor\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"StaticMatrix\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"Global_Version\",\r\n      \"Namespace\": \"TcMatrix\",\r\n      \"TypeMetaInfo\": 0\r\n    }\r\n  ],\r\n  \"Name\": \"TcMatrix\",\r\n  \"Namespace\": \"TcMatrix\"\r\n}")]
#pragma warning disable SA1402, CS1591, CS0108, CS0067
namespace TcMatrix
{
	public partial class TcMatrixTwinController : Vortex.Connector.ITwinController, ITcMatrixTwinController, IShadowTcMatrixTwinController
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return TcMatrixTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Global_Version _Global_Version;
		public Global_Version Global_Version
		{
			get
			{
				return _Global_Version;
			}
		}

		IGlobal_Version ITcMatrixTwinController.Global_Version
		{
			get
			{
				return Global_Version;
			}
		}

		IShadowGlobal_Version IShadowTcMatrixTwinController.Global_Version
		{
			get
			{
				return Global_Version;
			}
		}

		public void LazyOnlineToShadow()
		{
			Global_Version.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			Global_Version.LazyShadowToOnline();
		}

		public PlainTcMatrixTwinController CreatePlainerType()
		{
			var cloned = new PlainTcMatrixTwinController();
			cloned.Global_Version = Global_Version.CreatePlainerType();
			return cloned;
		}

		protected PlainTcMatrixTwinController CreatePlainerType(PlainTcMatrixTwinController cloned)
		{
			cloned.Global_Version = Global_Version.CreatePlainerType();
			return cloned;
		}

		public System.String AttributeName
		{
			get
			{
				return TcMatrixTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public ITcMatrixTwinController Online
		{
			get
			{
				return (ITcMatrixTwinController)this;
			}
		}

		public IShadowTcMatrixTwinController Shadow
		{
			get
			{
				return (IShadowTcMatrixTwinController)this;
			}
		}

		public Vortex.Connector.IConnector Connector
		{
			get;
			set;
		}

		public TcMatrixTwinController()
		{
			var adapter = new Vortex.Connector.ConnectorAdapter(typeof (DummyConnectorFactory));
			this.Connector = adapter.GetConnector(new object[]{});
			_Global_Version = new Global_Version(this.Connector, "", "Global_Version");
		}

		public TcMatrixTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_Global_Version = new Global_Version(this.Connector, "", "Global_Version");
		}

		public TcMatrixTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_Global_Version = new Global_Version(this.Connector, "", "Global_Version");
		}

		public static string LocalizationDirectory
		{
			get;
			set;
		}

		private static Vortex.Localizations.Abstractions.ITranslator _translator
		{
			get;
			set;
		}

		internal static Vortex.Localizations.Abstractions.ITranslator Translator
		{
			get
			{
				if (_translator == null)
				{
					_translator = Vortex.Localizations.Abstractions.ITranslator.Get(typeof (Localizations));
				} return  _translator ; 

			}
		}
	}

	public partial interface ITcMatrixTwinController
	{
		IGlobal_Version Global_Version
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainTcMatrixTwinController CreatePlainerType();
	}

	public partial interface IShadowTcMatrixTwinController
	{
		IShadowGlobal_Version Global_Version
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainTcMatrixTwinController CreatePlainerType();
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTcMatrixTwinController : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainGlobal_Version _Global_Version;
		public PlainGlobal_Version Global_Version
		{
			get
			{
				return _Global_Version;
			}

			set
			{
				if (_Global_Version != value)
				{
					_Global_Version = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Global_Version)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTcMatrixTwinController()
		{
			_Global_Version = new PlainGlobal_Version();
		}
	}
}