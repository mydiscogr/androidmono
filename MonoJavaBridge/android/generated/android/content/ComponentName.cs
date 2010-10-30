namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ComponentName : java.lang.Object, android.os.Parcelable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ComponentName(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals2611;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ComponentName.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.ComponentName._equals2611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2612;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.ComponentName._toString2612) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2613;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "hashCode", "()I", ref global::android.content.ComponentName._hashCode2613);
		}
		internal static global::MonoJavaBridge.MethodId _clone2614;
		public global::android.content.ComponentName clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.ComponentName.staticClass, "clone", "()Landroid/content/ComponentName;", ref global::android.content.ComponentName._clone2614) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo2615;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::android.content.ComponentName._compareTo2615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo2616;
		public int compareTo(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "compareTo", "(Landroid/content/ComponentName;)I", ref global::android.content.ComponentName._compareTo2616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassName2617;
		public global::java.lang.String getClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "getClassName", "()Ljava/lang/String;", ref global::android.content.ComponentName._getClassName2617) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName2618;
		public global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.content.ComponentName._getPackageName2618) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2619;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.ComponentName._writeToParcel2619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2620;
		public static void writeToParcel(android.content.ComponentName arg0, android.os.Parcel arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._writeToParcel2620.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._writeToParcel2620 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._writeToParcel2620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2621;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ComponentName.staticClass, "describeContents", "()I", ref global::android.content.ComponentName._describeContents2621);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel2622;
		public static global::android.content.ComponentName readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._readFromParcel2622.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._readFromParcel2622 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallStaticObjectMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._readFromParcel2622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		public new global::java.lang.String ShortClassName
		{
			get
			{
				return getShortClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShortClassName2623;
		public global::java.lang.String getShortClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "getShortClassName", "()Ljava/lang/String;", ref global::android.content.ComponentName._getShortClassName2623) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _flattenToString2624;
		public global::java.lang.String flattenToString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "flattenToString", "()Ljava/lang/String;", ref global::android.content.ComponentName._flattenToString2624) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _flattenToShortString2625;
		public global::java.lang.String flattenToShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "flattenToShortString", "()Ljava/lang/String;", ref global::android.content.ComponentName._flattenToShortString2625) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unflattenFromString2626;
		public static global::android.content.ComponentName unflattenFromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._unflattenFromString2626.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._unflattenFromString2626 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallStaticObjectMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._unflattenFromString2626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _toShortString2627;
		public global::java.lang.String toShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ComponentName.staticClass, "toShortString", "()Ljava/lang/String;", ref global::android.content.ComponentName._toShortString2627) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName2628;
		public ComponentName(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._ComponentName2628.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._ComponentName2628 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName2628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName2629;
		public ComponentName(android.content.Context arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._ComponentName2629.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._ComponentName2629 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName2629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName2630;
		public ComponentName(android.content.Context arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._ComponentName2630.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._ComponentName2630 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName2630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName2631;
		public ComponentName(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ComponentName._ComponentName2631.native == global::System.IntPtr.Zero)
				global::android.content.ComponentName._ComponentName2631 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName2631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2632;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ComponentName.staticClass, _CREATOR2632)) as android.os.Parcelable_Creator;
			}
		}
		static ComponentName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ComponentName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ComponentName"));
			global::android.content.ComponentName._CREATOR2632 = @__env.GetStaticFieldIDNoThrow(global::android.content.ComponentName.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}