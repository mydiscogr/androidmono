namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertificateParsingException : java.security.cert.CertificateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertificateParsingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException23610;
		public CertificateParsingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateParsingException._CertificateParsingException23610.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateParsingException._CertificateParsingException23610 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException23610);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException23611;
		public CertificateParsingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateParsingException._CertificateParsingException23611.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateParsingException._CertificateParsingException23611 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException23611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException23612;
		public CertificateParsingException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateParsingException._CertificateParsingException23612.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateParsingException._CertificateParsingException23612 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException23612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertificateParsingException23613;
		public CertificateParsingException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertificateParsingException._CertificateParsingException23613.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertificateParsingException._CertificateParsingException23613 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertificateParsingException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertificateParsingException.staticClass, global::java.security.cert.CertificateParsingException._CertificateParsingException23613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertificateParsingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertificateParsingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertificateParsingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}