#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Text
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum UnicodeNumericType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Decimal,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Digit,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Numeric,
		#endif
	}
	#endif
}
