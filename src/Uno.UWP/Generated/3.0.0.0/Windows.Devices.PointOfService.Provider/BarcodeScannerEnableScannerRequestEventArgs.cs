#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BarcodeScannerEnableScannerRequestEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.PointOfService.Provider.BarcodeScannerEnableScannerRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member BarcodeScannerEnableScannerRequest BarcodeScannerEnableScannerRequestEventArgs.Request is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.Provider.BarcodeScannerEnableScannerRequestEventArgs.Request.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral BarcodeScannerEnableScannerRequestEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
