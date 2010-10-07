namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SeekBar : android.widget.AbsSeekBar
	{
		internal new static global::java.lang.Class staticClass;
		static SeekBar()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SeekBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.SeekBar(@__env);
			}
		}
		protected SeekBar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnSeekBarChangeListener 
		{
			void onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2);
			void onStartTrackingTouch(android.widget.SeekBar arg0);
			void onStopTrackingTouch(android.widget.SeekBar arg0);
		}

		public partial class OnSeekBarChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnSeekBarChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnSeekBarChangeListener : java.lang.Object, OnSeekBarChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnSeekBarChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SeekBar.__OnSeekBarChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SeekBar.__OnSeekBarChangeListener(@__env);
				}
			}
			internal __OnSeekBarChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onProgressChanged11512;
			 void android.widget.SeekBar.OnSeekBarChangeListener.onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SeekBar.__OnSeekBarChangeListener._onProgressChanged11512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SeekBar.__OnSeekBarChangeListener.staticClass, global::android.widget.SeekBar.__OnSeekBarChangeListener._onProgressChanged11512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onStartTrackingTouch11513;
			 void android.widget.SeekBar.OnSeekBarChangeListener.onStartTrackingTouch(android.widget.SeekBar arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SeekBar.__OnSeekBarChangeListener._onStartTrackingTouch11513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SeekBar.__OnSeekBarChangeListener.staticClass, global::android.widget.SeekBar.__OnSeekBarChangeListener._onStartTrackingTouch11513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onStopTrackingTouch11514;
			 void android.widget.SeekBar.OnSeekBarChangeListener.onStopTrackingTouch(android.widget.SeekBar arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SeekBar.__OnSeekBarChangeListener._onStopTrackingTouch11514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SeekBar.__OnSeekBarChangeListener.staticClass, global::android.widget.SeekBar.__OnSeekBarChangeListener._onStopTrackingTouch11514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SeekBar.__OnSeekBarChangeListener.staticClass = @__class;
				global::android.widget.SeekBar.__OnSeekBarChangeListener._onProgressChanged11512 = @__env.GetMethodID(global::android.widget.SeekBar.__OnSeekBarChangeListener.staticClass, "android.widget.SeekBar.OnSeekBarChangeListener.onProgressChanged", "(Landroid/widget/SeekBar;IZ)V");
				global::android.widget.SeekBar.__OnSeekBarChangeListener._onStartTrackingTouch11513 = @__env.GetMethodID(global::android.widget.SeekBar.__OnSeekBarChangeListener.staticClass, "android.widget.SeekBar.OnSeekBarChangeListener.onStartTrackingTouch", "(Landroid/widget/SeekBar;)V");
				global::android.widget.SeekBar.__OnSeekBarChangeListener._onStopTrackingTouch11514 = @__env.GetMethodID(global::android.widget.SeekBar.__OnSeekBarChangeListener.staticClass, "android.widget.SeekBar.OnSeekBarChangeListener.onStopTrackingTouch", "(Landroid/widget/SeekBar;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnSeekBarChangeListener11515;
		public virtual void setOnSeekBarChangeListener(android.widget.SeekBar.OnSeekBarChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SeekBar._setOnSeekBarChangeListener11515, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SeekBar.staticClass, global::android.widget.SeekBar._setOnSeekBarChangeListener11515, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SeekBar11516;
		public SeekBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar11516, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SeekBar11517;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar11517, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SeekBar11518;
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SeekBar.staticClass, global::android.widget.SeekBar._SeekBar11518, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.SeekBar.staticClass = @__class;
			global::android.widget.SeekBar._setOnSeekBarChangeListener11515 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V");
			global::android.widget.SeekBar._SeekBar11516 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.SeekBar._SeekBar11517 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.SeekBar._SeekBar11518 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
