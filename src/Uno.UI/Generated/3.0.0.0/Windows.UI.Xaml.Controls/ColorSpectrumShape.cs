#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ColorSpectrumShape 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Box,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Ring,
		#endif
	}
	#endif
}
