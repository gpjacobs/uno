#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void ActivatedEventHandler(object @sender, global::Windows.ApplicationModel.Activation.IActivatedEventArgs @eventArgs);
	#endif
}
