namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class MultiTapKeyListener : android.text.method.BaseKeyListener, SpanWatcher
	{
		internal new static global::java.lang.Class staticClass;
		static MultiTapKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.MultiTapKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.MultiTapKeyListener(@__env);
			}
		}
		protected MultiTapKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7825;
		public static global::android.text.method.MultiTapKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.MultiTapKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._getInstance7825, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7826;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.MultiTapKeyListener._onKeyDown7826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onKeyDown7826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7827;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.MultiTapKeyListener._getInputType7827);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._getInputType7827);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSpanAdded7828;
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.MultiTapKeyListener._onSpanAdded7828, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onSpanAdded7828, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSpanRemoved7829;
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.MultiTapKeyListener._onSpanRemoved7829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onSpanRemoved7829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSpanChanged7830;
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.MultiTapKeyListener._onSpanChanged7830, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onSpanChanged7830, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MultiTapKeyListener7831;
		public MultiTapKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._MultiTapKeyListener7831, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.MultiTapKeyListener.staticClass = @__class;
			global::android.text.method.MultiTapKeyListener._getInstance7825 = @__env.GetStaticMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/MultiTapKeyListener;");
			global::android.text.method.MultiTapKeyListener._onKeyDown7826 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.MultiTapKeyListener._getInputType7827 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.MultiTapKeyListener._onSpanAdded7828 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.MultiTapKeyListener._onSpanRemoved7829 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.MultiTapKeyListener._onSpanChanged7830 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V");
			global::android.text.method.MultiTapKeyListener._MultiTapKeyListener7831 = @__env.GetMethodID(global::android.text.method.MultiTapKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
		}
	}
}
