#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICorePointerInputSource2 : global::Windows.UI.Core.ICorePointerInputSource
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.System.DispatcherQueue DispatcherQueue
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Core.ICorePointerInputSource2.DispatcherQueue.get
	}
}
