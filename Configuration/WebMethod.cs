namespace DynamicPowerShellApi.Configuration
{
	using System.Configuration;

	/// <summary>
	/// The web method.
	/// </summary>
	public class WebMethod : ConfigurationElement
	{
		/// <summary>
		/// Gets the name.
		/// </summary>
		[ConfigurationProperty("Name", IsKey = true)]
		public string Name
		{
			get
			{
				return (string)this["Name"];
			}
		}

		/// <summary>
		/// Gets the PowerShell path.
		/// </summary>
		[ConfigurationProperty("PowerShellPath")]
		public string PowerShellPath
		{
			get
			{
				return (string)this["PowerShellPath"];
			}
		}

		/// <summary>
		/// Gets the snap in.
		/// </summary>
		[ConfigurationProperty("Snapin")]
		public string Snapin
		{
			get
			{
				return (string)this["Snapin"];
			}
		}

		/// <summary>
		/// Gets the parameters.
		/// </summary>
		[ConfigurationProperty("Parameters")]
		public ParameterCollection Parameters
		{
			get
			{
				return (ParameterCollection)this["Parameters"];
			}
		}
	}
}