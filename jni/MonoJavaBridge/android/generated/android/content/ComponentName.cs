namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class ComponentName : java.lang.Object, android.os.Parcelable, java.lang.Cloneable, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static ComponentName()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ComponentName), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.ComponentName(@__env);
			}
		}
		internal ComponentName(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1089;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ComponentName._equals1089, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._equals1089, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1090;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._toString1090));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._toString1090));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1091;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ComponentName._hashCode1091);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._hashCode1091);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone1092;
		public global::android.content.ComponentName clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._clone1092));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._clone1092));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo1093;
		public int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ComponentName._compareTo1093, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._compareTo1093, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo1094;
		public int compareTo(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ComponentName._compareTo1094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._compareTo1094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClassName1095;
		public global::java.lang.String getClassName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._getClassName1095));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._getClassName1095));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName1096;
		public global::java.lang.String getPackageName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._getPackageName1096));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._getPackageName1096));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1097;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ComponentName._writeToParcel1097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._writeToParcel1097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1098;
		public static void writeToParcel(android.content.ComponentName arg0, android.os.Parcel arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._writeToParcel1098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1099;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ComponentName._describeContents1099);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._describeContents1099);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel1100;
		public static global::android.content.ComponentName readFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ComponentName.staticClass, global::android.content.ComponentName._readFromParcel1100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShortClassName1101;
		public global::java.lang.String getShortClassName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._getShortClassName1101));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._getShortClassName1101));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flattenToString1102;
		public global::java.lang.String flattenToString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._flattenToString1102));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._flattenToString1102));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flattenToShortString1103;
		public global::java.lang.String flattenToShortString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._flattenToShortString1103));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._flattenToShortString1103));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unflattenFromString1104;
		public static global::android.content.ComponentName unflattenFromString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ComponentName.staticClass, global::android.content.ComponentName._unflattenFromString1104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toShortString1105;
		public global::java.lang.String toShortString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ComponentName._toShortString1105));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._toShortString1105));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName1106;
		public ComponentName(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1106, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName1107;
		public ComponentName(android.content.Context arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1107, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName1108;
		public ComponentName(android.content.Context arg0, java.lang.Class arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1108, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName1109;
		public ComponentName(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1109, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1110;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.ComponentName.staticClass = @__class;
			global::android.content.ComponentName._equals1089 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.ComponentName._toString1090 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ComponentName._hashCode1091 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "hashCode", "()I");
			global::android.content.ComponentName._clone1092 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "clone", "()Landroid/content/ComponentName;");
			global::android.content.ComponentName._compareTo1093 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.content.ComponentName._compareTo1094 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "compareTo", "(Landroid/content/ComponentName;)I");
			global::android.content.ComponentName._getClassName1095 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getClassName", "()Ljava/lang/String;");
			global::android.content.ComponentName._getPackageName1096 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.ComponentName._writeToParcel1097 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ComponentName._writeToParcel1098 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V");
			global::android.content.ComponentName._describeContents1099 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "describeContents", "()I");
			global::android.content.ComponentName._readFromParcel1100 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;");
			global::android.content.ComponentName._getShortClassName1101 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getShortClassName", "()Ljava/lang/String;");
			global::android.content.ComponentName._flattenToString1102 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "flattenToString", "()Ljava/lang/String;");
			global::android.content.ComponentName._flattenToShortString1103 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "flattenToShortString", "()Ljava/lang/String;");
			global::android.content.ComponentName._unflattenFromString1104 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;");
			global::android.content.ComponentName._toShortString1105 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.content.ComponentName._ComponentName1106 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ComponentName._ComponentName1107 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::android.content.ComponentName._ComponentName1108 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::android.content.ComponentName._ComponentName1109 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
