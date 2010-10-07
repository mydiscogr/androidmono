namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AsyncTask : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AsyncTask()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.AsyncTask), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AsyncTask(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Status : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Status()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.AsyncTask.Status), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.AsyncTask.Status(@__env);
				}
			}
			internal Status(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values5861;
			public static global::android.os.AsyncTask.Status[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._values5861));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf5862;
			public static global::android.os.AsyncTask.Status valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallStaticObjectMethodPtr(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._valueOf5862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _FINISHED5863;
			public static global::android.os.AsyncTask.Status FINISHED
			{
				get
				{
					return default(global::android.os.AsyncTask.Status);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _PENDING5864;
			public static global::android.os.AsyncTask.Status PENDING
			{
				get
				{
					return default(global::android.os.AsyncTask.Status);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RUNNING5865;
			public static global::android.os.AsyncTask.Status RUNNING
			{
				get
				{
					return default(global::android.os.AsyncTask.Status);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.AsyncTask.Status.staticClass = @__class;
				global::android.os.AsyncTask.Status._values5861 = @__env.GetStaticMethodID(global::android.os.AsyncTask.Status.staticClass, "values", "()[Landroid/os/AsyncTask/Status;");
				global::android.os.AsyncTask.Status._valueOf5862 = @__env.GetStaticMethodID(global::android.os.AsyncTask.Status.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _get5866;
		public virtual global::java.lang.Object get() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._get5866));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get5866));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get5867;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._get5867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get5867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute5868;
		public virtual global::android.os.AsyncTask execute(java.lang.Object[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._execute5868, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._execute5868, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel5869;
		public virtual bool cancel(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.AsyncTask._cancel5869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._cancel5869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCancelled5870;
		public virtual bool isCancelled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.AsyncTask._isCancelled5870);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._isCancelled5870);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatus5871;
		public virtual global::android.os.AsyncTask.Status getStatus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._getStatus5871));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._getStatus5871));
		}
		internal static global::net.sf.jni4net.jni.MethodId _doInBackground5872;
		protected abstract global::java.lang.Object doInBackground(java.lang.Object[] arg0);
		internal static global::net.sf.jni4net.jni.MethodId _onPreExecute5873;
		protected virtual void onPreExecute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onPreExecute5873);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPreExecute5873);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPostExecute5874;
		protected virtual void onPostExecute(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onPostExecute5874, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPostExecute5874, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onProgressUpdate5875;
		protected virtual void onProgressUpdate(java.lang.Object[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onProgressUpdate5875, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onProgressUpdate5875, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCancelled5876;
		protected virtual void onCancelled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onCancelled5876);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onCancelled5876);
		}
		internal static global::net.sf.jni4net.jni.MethodId _publishProgress5877;
		protected virtual void publishProgress(java.lang.Object[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._publishProgress5877, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._publishProgress5877, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AsyncTask5878;
		public AsyncTask()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.AsyncTask.staticClass, global::android.os.AsyncTask._AsyncTask5878, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.AsyncTask.staticClass = @__class;
			global::android.os.AsyncTask._get5866 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "get", "()Ljava/lang/Object;");
			global::android.os.AsyncTask._get5867 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::android.os.AsyncTask._execute5868 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;");
			global::android.os.AsyncTask._cancel5869 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "cancel", "(Z)Z");
			global::android.os.AsyncTask._isCancelled5870 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "isCancelled", "()Z");
			global::android.os.AsyncTask._getStatus5871 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "getStatus", "()Landroid/os/AsyncTask$Status;");
			global::android.os.AsyncTask._doInBackground5872 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			global::android.os.AsyncTask._onPreExecute5873 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onPreExecute", "()V");
			global::android.os.AsyncTask._onPostExecute5874 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onPostExecute", "(Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onProgressUpdate5875 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onProgressUpdate", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onCancelled5876 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onCancelled", "()V");
			global::android.os.AsyncTask._publishProgress5877 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "publishProgress", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._AsyncTask5878 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "<init>", "()V");
		}
	}
}
