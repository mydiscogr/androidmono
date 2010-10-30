namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Float : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Float(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20142;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Float.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Float._equals20142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20143;
		public static global::java.lang.String toString(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._toString20143.native == global::System.IntPtr.Zero)
				global::java.lang.Float._toString20143 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "(F)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toString20143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20144;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Float.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Float._toString20144) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20145;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "hashCode", "()I", ref global::java.lang.Float._hashCode20145);
		}
		internal static global::MonoJavaBridge.MethodId _floatToRawIntBits20146;
		public static int floatToRawIntBits(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._floatToRawIntBits20146.native == global::System.IntPtr.Zero)
				global::java.lang.Float._floatToRawIntBits20146 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToRawIntBits", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToRawIntBits20146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floatToIntBits20147;
		public static int floatToIntBits(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._floatToIntBits20147.native == global::System.IntPtr.Zero)
				global::java.lang.Float._floatToIntBits20147 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToIntBits", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToIntBits20147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intBitsToFloat20148;
		public static float intBitsToFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._intBitsToFloat20148.native == global::System.IntPtr.Zero)
				global::java.lang.Float._intBitsToFloat20148 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "intBitsToFloat", "(I)F");
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._intBitsToFloat20148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20149;
		public int compareTo(java.lang.Float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Float;)I", ref global::java.lang.Float._compareTo20149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20150;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Float._compareTo20150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString20151;
		public static global::java.lang.String toHexString(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._toHexString20151.native == global::System.IntPtr.Zero)
				global::java.lang.Float._toHexString20151 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toHexString", "(F)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toHexString20151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20152;
		public static global::java.lang.Float valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._valueOf20152.native == global::System.IntPtr.Zero)
				global::java.lang.Float._valueOf20152 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Float>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf20152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20153;
		public static global::java.lang.Float valueOf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._valueOf20153.native == global::System.IntPtr.Zero)
				global::java.lang.Float._valueOf20153 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(F)Ljava/lang/Float;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Float>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf20153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _compare20154;
		public static int compare(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._compare20154.native == global::System.IntPtr.Zero)
				global::java.lang.Float._compare20154 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "compare", "(FF)I");
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._compare20154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN20155;
		public static bool isNaN(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._isNaN20155.native == global::System.IntPtr.Zero)
				global::java.lang.Float._isNaN20155 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "(F)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isNaN20155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN20156;
		public bool isNaN()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Float.staticClass, "isNaN", "()Z", ref global::java.lang.Float._isNaN20156);
		}
		internal static global::MonoJavaBridge.MethodId _parseFloat20157;
		public static float parseFloat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._parseFloat20157.native == global::System.IntPtr.Zero)
				global::java.lang.Float._parseFloat20157 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "parseFloat", "(Ljava/lang/String;)F");
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._parseFloat20157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite20158;
		public static bool isInfinite(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._isInfinite20158.native == global::System.IntPtr.Zero)
				global::java.lang.Float._isInfinite20158 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "(F)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isInfinite20158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite20159;
		public bool isInfinite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Float.staticClass, "isInfinite", "()Z", ref global::java.lang.Float._isInfinite20159);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20160;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Float.staticClass, "byteValue", "()B", ref global::java.lang.Float._byteValue20160);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20161;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Float.staticClass, "shortValue", "()S", ref global::java.lang.Float._shortValue20161);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20162;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "intValue", "()I", ref global::java.lang.Float._intValue20162);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20163;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Float.staticClass, "longValue", "()J", ref global::java.lang.Float._longValue20163);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20164;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Float.staticClass, "floatValue", "()F", ref global::java.lang.Float._floatValue20164);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20165;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Float.staticClass, "doubleValue", "()D", ref global::java.lang.Float._doubleValue20165);
		}
		internal static global::MonoJavaBridge.MethodId _Float20166;
		public Float(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._Float20166.native == global::System.IntPtr.Zero)
				global::java.lang.Float._Float20166 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float20166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float20167;
		public Float(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._Float20167.native == global::System.IntPtr.Zero)
				global::java.lang.Float._Float20167 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float20167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float20168;
		public Float(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._Float20168.native == global::System.IntPtr.Zero)
				global::java.lang.Float._Float20168 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(D)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float20168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Float()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Float.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Float"));
		}
		internal static void InitJNI()
		{
		}
	}
}