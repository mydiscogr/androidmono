namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipEntry : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipEntry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString28433;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipEntry.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.zip.ZipEntry._toString28433) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode28434;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipEntry.staticClass, "hashCode", "()I", ref global::java.util.zip.ZipEntry._hashCode28434);
		}
		internal static global::MonoJavaBridge.MethodId _clone28435;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipEntry.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.zip.ZipEntry._clone28435) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName28436;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipEntry.staticClass, "getName", "()Ljava/lang/String;", ref global::java.util.zip.ZipEntry._getName28436) as java.lang.String;
		}
		public new int Method
		{
			get
			{
				return getMethod();
			}
			set
			{
				setMethod(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod28437;
		public virtual int getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipEntry.staticClass, "getMethod", "()I", ref global::java.util.zip.ZipEntry._getMethod28437);
		}
		public new long Size
		{
			get
			{
				return getSize();
			}
			set
			{
				setSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize28438;
		public virtual long getSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getSize", "()J", ref global::java.util.zip.ZipEntry._getSize28438);
		}
		internal static global::MonoJavaBridge.MethodId _setSize28439;
		public virtual void setSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setSize", "(J)V", ref global::java.util.zip.ZipEntry._setSize28439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirectory28440;
		public virtual bool isDirectory()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.zip.ZipEntry.staticClass, "isDirectory", "()Z", ref global::java.util.zip.ZipEntry._isDirectory28440);
		}
		internal static global::MonoJavaBridge.MethodId _setTime28441;
		public virtual void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setTime", "(J)V", ref global::java.util.zip.ZipEntry._setTime28441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Time
		{
			get
			{
				return getTime();
			}
			set
			{
				setTime(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTime28442;
		public virtual long getTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getTime", "()J", ref global::java.util.zip.ZipEntry._getTime28442);
		}
		public new long CompressedSize
		{
			get
			{
				return getCompressedSize();
			}
			set
			{
				setCompressedSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompressedSize28443;
		public virtual long getCompressedSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getCompressedSize", "()J", ref global::java.util.zip.ZipEntry._getCompressedSize28443);
		}
		internal static global::MonoJavaBridge.MethodId _setCompressedSize28444;
		public virtual void setCompressedSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setCompressedSize", "(J)V", ref global::java.util.zip.ZipEntry._setCompressedSize28444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCrc28445;
		public virtual void setCrc(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setCrc", "(J)V", ref global::java.util.zip.ZipEntry._setCrc28445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Crc
		{
			get
			{
				return getCrc();
			}
			set
			{
				setCrc(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCrc28446;
		public virtual long getCrc()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.ZipEntry.staticClass, "getCrc", "()J", ref global::java.util.zip.ZipEntry._getCrc28446);
		}
		internal static global::MonoJavaBridge.MethodId _setMethod28447;
		public virtual void setMethod(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setMethod", "(I)V", ref global::java.util.zip.ZipEntry._setMethod28447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtra28448;
		public virtual void setExtra(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setExtra", "([B)V", ref global::java.util.zip.ZipEntry._setExtra28448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new byte[] Extra
		{
			get
			{
				return getExtra();
			}
			set
			{
				setExtra(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtra28449;
		public virtual byte[] getExtra()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.util.zip.ZipEntry.staticClass, "getExtra", "()[B", ref global::java.util.zip.ZipEntry._getExtra28449) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setComment28450;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipEntry.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::java.util.zip.ZipEntry._setComment28450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			get
			{
				return getComment();
			}
			set
			{
				setComment(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComment28451;
		public virtual global::java.lang.String getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipEntry.staticClass, "getComment", "()Ljava/lang/String;", ref global::java.util.zip.ZipEntry._getComment28451) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ZipEntry28452;
		public ZipEntry(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipEntry._ZipEntry28452.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipEntry._ZipEntry28452 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ZipEntry28452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipEntry28453;
		public ZipEntry(java.util.zip.ZipEntry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipEntry._ZipEntry28453.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipEntry._ZipEntry28453 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipEntry.staticClass, "<init>", "(Ljava/util/zip/ZipEntry;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipEntry.staticClass, global::java.util.zip.ZipEntry._ZipEntry28453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int STORED
		{
			get
			{
				return 0;
			}
		}
		public static int DEFLATED
		{
			get
			{
				return 8;
			}
		}
		static ZipEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipEntry.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipEntry"));
		}
		internal static void InitJNI()
		{
		}
	}
}