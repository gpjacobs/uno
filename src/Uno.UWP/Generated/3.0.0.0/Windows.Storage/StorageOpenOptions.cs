#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum StorageOpenOptions 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AllowOnlyReaders,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AllowReadersAndWriters,
		#endif
	}
	#endif
}
