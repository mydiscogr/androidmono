namespace android.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RootElement : android.sax.Element
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RootElement()
		{
			InitJNI();
		}
		protected RootElement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler7253;
		public virtual global::org.xml.sax.ContentHandler getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::android.sax.RootElement._getContentHandler7253)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.sax.RootElement.staticClass, global::android.sax.RootElement._getContentHandler7253)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _RootElement7254;
		public RootElement(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement7254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RootElement7255;
		public RootElement(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement7255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.RootElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/RootElement"));
			global::android.sax.RootElement._getContentHandler7253 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::android.sax.RootElement._RootElement7254 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.sax.RootElement._RootElement7255 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
