#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum AllJoynAuthenticationMechanism 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		SrpAnonymous,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		SrpLogon,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		EcdheNull,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		EcdhePsk,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		EcdheEcdsa,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		EcdheSpeke,
		#endif
	}
	#endif
}
