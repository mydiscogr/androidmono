namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.ServiceConnection_))]
	public partial interface ServiceConnection  : global::MonoJavaBridge.IJavaObject 
	{
		void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1);
		void onServiceDisconnected(android.content.ComponentName arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ServiceConnection))]
	internal sealed partial class ServiceConnection_ : java.lang.Object, ServiceConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ServiceConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onServiceConnected3510;
		void android.content.ServiceConnection.onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ServiceConnection_.staticClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", ref global::android.content.ServiceConnection_._onServiceConnected3510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onServiceDisconnected3511;
		void android.content.ServiceConnection.onServiceDisconnected(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ServiceConnection_.staticClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V", ref global::android.content.ServiceConnection_._onServiceDisconnected3511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ServiceConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ServiceConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ServiceConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}