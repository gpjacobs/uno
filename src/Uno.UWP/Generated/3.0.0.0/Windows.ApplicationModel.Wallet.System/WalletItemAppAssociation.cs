#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Wallet.System
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum WalletItemAppAssociation 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AppInstalled,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AppNotInstalled,
		#endif
	}
	#endif
}
