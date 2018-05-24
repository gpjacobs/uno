#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct GamepadVibration 
	{
		// Forced skipping of method Windows.Gaming.Input.GamepadVibration.GamepadVibration()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double LeftMotor;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double RightMotor;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double LeftTrigger;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double RightTrigger;
		#endif
	}
}
