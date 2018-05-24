#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Maps
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MapRouteRestrictions 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Highways,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		TollRoads,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Ferries,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Tunnels,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DirtRoads,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Motorail,
		#endif
	}
	#endif
}
