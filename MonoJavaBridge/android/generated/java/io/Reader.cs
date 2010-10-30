namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.Reader_))]
	public abstract partial class Reader : java.lang.Object, java.lang.Readable, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Reader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19553;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _mark19554;
		public virtual void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Reader.staticClass, "mark", "(I)V", ref global::java.io.Reader._mark19554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19555;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Reader.staticClass, "reset", "()V", ref global::java.io.Reader._reset19555);
		}
		internal static global::MonoJavaBridge.MethodId _read19556;
		public abstract int read(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read19557;
		public virtual int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader.staticClass, "read", "()I", ref global::java.io.Reader._read19557);
		}
		internal static global::MonoJavaBridge.MethodId _read19558;
		public virtual int read(char[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader.staticClass, "read", "([C)I", ref global::java.io.Reader._read19558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19559;
		public virtual int read(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader.staticClass, "read", "(Ljava/nio/CharBuffer;)I", ref global::java.io.Reader._read19559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip19560;
		public virtual long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.Reader.staticClass, "skip", "(J)J", ref global::java.io.Reader._skip19560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19561;
		public virtual bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.Reader.staticClass, "markSupported", "()Z", ref global::java.io.Reader._markSupported19561);
		}
		internal static global::MonoJavaBridge.MethodId _ready19562;
		public virtual bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.Reader.staticClass, "ready", "()Z", ref global::java.io.Reader._ready19562);
		}
		internal static global::MonoJavaBridge.MethodId _Reader19563;
		protected Reader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.Reader._Reader19563.native == global::System.IntPtr.Zero)
				global::java.io.Reader._Reader19563 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader19563);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Reader19564;
		protected Reader(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.Reader._Reader19564.native == global::System.IntPtr.Zero)
				global::java.io.Reader._Reader19564 = @__env.GetMethodIDNoThrow(global::java.io.Reader.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Reader.staticClass, global::java.io.Reader._Reader19564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Reader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Reader))]
	internal sealed partial class Reader_ : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Reader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19565;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Reader_.staticClass, "close", "()V", ref global::java.io.Reader_._close19565);
		}
		internal static global::MonoJavaBridge.MethodId _read19566;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.Reader_.staticClass, "read", "([CII)I", ref global::java.io.Reader_._read19566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static Reader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Reader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Reader"));
		}
		internal static void InitJNI()
		{
		}
	}
}