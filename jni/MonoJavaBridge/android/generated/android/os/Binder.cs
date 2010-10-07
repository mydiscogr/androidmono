namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Binder : java.lang.Object, IBinder
	{
		internal static global::java.lang.Class staticClass;
		static Binder()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Binder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Binder(@__env);
			}
		}
		protected Binder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump5882;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Binder._dump5882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._dump5882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump5883;
		public virtual void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Binder._dump5883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._dump5883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInterfaceDescriptor5884;
		public virtual global::java.lang.String getInterfaceDescriptor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Binder._getInterfaceDescriptor5884));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Binder.staticClass, global::android.os.Binder._getInterfaceDescriptor5884));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pingBinder5885;
		public virtual bool pingBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Binder._pingBinder5885);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._pingBinder5885);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBinderAlive5886;
		public virtual bool isBinderAlive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Binder._isBinderAlive5886);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._isBinderAlive5886);
		}
		internal static global::net.sf.jni4net.jni.MethodId _queryLocalInterface5887;
		public virtual global::android.os.IInterface queryLocalInterface(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Binder._queryLocalInterface5887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Binder.staticClass, global::android.os.Binder._queryLocalInterface5887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _transact5888;
		public virtual bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Binder._transact5888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._transact5888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _linkToDeath5889;
		public virtual void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Binder._linkToDeath5889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._linkToDeath5889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unlinkToDeath5890;
		public virtual bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Binder._unlinkToDeath5890, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._unlinkToDeath5890, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallingPid5891;
		public static int getCallingPid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingPid5891);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallingUid5892;
		public static int getCallingUid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingUid5892);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearCallingIdentity5893;
		public static long clearCallingIdentity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Binder.staticClass, global::android.os.Binder._clearCallingIdentity5893);
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreCallingIdentity5894;
		public static void restoreCallingIdentity(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._restoreCallingIdentity5894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flushPendingCommands5895;
		public static void flushPendingCommands() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._flushPendingCommands5895);
		}
		internal static global::net.sf.jni4net.jni.MethodId _joinThreadPool5896;
		public static void joinThreadPool() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._joinThreadPool5896);
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachInterface5897;
		public virtual void attachInterface(android.os.IInterface arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Binder._attachInterface5897, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._attachInterface5897, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTransact5898;
		protected virtual bool onTransact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Binder._onTransact5898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Binder.staticClass, global::android.os.Binder._onTransact5898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Binder5899;
		public Binder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Binder.staticClass, global::android.os.Binder._Binder5899, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Binder.staticClass = @__class;
			global::android.os.Binder._dump5882 = @__env.GetMethodID(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.os.Binder._dump5883 = @__env.GetMethodID(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V");
			global::android.os.Binder._getInterfaceDescriptor5884 = @__env.GetMethodID(global::android.os.Binder.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;");
			global::android.os.Binder._pingBinder5885 = @__env.GetMethodID(global::android.os.Binder.staticClass, "pingBinder", "()Z");
			global::android.os.Binder._isBinderAlive5886 = @__env.GetMethodID(global::android.os.Binder.staticClass, "isBinderAlive", "()Z");
			global::android.os.Binder._queryLocalInterface5887 = @__env.GetMethodID(global::android.os.Binder.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;");
			global::android.os.Binder._transact5888 = @__env.GetMethodID(global::android.os.Binder.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			global::android.os.Binder._linkToDeath5889 = @__env.GetMethodID(global::android.os.Binder.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V");
			global::android.os.Binder._unlinkToDeath5890 = @__env.GetMethodID(global::android.os.Binder.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z");
			global::android.os.Binder._getCallingPid5891 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "getCallingPid", "()I");
			global::android.os.Binder._getCallingUid5892 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "getCallingUid", "()I");
			global::android.os.Binder._clearCallingIdentity5893 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "clearCallingIdentity", "()J");
			global::android.os.Binder._restoreCallingIdentity5894 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "restoreCallingIdentity", "(J)V");
			global::android.os.Binder._flushPendingCommands5895 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "flushPendingCommands", "()V");
			global::android.os.Binder._joinThreadPool5896 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "joinThreadPool", "()V");
			global::android.os.Binder._attachInterface5897 = @__env.GetMethodID(global::android.os.Binder.staticClass, "attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V");
			global::android.os.Binder._onTransact5898 = @__env.GetMethodID(global::android.os.Binder.staticClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			global::android.os.Binder._Binder5899 = @__env.GetMethodID(global::android.os.Binder.staticClass, "<init>", "()V");
		}
	}
}
