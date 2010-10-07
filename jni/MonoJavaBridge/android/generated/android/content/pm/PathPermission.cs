namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PathPermission : android.os.PatternMatcher
	{
		internal new static global::java.lang.Class staticClass;
		static PathPermission()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.PathPermission), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.PathPermission(@__env);
			}
		}
		protected PathPermission(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1961;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PathPermission._writeToParcel1961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._writeToParcel1961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getReadPermission1962;
		public virtual global::java.lang.String getReadPermission() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PathPermission._getReadPermission1962));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._getReadPermission1962));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWritePermission1963;
		public virtual global::java.lang.String getWritePermission() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PathPermission._getWritePermission1963));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._getWritePermission1963));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PathPermission1964;
		public PathPermission(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._PathPermission1964, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PathPermission1965;
		public PathPermission(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._PathPermission1965, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1966;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.PathPermission.staticClass = @__class;
			global::android.content.pm.PathPermission._writeToParcel1961 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PathPermission._getReadPermission1962 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "getReadPermission", "()Ljava/lang/String;");
			global::android.content.pm.PathPermission._getWritePermission1963 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "getWritePermission", "()Ljava/lang/String;");
			global::android.content.pm.PathPermission._PathPermission1964 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::android.content.pm.PathPermission._PathPermission1965 = @__env.GetMethodID(global::android.content.pm.PathPermission.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
