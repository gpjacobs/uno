#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IGameControllerBatteryInfo 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Devices.Power.BatteryReport TryGetBatteryReport();
		#endif
	}
}
