namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditText : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EditText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText16992;
		public override void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", ref global::android.widget.EditText._setText16992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _selectAll16993;
		public virtual void selectAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "selectAll", "()V", ref global::android.widget.EditText._selectAll16993);
		}
		public new global::android.text.Editable Text
		{
			get
			{
				return getText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText16994;
		public virtual global::android.text.Editable getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.widget.EditText.staticClass, "getText", "()Landroid/text/Editable;", ref global::android.widget.EditText._getText16994) as android.text.Editable;
		}
		public new int Selection
		{
			set
			{
				setSelection(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16995;
		public virtual void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setSelection", "(I)V", ref global::android.widget.EditText._setSelection16995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16996;
		public virtual void setSelection(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setSelection", "(II)V", ref global::android.widget.EditText._setSelection16996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEditable16997;
		protected override bool getDefaultEditable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.EditText.staticClass, "getDefaultEditable", "()Z", ref global::android.widget.EditText._getDefaultEditable16997);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMovementMethod16998;
		protected override global::android.text.method.MovementMethod getDefaultMovementMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.MovementMethod>(this, global::android.widget.EditText.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", ref global::android.widget.EditText._getDefaultMovementMethod16998) as android.text.method.MovementMethod;
		}
		public new global::android.text.TextUtils.TruncateAt Ellipsize
		{
			set
			{
				setEllipsize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEllipsize16999;
		public override void setEllipsize(android.text.TextUtils.TruncateAt arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", ref global::android.widget.EditText._setEllipsize16999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extendSelection17000;
		public virtual void extendSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.EditText.staticClass, "extendSelection", "(I)V", ref global::android.widget.EditText._extendSelection17000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _EditText17001;
		public EditText(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.EditText._EditText17001.native == global::System.IntPtr.Zero)
				global::android.widget.EditText._EditText17001 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText17001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditText17002;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.EditText._EditText17002.native == global::System.IntPtr.Zero)
				global::android.widget.EditText._EditText17002 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText17002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EditText17003;
		public EditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.EditText._EditText17003.native == global::System.IntPtr.Zero)
				global::android.widget.EditText._EditText17003 = @__env.GetMethodIDNoThrow(global::android.widget.EditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.EditText.staticClass, global::android.widget.EditText._EditText17003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static EditText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.EditText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/EditText"));
		}
		internal static void InitJNI()
		{
		}
	}
}