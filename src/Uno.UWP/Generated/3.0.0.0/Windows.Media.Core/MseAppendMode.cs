#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MseAppendMode 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Segments,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Sequence,
		#endif
	}
	#endif
}
