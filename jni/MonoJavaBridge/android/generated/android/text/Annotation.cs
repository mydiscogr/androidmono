namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Annotation : java.lang.Object, ParcelableSpan
	{
		internal static global::java.lang.Class staticClass;
		static Annotation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Annotation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.Annotation(@__env);
			}
		}
		protected Annotation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue7317;
		public virtual global::java.lang.String getValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Annotation._getValue7317));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._getValue7317));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKey7318;
		public virtual global::java.lang.String getKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Annotation._getKey7318));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._getKey7318));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7319;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.Annotation._writeToParcel7319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._writeToParcel7319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7320;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Annotation._describeContents7320);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._describeContents7320);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7321;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Annotation._getSpanTypeId7321);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._getSpanTypeId7321);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Annotation7322;
		public Annotation(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._Annotation7322, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Annotation7323;
		public Annotation(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._Annotation7323, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.Annotation.staticClass = @__class;
			global::android.text.Annotation._getValue7317 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "getValue", "()Ljava/lang/String;");
			global::android.text.Annotation._getKey7318 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.text.Annotation._writeToParcel7319 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.Annotation._describeContents7320 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "describeContents", "()I");
			global::android.text.Annotation._getSpanTypeId7321 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "getSpanTypeId", "()I");
			global::android.text.Annotation._Annotation7322 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.text.Annotation._Annotation7323 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
