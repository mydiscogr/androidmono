namespace java.util.regex
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Pattern : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static Pattern()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.regex.Pattern), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.regex.Pattern(@__env);
			}
		}
		internal Pattern(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13922;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Pattern._toString13922));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._toString13922));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flags13923;
		public int flags() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.regex.Pattern._flags13923);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._flags13923);
		}
		internal static global::net.sf.jni4net.jni.MethodId _matches13924;
		public static bool matches(java.lang.String arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._matches13924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _split13925;
		public global::java.lang.String[] split(java.lang.CharSequence arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Pattern._split13925, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._split13925, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.lang.String[] split(string arg0)
		{
			return split((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _split13926;
		public global::java.lang.String[] split(java.lang.CharSequence arg0, int arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Pattern._split13926, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._split13926, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		public java.lang.String[] split(string arg0, int arg1)
		{
			return split((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compile13927;
		public static global::java.util.regex.Pattern compile(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._compile13927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compile13928;
		public static global::java.util.regex.Pattern compile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Pattern>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._compile13928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _matcher13929;
		public global::java.util.regex.Matcher matcher(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Pattern._matcher13929, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.regex.Matcher>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._matcher13929, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.util.regex.Matcher matcher(string arg0)
		{
			return matcher((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _quote13930;
		public static global::java.lang.String quote(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._quote13930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pattern13931;
		public global::java.lang.String pattern() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.regex.Pattern._pattern13931));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.regex.Pattern.staticClass, global::java.util.regex.Pattern._pattern13931));
		}
		public static int UNIX_LINES
		{
			get
			{
				return 1;
			}
		}
		public static int CASE_INSENSITIVE
		{
			get
			{
				return 2;
			}
		}
		public static int COMMENTS
		{
			get
			{
				return 4;
			}
		}
		public static int MULTILINE
		{
			get
			{
				return 8;
			}
		}
		public static int LITERAL
		{
			get
			{
				return 16;
			}
		}
		public static int DOTALL
		{
			get
			{
				return 32;
			}
		}
		public static int UNICODE_CASE
		{
			get
			{
				return 64;
			}
		}
		public static int CANON_EQ
		{
			get
			{
				return 128;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.regex.Pattern.staticClass = @__class;
			global::java.util.regex.Pattern._toString13922 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.regex.Pattern._flags13923 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "flags", "()I");
			global::java.util.regex.Pattern._matches13924 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z");
			global::java.util.regex.Pattern._split13925 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;");
			global::java.util.regex.Pattern._split13926 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;");
			global::java.util.regex.Pattern._compile13927 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;");
			global::java.util.regex.Pattern._compile13928 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;");
			global::java.util.regex.Pattern._matcher13929 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;");
			global::java.util.regex.Pattern._quote13930 = @__env.GetStaticMethodID(global::java.util.regex.Pattern.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.regex.Pattern._pattern13931 = @__env.GetMethodID(global::java.util.regex.Pattern.staticClass, "pattern", "()Ljava/lang/String;");
		}
	}
}
