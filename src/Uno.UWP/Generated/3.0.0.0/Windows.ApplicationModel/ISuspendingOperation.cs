#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ISuspendingOperation 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::System.DateTimeOffset Deadline
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.ApplicationModel.SuspendingDeferral GetDeferral();
		#endif
		// Forced skipping of method Windows.ApplicationModel.ISuspendingOperation.Deadline.get
	}
}
