namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AndroidRuntimeException : java.lang.RuntimeException
	{
		internal static global::java.lang.Class staticClass;
		static AndroidRuntimeException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.AndroidRuntimeException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.AndroidRuntimeException(@__env);
			}
		}
		protected AndroidRuntimeException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _AndroidRuntimeException8136;
		public AndroidRuntimeException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._AndroidRuntimeException8136, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AndroidRuntimeException8137;
		public AndroidRuntimeException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._AndroidRuntimeException8137, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AndroidRuntimeException8138;
		public AndroidRuntimeException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.AndroidRuntimeException.staticClass, global::android.util.AndroidRuntimeException._AndroidRuntimeException8138, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.AndroidRuntimeException.staticClass = @__class;
			global::android.util.AndroidRuntimeException._AndroidRuntimeException8136 = @__env.GetMethodID(global::android.util.AndroidRuntimeException.staticClass, "<init>", "()V");
			global::android.util.AndroidRuntimeException._AndroidRuntimeException8137 = @__env.GetMethodID(global::android.util.AndroidRuntimeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.util.AndroidRuntimeException._AndroidRuntimeException8138 = @__env.GetMethodID(global::android.util.AndroidRuntimeException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
