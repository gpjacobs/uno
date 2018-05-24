#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Midi
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IMidiMessage 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Storage.Streams.IBuffer RawData
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::System.TimeSpan Timestamp
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Devices.Midi.MidiMessageType Type
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Devices.Midi.IMidiMessage.Timestamp.get
		// Forced skipping of method Windows.Devices.Midi.IMidiMessage.RawData.get
		// Forced skipping of method Windows.Devices.Midi.IMidiMessage.Type.get
	}
}
