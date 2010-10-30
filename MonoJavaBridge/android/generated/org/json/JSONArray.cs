namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get34037;
		public virtual global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "get", "(I)Ljava/lang/Object;", ref global::org.json.JSONArray._get34037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put34038;
		public virtual global::org.json.JSONArray put(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(Ljava/lang/Object;)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34039;
		public virtual global::org.json.JSONArray put(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(IZ)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34040;
		public virtual global::org.json.JSONArray put(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(II)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34041;
		public virtual global::org.json.JSONArray put(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(IJ)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34042;
		public virtual global::org.json.JSONArray put(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(ILjava/lang/Object;)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34043;
		public virtual global::org.json.JSONArray put(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(ID)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34044;
		public virtual global::org.json.JSONArray put(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(Z)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34045;
		public virtual global::org.json.JSONArray put(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(D)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34046;
		public virtual global::org.json.JSONArray put(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(I)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34047;
		public virtual global::org.json.JSONArray put(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(J)Lorg/json/JSONArray;", ref global::org.json.JSONArray._put34047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _equals34048;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.json.JSONArray._equals34048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString34049;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "toString", "()Ljava/lang/String;", ref global::org.json.JSONArray._toString34049) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString34050;
		public virtual global::java.lang.String toString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "toString", "(I)Ljava/lang/String;", ref global::org.json.JSONArray._toString34050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34051;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "hashCode", "()I", ref global::org.json.JSONArray._hashCode34051);
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean34052;
		public virtual bool getBoolean(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "getBoolean", "(I)Z", ref global::org.json.JSONArray._getBoolean34052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt34053;
		public virtual int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "getInt", "(I)I", ref global::org.json.JSONArray._getInt34053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong34054;
		public virtual long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONArray.staticClass, "getLong", "(I)J", ref global::org.json.JSONArray._getLong34054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble34055;
		public virtual double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONArray.staticClass, "getDouble", "(I)D", ref global::org.json.JSONArray._getDouble34055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length34056;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "length", "()I", ref global::org.json.JSONArray._length34056);
		}
		internal static global::MonoJavaBridge.MethodId _join34057;
		public virtual global::java.lang.String join(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "join", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONArray._join34057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString34058;
		public virtual global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "getString", "(I)Ljava/lang/String;", ref global::org.json.JSONArray._getString34058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNull34059;
		public virtual bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "isNull", "(I)Z", ref global::org.json.JSONArray._isNull34059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _opt34060;
		public virtual global::java.lang.Object opt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "opt", "(I)Ljava/lang/Object;", ref global::org.json.JSONArray._opt34060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean34061;
		public virtual bool optBoolean(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "optBoolean", "(IZ)Z", ref global::org.json.JSONArray._optBoolean34061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean34062;
		public virtual bool optBoolean(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "optBoolean", "(I)Z", ref global::org.json.JSONArray._optBoolean34062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble34063;
		public virtual double optDouble(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONArray.staticClass, "optDouble", "(ID)D", ref global::org.json.JSONArray._optDouble34063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble34064;
		public virtual double optDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONArray.staticClass, "optDouble", "(I)D", ref global::org.json.JSONArray._optDouble34064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt34065;
		public virtual int optInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "optInt", "(I)I", ref global::org.json.JSONArray._optInt34065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt34066;
		public virtual int optInt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "optInt", "(II)I", ref global::org.json.JSONArray._optInt34066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong34067;
		public virtual long optLong(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONArray.staticClass, "optLong", "(IJ)J", ref global::org.json.JSONArray._optLong34067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong34068;
		public virtual long optLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONArray.staticClass, "optLong", "(I)J", ref global::org.json.JSONArray._optLong34068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optString34069;
		public virtual global::java.lang.String optString(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "optString", "(ILjava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONArray._optString34069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _optString34070;
		public virtual global::java.lang.String optString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "optString", "(I)Ljava/lang/String;", ref global::org.json.JSONArray._optString34070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONArray34071;
		public virtual global::org.json.JSONArray getJSONArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "getJSONArray", "(I)Lorg/json/JSONArray;", ref global::org.json.JSONArray._getJSONArray34071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONArray34072;
		public virtual global::org.json.JSONArray optJSONArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "optJSONArray", "(I)Lorg/json/JSONArray;", ref global::org.json.JSONArray._optJSONArray34072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONObject34073;
		public virtual global::org.json.JSONObject getJSONObject(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "getJSONObject", "(I)Lorg/json/JSONObject;", ref global::org.json.JSONArray._getJSONObject34073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONObject34074;
		public virtual global::org.json.JSONObject optJSONObject(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "optJSONObject", "(I)Lorg/json/JSONObject;", ref global::org.json.JSONArray._optJSONObject34074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toJSONObject34075;
		public virtual global::org.json.JSONObject toJSONObject(org.json.JSONArray arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "toJSONObject", "(Lorg/json/JSONArray;)Lorg/json/JSONObject;", ref global::org.json.JSONArray._toJSONObject34075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34076;
		public JSONArray(org.json.JSONTokener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._JSONArray34076.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._JSONArray34076 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34077;
		public JSONArray(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._JSONArray34077.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._JSONArray34077 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34078;
		public JSONArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._JSONArray34078.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._JSONArray34078 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34078);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34079;
		public JSONArray(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._JSONArray34079.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._JSONArray34079 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JSONArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONArray"));
		}
		internal static void InitJNI()
		{
		}
	}
}