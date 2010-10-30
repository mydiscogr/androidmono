namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Blob_))]
	public partial interface Blob  : global::MonoJavaBridge.IJavaObject 
	{
		long length();
		byte[] getBytes(long arg0, int arg1);
		long position(byte[] arg0, long arg1);
		long position(java.sql.Blob arg0, long arg1);
		void truncate(long arg0);
		void free();
		global::java.io.InputStream getBinaryStream(long arg0, long arg1);
		global::java.io.InputStream getBinaryStream();
		int setBytes(long arg0, byte[] arg1, int arg2, int arg3);
		int setBytes(long arg0, byte[] arg1);
		global::java.io.OutputStream setBinaryStream(long arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Blob))]
	internal sealed partial class Blob_ : java.lang.Object, Blob
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Blob_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length24102;
		long java.sql.Blob.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Blob_.staticClass, "length", "()J", ref global::java.sql.Blob_._length24102);
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24103;
		byte[] java.sql.Blob.getBytes(long arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.sql.Blob_.staticClass, "getBytes", "(JI)[B", ref global::java.sql.Blob_._getBytes24103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _position24104;
		long java.sql.Blob.position(byte[] arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Blob_.staticClass, "position", "([BJ)J", ref global::java.sql.Blob_._position24104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _position24105;
		long java.sql.Blob.position(java.sql.Blob arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Blob_.staticClass, "position", "(Ljava/sql/Blob;J)J", ref global::java.sql.Blob_._position24105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _truncate24106;
		void java.sql.Blob.truncate(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Blob_.staticClass, "truncate", "(J)V", ref global::java.sql.Blob_._truncate24106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _free24107;
		void java.sql.Blob.free()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Blob_.staticClass, "free", "()V", ref global::java.sql.Blob_._free24107);
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream24108;
		global::java.io.InputStream java.sql.Blob.getBinaryStream(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Blob_.staticClass, "getBinaryStream", "(JJ)Ljava/io/InputStream;", ref global::java.sql.Blob_._getBinaryStream24108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream24109;
		global::java.io.InputStream java.sql.Blob.getBinaryStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Blob_.staticClass, "getBinaryStream", "()Ljava/io/InputStream;", ref global::java.sql.Blob_._getBinaryStream24109) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24110;
		int java.sql.Blob.setBytes(long arg0, byte[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Blob_.staticClass, "setBytes", "(J[BII)I", ref global::java.sql.Blob_._setBytes24110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24111;
		int java.sql.Blob.setBytes(long arg0, byte[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Blob_.staticClass, "setBytes", "(J[B)I", ref global::java.sql.Blob_._setBytes24111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24112;
		global::java.io.OutputStream java.sql.Blob.setBinaryStream(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Blob_.staticClass, "setBinaryStream", "(J)Ljava/io/OutputStream;", ref global::java.sql.Blob_._setBinaryStream24112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.OutputStream;
		}
		static Blob_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Blob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Blob"));
		}
		internal static void InitJNI()
		{
		}
	}
}