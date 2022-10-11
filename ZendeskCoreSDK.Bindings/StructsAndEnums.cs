using ObjCRuntime;

namespace ZendeskCoreSDK.Bindings
{
	[Native]
	public enum ZDKIdentityType : long
	{
		Anonymous = 0,
		Jwt = 1
	}

	[Native]
	public enum ZDKLogLevel : long
	{
		Error = 0,
		Warn = 1,
		Info = 2,
		Debug = 3,
		Verbose = 4
	}
}
