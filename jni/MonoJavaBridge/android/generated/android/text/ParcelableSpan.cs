namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ParcelableSpan : android.os.Parcelable
	{
		int getSpanTypeId();
	}

	public partial class ParcelableSpan_
	{
		public static global::java.lang.Class _class
		{
			get { return __ParcelableSpan.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ParcelableSpan : java.lang.Object, ParcelableSpan
	{
		internal static global::java.lang.Class staticClass;
		static __ParcelableSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__ParcelableSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.__ParcelableSpan(@__env);
			}
		}
		internal __ParcelableSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7484;
		 int android.text.ParcelableSpan.getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__ParcelableSpan._getSpanTypeId7484);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__ParcelableSpan.staticClass, global::android.text.__ParcelableSpan._getSpanTypeId7484);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7485;
		 void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__ParcelableSpan._writeToParcel7485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__ParcelableSpan.staticClass, global::android.text.__ParcelableSpan._writeToParcel7485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7486;
		 int android.os.Parcelable.describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__ParcelableSpan._describeContents7486);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__ParcelableSpan.staticClass, global::android.text.__ParcelableSpan._describeContents7486);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.__ParcelableSpan.staticClass = @__class;
			global::android.text.__ParcelableSpan._getSpanTypeId7484 = @__env.GetMethodID(global::android.text.__ParcelableSpan.staticClass, "android.text.ParcelableSpan.getSpanTypeId", "()I");
			global::android.text.__ParcelableSpan._writeToParcel7485 = @__env.GetMethodID(global::android.text.__ParcelableSpan.staticClass, "android.os.Parcelable.writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.__ParcelableSpan._describeContents7486 = @__env.GetMethodID(global::android.text.__ParcelableSpan.staticClass, "android.os.Parcelable.describeContents", "()I");
		}
	}
}
