using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace LogicMonitor.Api.Data
{
	/// <summary>
	///    An item of raw data
	/// </summary>
	[DataContract]
	public class RawDataSet
	{
		/// <summary>
		///    The data source name
		/// </summary>
		[DataMember(Name = "dataSourceName")]
		public string DataSourceName { get; set; }

		/// <summary>
		///    The data point names
		/// </summary>
		[DataMember(Name = "dataPoints")]
		public List<string> DataPoints { get; set; }

		/// <summary>
		///    The timestamps
		/// </summary>
		[DataMember(Name = "time")]
		public List<long> UtcTimeStamps { get; set; }

		/// <summary>
		///    The values as objects (string or double)
		/// </summary>
		[DataMember(Name = "values")]
		public object[][] ValuesAsObjects { get; set; }

		/// <summary>
		///    The data point values
		/// </summary>
		[IgnoreDataMember]
		public double?[][] Values => Enumerable
					.Range(0, ValuesAsObjects.Length)
					.Select(index => ValuesAsObjects[index]
						.Select(valueAsObject =>
							{
								if (double.TryParse(valueAsObject.ToString(), out var valueAsDouble))
								{
									return valueAsDouble;
								}
								return (double?)null;
							}
						)
						.ToArray()
					)
					.ToArray();

		/// <summary>
		///    The next page parameters
		/// </summary>
		[DataMember(Name = "nextPageParams")]
		public string NextPageParameters { get; set; }
	}
}