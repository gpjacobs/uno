#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarPencilButton : global::Windows.UI.Xaml.Controls.InkToolbarPenButton
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public InkToolbarPencilButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarPencilButton", "InkToolbarPencilButton.InkToolbarPencilButton()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarPencilButton.InkToolbarPencilButton()
	}
}
