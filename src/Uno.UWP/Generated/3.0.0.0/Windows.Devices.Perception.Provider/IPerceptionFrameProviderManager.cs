#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IPerceptionFrameProviderManager : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Devices.Perception.Provider.IPerceptionFrameProvider GetFrameProvider( global::Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo frameProviderInfo);
		#endif
	}
}
