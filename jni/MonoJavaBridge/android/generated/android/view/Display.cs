namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Display : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Display()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.Display), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.Display(@__env);
			}
		}
		protected Display(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth8412;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Display._getWidth8412);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getWidth8412);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight8413;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Display._getHeight8413);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getHeight8413);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation8414;
		public virtual int getOrientation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Display._getOrientation8414);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getOrientation8414);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayId8415;
		public virtual int getDisplayId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Display._getDisplayId8415);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getDisplayId8415);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRotation8416;
		public virtual int getRotation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Display._getRotation8416);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getRotation8416);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPixelFormat8417;
		public virtual int getPixelFormat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Display._getPixelFormat8417);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getPixelFormat8417);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRefreshRate8418;
		public virtual float getRefreshRate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.Display._getRefreshRate8418);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getRefreshRate8418);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetrics8419;
		public virtual void getMetrics(android.util.DisplayMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Display._getMetrics8419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Display.staticClass, global::android.view.Display._getMetrics8419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static int DEFAULT_DISPLAY
		{
			get
			{
				return 0;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.Display.staticClass = @__class;
			global::android.view.Display._getWidth8412 = @__env.GetMethodID(global::android.view.Display.staticClass, "getWidth", "()I");
			global::android.view.Display._getHeight8413 = @__env.GetMethodID(global::android.view.Display.staticClass, "getHeight", "()I");
			global::android.view.Display._getOrientation8414 = @__env.GetMethodID(global::android.view.Display.staticClass, "getOrientation", "()I");
			global::android.view.Display._getDisplayId8415 = @__env.GetMethodID(global::android.view.Display.staticClass, "getDisplayId", "()I");
			global::android.view.Display._getRotation8416 = @__env.GetMethodID(global::android.view.Display.staticClass, "getRotation", "()I");
			global::android.view.Display._getPixelFormat8417 = @__env.GetMethodID(global::android.view.Display.staticClass, "getPixelFormat", "()I");
			global::android.view.Display._getRefreshRate8418 = @__env.GetMethodID(global::android.view.Display.staticClass, "getRefreshRate", "()F");
			global::android.view.Display._getMetrics8419 = @__env.GetMethodID(global::android.view.Display.staticClass, "getMetrics", "(Landroid/util/DisplayMetrics;)V");
		}
	}
}
