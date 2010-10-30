namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MergeCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MergeCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4677;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.MergeCursor.staticClass, "getShort", "(I)S", ref global::android.database.MergeCursor._getShort4677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4678;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MergeCursor.staticClass, "getInt", "(I)I", ref global::android.database.MergeCursor._getInt4678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4679;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.MergeCursor.staticClass, "getLong", "(I)J", ref global::android.database.MergeCursor._getLong4679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4680;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.MergeCursor.staticClass, "getFloat", "(I)F", ref global::android.database.MergeCursor._getFloat4680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4681;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.MergeCursor.staticClass, "getDouble", "(I)D", ref global::android.database.MergeCursor._getDouble4681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4682;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "close", "()V", ref global::android.database.MergeCursor._close4682);
		}
		internal static global::MonoJavaBridge.MethodId _getString4683;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.MergeCursor.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.MergeCursor._getString4683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4684;
		public override void registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.MergeCursor._registerContentObserver4684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4685;
		public override void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.MergeCursor._unregisterContentObserver4685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4686;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MergeCursor.staticClass, "getCount", "()I", ref global::android.database.MergeCursor._getCount4686);
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4687;
		public override global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.MergeCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.MergeCursor._getColumnNames4687) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4688;
		public override byte[] getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.MergeCursor.staticClass, "getBlob", "(I)[B", ref global::android.database.MergeCursor._getBlob4688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isNull4689;
		public override bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MergeCursor.staticClass, "isNull", "(I)Z", ref global::android.database.MergeCursor._isNull4689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4690;
		public override void deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "deactivate", "()V", ref global::android.database.MergeCursor._deactivate4690);
		}
		internal static global::MonoJavaBridge.MethodId _requery4691;
		public override bool requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MergeCursor.staticClass, "requery", "()Z", ref global::android.database.MergeCursor._requery4691);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4692;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.MergeCursor._registerDataSetObserver4692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4693;
		public override void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.MergeCursor._unregisterDataSetObserver4693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove4694;
		public override bool onMove(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MergeCursor.staticClass, "onMove", "(II)Z", ref global::android.database.MergeCursor._onMove4694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MergeCursor4695;
		public MergeCursor(android.database.Cursor[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MergeCursor._MergeCursor4695.native == global::System.IntPtr.Zero)
				global::android.database.MergeCursor._MergeCursor4695 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "<init>", "([Landroid/database/Cursor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MergeCursor.staticClass, global::android.database.MergeCursor._MergeCursor4695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MergeCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MergeCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MergeCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}