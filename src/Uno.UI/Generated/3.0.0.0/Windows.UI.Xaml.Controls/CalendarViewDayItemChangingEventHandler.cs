#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void CalendarViewDayItemChangingEventHandler(global::Windows.UI.Xaml.Controls.CalendarView @sender, global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs @e);
	#endif
}
