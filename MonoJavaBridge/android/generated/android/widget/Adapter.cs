namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Adapter_))]
	public partial interface Adapter  : global::MonoJavaBridge.IJavaObject 
	{
		bool isEmpty();
		int getCount();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		global::java.lang.Object getItem(int arg0);
		long getItemId(int arg0);
		bool hasStableIds();
		global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		int getItemViewType(int arg0);
		int getViewTypeCount();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Adapter))]
	internal sealed partial class Adapter_ : java.lang.Object, Adapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Adapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty16616;
		bool android.widget.Adapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Adapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.Adapter_._isEmpty16616);
		}
		internal static global::MonoJavaBridge.MethodId _getCount16617;
		int android.widget.Adapter.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Adapter_.staticClass, "getCount", "()I", ref global::android.widget.Adapter_._getCount16617);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver16618;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Adapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.Adapter_._registerDataSetObserver16618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver16619;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Adapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.Adapter_._unregisterDataSetObserver16619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem16620;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Adapter_.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.Adapter_._getItem16620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId16621;
		long android.widget.Adapter.getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.Adapter_.staticClass, "getItemId", "(I)J", ref global::android.widget.Adapter_._getItemId16621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16622;
		bool android.widget.Adapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Adapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.Adapter_._hasStableIds16622);
		}
		internal static global::MonoJavaBridge.MethodId _getView16623;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Adapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.Adapter_._getView16623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType16624;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Adapter_.staticClass, "getItemViewType", "(I)I", ref global::android.widget.Adapter_._getItemViewType16624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount16625;
		int android.widget.Adapter.getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Adapter_.staticClass, "getViewTypeCount", "()I", ref global::android.widget.Adapter_._getViewTypeCount16625);
		}
		static Adapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Adapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Adapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}