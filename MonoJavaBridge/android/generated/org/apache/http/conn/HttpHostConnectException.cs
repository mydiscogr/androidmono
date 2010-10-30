namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpHostConnectException : java.net.ConnectException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpHostConnectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.HttpHost Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost32110;
		public virtual global::org.apache.http.HttpHost getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.HttpHost>(this, global::org.apache.http.conn.HttpHostConnectException.staticClass, "getHost", "()Lorg/apache/http/HttpHost;", ref global::org.apache.http.conn.HttpHostConnectException._getHost32110) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _HttpHostConnectException32111;
		public HttpHostConnectException(org.apache.http.HttpHost arg0, java.net.ConnectException arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.HttpHostConnectException._HttpHostConnectException32111.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.HttpHostConnectException._HttpHostConnectException32111 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.HttpHostConnectException.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/ConnectException;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.HttpHostConnectException.staticClass, global::org.apache.http.conn.HttpHostConnectException._HttpHostConnectException32111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static HttpHostConnectException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.HttpHostConnectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/HttpHostConnectException"));
		}
		internal static void InitJNI()
		{
		}
	}
}