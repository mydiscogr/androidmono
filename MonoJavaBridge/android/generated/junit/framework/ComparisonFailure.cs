namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComparisonFailure : junit.framework.AssertionFailedError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ComparisonFailure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage31372;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.ComparisonFailure.staticClass, "getMessage", "()Ljava/lang/String;", ref global::junit.framework.ComparisonFailure._getMessage31372) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ComparisonFailure31373;
		public ComparisonFailure(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.ComparisonFailure._ComparisonFailure31373.native == global::System.IntPtr.Zero)
				global::junit.framework.ComparisonFailure._ComparisonFailure31373 = @__env.GetMethodIDNoThrow(global::junit.framework.ComparisonFailure.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.ComparisonFailure.staticClass, global::junit.framework.ComparisonFailure._ComparisonFailure31373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ComparisonFailure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.ComparisonFailure.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/ComparisonFailure"));
		}
		internal static void InitJNI()
		{
		}
	}
}