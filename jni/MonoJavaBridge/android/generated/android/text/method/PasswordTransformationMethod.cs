namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PasswordTransformationMethod : java.lang.Object, TransformationMethod, TextWatcher
	{
		internal static global::java.lang.Class staticClass;
		static PasswordTransformationMethod()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.PasswordTransformationMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.PasswordTransformationMethod(@__env);
			}
		}
		protected PasswordTransformationMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7838;
		public static global::android.text.method.PasswordTransformationMethod getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.PasswordTransformationMethod>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._getInstance7838));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged7839;
		public virtual void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod._onFocusChanged7839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._onFocusChanged7839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		public void onFocusChanged(android.view.View arg0, string arg1, bool arg2, int arg3, android.graphics.Rect arg4)
		{
			onFocusChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged7840;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod._onTextChanged7840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._onTextChanged7840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged7841;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod._beforeTextChanged7841, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._beforeTextChanged7841, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged7842;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.PasswordTransformationMethod._afterTextChanged7842, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._afterTextChanged7842, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation7843;
		public virtual global::java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.method.PasswordTransformationMethod._getTransformation7843, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._getTransformation7843, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		public java.lang.CharSequence getTransformation(string arg0, android.view.View arg1)
		{
			return getTransformation((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PasswordTransformationMethod7844;
		public PasswordTransformationMethod()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.PasswordTransformationMethod.staticClass, global::android.text.method.PasswordTransformationMethod._PasswordTransformationMethod7844, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.PasswordTransformationMethod.staticClass = @__class;
			global::android.text.method.PasswordTransformationMethod._getInstance7838 = @__env.GetStaticMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/PasswordTransformationMethod;");
			global::android.text.method.PasswordTransformationMethod._onFocusChanged7839 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V");
			global::android.text.method.PasswordTransformationMethod._onTextChanged7840 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.text.method.PasswordTransformationMethod._beforeTextChanged7841 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.text.method.PasswordTransformationMethod._afterTextChanged7842 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.text.method.PasswordTransformationMethod._getTransformation7843 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;");
			global::android.text.method.PasswordTransformationMethod._PasswordTransformationMethod7844 = @__env.GetMethodID(global::android.text.method.PasswordTransformationMethod.staticClass, "<init>", "()V");
		}
	}
}
