namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.AbstractExecutorService_))]
	public abstract partial class AbstractExecutorService : java.lang.Object, ExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractExecutorService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27025;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _awaitTermination27026;
		public abstract bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1);
		internal static global::MonoJavaBridge.MethodId _shutdownNow27027;
		public abstract global::java.util.List shutdownNow();
		internal static global::MonoJavaBridge.MethodId _isShutdown27028;
		public abstract bool isShutdown();
		internal static global::MonoJavaBridge.MethodId _isTerminated27029;
		public abstract bool isTerminated();
		internal static global::MonoJavaBridge.MethodId _execute27030;
		public abstract void execute(java.lang.Runnable arg0);
		internal static global::MonoJavaBridge.MethodId _submit27031;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.AbstractExecutorService._submit27031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _submit27032;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.AbstractExecutorService._submit27032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27033;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.AbstractExecutorService._submit27033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		public java.util.concurrent.Future submit(global::java.lang.RunnableDelegate arg0)
		{
			return submit((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27034;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;", ref global::java.util.concurrent.AbstractExecutorService._invokeAny27034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27035;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.AbstractExecutorService._invokeAny27035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27036;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;", ref global::java.util.concurrent.AbstractExecutorService._invokeAll27036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27037;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;", ref global::java.util.concurrent.AbstractExecutorService._invokeAll27037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractExecutorService27038;
		public AbstractExecutorService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.AbstractExecutorService._AbstractExecutorService27038.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.AbstractExecutorService._AbstractExecutorService27038 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._AbstractExecutorService27038);
			Init(@__env, handle);
		}
		static AbstractExecutorService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.AbstractExecutorService))]
	internal sealed partial class AbstractExecutorService_ : java.util.concurrent.AbstractExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27039;
		public override void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdown", "()V", ref global::java.util.concurrent.AbstractExecutorService_._shutdown27039);
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination27040;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.AbstractExecutorService_._awaitTermination27040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27041;
		public override global::java.util.List shutdownNow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;", ref global::java.util.concurrent.AbstractExecutorService_._shutdownNow27041) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown27042;
		public override bool isShutdown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "isShutdown", "()Z", ref global::java.util.concurrent.AbstractExecutorService_._isShutdown27042);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated27043;
		public override bool isTerminated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "isTerminated", "()Z", ref global::java.util.concurrent.AbstractExecutorService_._isTerminated27043);
		}
		internal static global::MonoJavaBridge.MethodId _execute27044;
		public override void execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.AbstractExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V", ref global::java.util.concurrent.AbstractExecutorService_._execute27044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void execute(global::java.lang.RunnableDelegate arg0)
		{
			execute((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		static AbstractExecutorService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
		}
		internal static void InitJNI()
		{
		}
	}
}