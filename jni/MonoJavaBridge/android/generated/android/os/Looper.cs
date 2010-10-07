namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Looper : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Looper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Looper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Looper(@__env);
			}
		}
		protected Looper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6201;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Looper._toString6201));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Looper.staticClass, global::android.os.Looper._toString6201));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loop6202;
		public static void loop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._loop6202);
		}
		internal static global::net.sf.jni4net.jni.MethodId _prepare6203;
		public static void prepare() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepare6203);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump6204;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Looper._dump6204, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Looper.staticClass, global::android.os.Looper._dump6204, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper6205;
		public static global::android.os.Looper getMainLooper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Looper.staticClass, global::android.os.Looper._getMainLooper6205));
		}
		internal static global::net.sf.jni4net.jni.MethodId _prepareMainLooper6206;
		public static void prepareMainLooper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepareMainLooper6206);
		}
		internal static global::net.sf.jni4net.jni.MethodId _myLooper6207;
		public static global::android.os.Looper myLooper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Looper.staticClass, global::android.os.Looper._myLooper6207));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMessageLogging6208;
		public virtual void setMessageLogging(android.util.Printer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Looper._setMessageLogging6208, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Looper.staticClass, global::android.os.Looper._setMessageLogging6208, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _myQueue6209;
		public static global::android.os.MessageQueue myQueue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.MessageQueue>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Looper.staticClass, global::android.os.Looper._myQueue6209));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quit6210;
		public virtual void quit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Looper._quit6210);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Looper.staticClass, global::android.os.Looper._quit6210);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThread6211;
		public virtual global::java.lang.Thread getThread() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Looper._getThread6211));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Looper.staticClass, global::android.os.Looper._getThread6211));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Looper.staticClass = @__class;
			global::android.os.Looper._toString6201 = @__env.GetMethodID(global::android.os.Looper.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Looper._loop6202 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "loop", "()V");
			global::android.os.Looper._prepare6203 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "prepare", "()V");
			global::android.os.Looper._dump6204 = @__env.GetMethodID(global::android.os.Looper.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.os.Looper._getMainLooper6205 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.os.Looper._prepareMainLooper6206 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "prepareMainLooper", "()V");
			global::android.os.Looper._myLooper6207 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "myLooper", "()Landroid/os/Looper;");
			global::android.os.Looper._setMessageLogging6208 = @__env.GetMethodID(global::android.os.Looper.staticClass, "setMessageLogging", "(Landroid/util/Printer;)V");
			global::android.os.Looper._myQueue6209 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "myQueue", "()Landroid/os/MessageQueue;");
			global::android.os.Looper._quit6210 = @__env.GetMethodID(global::android.os.Looper.staticClass, "quit", "()V");
			global::android.os.Looper._getThread6211 = @__env.GetMethodID(global::android.os.Looper.staticClass, "getThread", "()Ljava/lang/Thread;");
		}
	}
}
