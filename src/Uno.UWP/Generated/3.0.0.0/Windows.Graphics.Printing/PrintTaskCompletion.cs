#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum PrintTaskCompletion 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Abandoned,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Canceled,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Failed,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Submitted,
		#endif
	}
	#endif
}
