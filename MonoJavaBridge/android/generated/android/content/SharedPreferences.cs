namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_))]
	public partial interface SharedPreferences  : global::MonoJavaBridge.IJavaObject 
	{
		bool getBoolean(java.lang.String arg0, bool arg1);
		int getInt(java.lang.String arg0, int arg1);
		long getLong(java.lang.String arg0, long arg1);
		float getFloat(java.lang.String arg0, float arg1);
		bool contains(java.lang.String arg0);
		global::java.lang.String getString(java.lang.String arg0, java.lang.String arg1);
		global::android.content.SharedPreferences_Editor edit();
		global::java.util.Map getAll();
		void registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0);
		void unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SharedPreferences))]
	internal sealed partial class SharedPreferences_ : java.lang.Object, SharedPreferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SharedPreferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean3522;
		bool android.content.SharedPreferences.getBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SharedPreferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z", ref global::android.content.SharedPreferences_._getBoolean3522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt3523;
		int android.content.SharedPreferences.getInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SharedPreferences_.staticClass, "getInt", "(Ljava/lang/String;I)I", ref global::android.content.SharedPreferences_._getInt3523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong3524;
		long android.content.SharedPreferences.getLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.SharedPreferences_.staticClass, "getLong", "(Ljava/lang/String;J)J", ref global::android.content.SharedPreferences_._getLong3524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat3525;
		float android.content.SharedPreferences.getFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.SharedPreferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F", ref global::android.content.SharedPreferences_._getFloat3525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _contains3526;
		bool android.content.SharedPreferences.contains(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SharedPreferences_.staticClass, "contains", "(Ljava/lang/String;)Z", ref global::android.content.SharedPreferences_._contains3526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString3527;
		global::java.lang.String android.content.SharedPreferences.getString(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SharedPreferences_.staticClass, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.SharedPreferences_._getString3527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _edit3528;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences.edit()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_.staticClass, "edit", "()Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_._edit3528) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _getAll3529;
		global::java.util.Map android.content.SharedPreferences.getAll()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::android.content.SharedPreferences_.staticClass, "getAll", "()Ljava/util/Map;", ref global::android.content.SharedPreferences_._getAll3529) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _registerOnSharedPreferenceChangeListener3530;
		void android.content.SharedPreferences.registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SharedPreferences_.staticClass, "registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", ref global::android.content.SharedPreferences_._registerOnSharedPreferenceChangeListener3530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterOnSharedPreferenceChangeListener3531;
		void android.content.SharedPreferences.unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SharedPreferences_.staticClass, "unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", ref global::android.content.SharedPreferences_._unregisterOnSharedPreferenceChangeListener3531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SharedPreferences_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences"));
		}
		internal static void InitJNI()
		{
		}
	}
}