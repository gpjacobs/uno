#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IPlayReadyLicenseSession 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest CreateLAServiceRequest();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void ConfigureMediaProtectionManager( global::Windows.Media.Protection.MediaProtectionManager mpm);
		#endif
	}
}
