#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct FlightStickReading 
	{
		// Forced skipping of method Windows.Gaming.Input.FlightStickReading.FlightStickReading()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong Timestamp;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Gaming.Input.FlightStickButtons Buttons;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Gaming.Input.GameControllerSwitchPosition HatSwitch;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double Roll;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double Pitch;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double Yaw;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double Throttle;
		#endif
	}
}
