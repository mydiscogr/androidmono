namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkageError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkageError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LinkageError20241;
		public LinkageError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.LinkageError._LinkageError20241.native == global::System.IntPtr.Zero)
				global::java.lang.LinkageError._LinkageError20241 = @__env.GetMethodIDNoThrow(global::java.lang.LinkageError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.LinkageError.staticClass, global::java.lang.LinkageError._LinkageError20241);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkageError20242;
		public LinkageError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.LinkageError._LinkageError20242.native == global::System.IntPtr.Zero)
				global::java.lang.LinkageError._LinkageError20242 = @__env.GetMethodIDNoThrow(global::java.lang.LinkageError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.LinkageError.staticClass, global::java.lang.LinkageError._LinkageError20242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LinkageError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.LinkageError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/LinkageError"));
		}
		internal static void InitJNI()
		{
		}
	}
}