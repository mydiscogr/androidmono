package android.location;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GpsStatus_NmeaListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.location.GpsStatus.NmeaListener
{
	static
	{
		MonoBridge.link(GpsStatus_NmeaListenerDelegateWrapper.class, "onNmeaReceived", "(JLjava/lang/String;)V", "System.Int64,java.lang.String");

	}

	@Override
	public native void onNmeaReceived(long arg0,java.lang.String arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}