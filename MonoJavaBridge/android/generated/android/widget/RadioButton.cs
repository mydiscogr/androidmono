namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RadioButton : android.widget.CompoundButton
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RadioButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toggle17532;
		public override void toggle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RadioButton.staticClass, "toggle", "()V", ref global::android.widget.RadioButton._toggle17532);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton17533;
		public RadioButton(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RadioButton._RadioButton17533.native == global::System.IntPtr.Zero)
				global::android.widget.RadioButton._RadioButton17533 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton17533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton17534;
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RadioButton._RadioButton17534.native == global::System.IntPtr.Zero)
				global::android.widget.RadioButton._RadioButton17534 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton17534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton17535;
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RadioButton._RadioButton17535.native == global::System.IntPtr.Zero)
				global::android.widget.RadioButton._RadioButton17535 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton17535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RadioButton()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RadioButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioButton"));
		}
		internal static void InitJNI()
		{
		}
	}
}