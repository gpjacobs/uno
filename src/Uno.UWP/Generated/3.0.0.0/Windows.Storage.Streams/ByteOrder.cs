#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Streams
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ByteOrder 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		LittleEndian,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		BigEndian,
		#endif
	}
	#endif
}
