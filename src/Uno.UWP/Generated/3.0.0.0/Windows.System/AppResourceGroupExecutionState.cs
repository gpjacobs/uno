#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum AppResourceGroupExecutionState 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Unknown,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Running,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Suspending,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Suspended,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		NotRunning,
		#endif
	}
	#endif
}
