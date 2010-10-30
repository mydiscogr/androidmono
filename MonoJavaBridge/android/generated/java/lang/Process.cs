namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Process_))]
	public abstract partial class Process : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Process(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _destroy20403;
		public abstract void destroy();
		internal static global::MonoJavaBridge.MethodId _getInputStream20404;
		public abstract global::java.io.InputStream getInputStream();
		internal static global::MonoJavaBridge.MethodId _getOutputStream20405;
		public abstract global::java.io.OutputStream getOutputStream();
		internal static global::MonoJavaBridge.MethodId _getErrorStream20406;
		public abstract global::java.io.InputStream getErrorStream();
		internal static global::MonoJavaBridge.MethodId _waitFor20407;
		public abstract int waitFor();
		internal static global::MonoJavaBridge.MethodId _exitValue20408;
		public abstract int exitValue();
		internal static global::MonoJavaBridge.MethodId _Process20409;
		public Process() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Process._Process20409.native == global::System.IntPtr.Zero)
				global::java.lang.Process._Process20409 = @__env.GetMethodIDNoThrow(global::java.lang.Process.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Process.staticClass, global::java.lang.Process._Process20409);
			Init(@__env, handle);
		}
		static Process()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Process))]
	internal sealed partial class Process_ : java.lang.Process
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Process_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _destroy20410;
		public override void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Process_.staticClass, "destroy", "()V", ref global::java.lang.Process_._destroy20410);
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream20411;
		public override global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Process_.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::java.lang.Process_._getInputStream20411) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream20412;
		public override global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Process_.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::java.lang.Process_._getOutputStream20412) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getErrorStream20413;
		public override global::java.io.InputStream getErrorStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Process_.staticClass, "getErrorStream", "()Ljava/io/InputStream;", ref global::java.lang.Process_._getErrorStream20413) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _waitFor20414;
		public override int waitFor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Process_.staticClass, "waitFor", "()I", ref global::java.lang.Process_._waitFor20414);
		}
		internal static global::MonoJavaBridge.MethodId _exitValue20415;
		public override int exitValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Process_.staticClass, "exitValue", "()I", ref global::java.lang.Process_._exitValue20415);
		}
		static Process_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Process_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Process"));
		}
		internal static void InitJNI()
		{
		}
	}
}