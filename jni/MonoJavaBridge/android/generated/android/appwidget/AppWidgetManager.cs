namespace android.appwidget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AppWidgetManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AppWidgetManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.appwidget.AppWidgetManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.appwidget.AppWidgetManager(@__env);
			}
		}
		protected AppWidgetManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance964;
		public static global::android.appwidget.AppWidgetManager getInstance(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetManager>(@__env, @__env.CallStaticObjectMethodPtr(android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getInstance964, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAppWidgetInfo965;
		public virtual global::android.appwidget.AppWidgetProviderInfo getAppWidgetInfo(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetProviderInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetManager._getAppWidgetInfo965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.appwidget.AppWidgetProviderInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getAppWidgetInfo965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateAppWidget966;
		public virtual void updateAppWidget(android.content.ComponentName arg0, android.widget.RemoteViews arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetManager._updateAppWidget966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._updateAppWidget966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateAppWidget967;
		public virtual void updateAppWidget(int[] arg0, android.widget.RemoteViews arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetManager._updateAppWidget967, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._updateAppWidget967, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateAppWidget968;
		public virtual void updateAppWidget(int arg0, android.widget.RemoteViews arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetManager._updateAppWidget968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._updateAppWidget968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstalledProviders969;
		public virtual global::java.util.List getInstalledProviders() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetManager._getInstalledProviders969));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getInstalledProviders969));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindAppWidgetId970;
		public virtual void bindAppWidgetId(int arg0, android.content.ComponentName arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.appwidget.AppWidgetManager._bindAppWidgetId970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._bindAppWidgetId970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAppWidgetIds971;
		public virtual int[] getAppWidgetIds(android.content.ComponentName arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.appwidget.AppWidgetManager._getAppWidgetIds971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.appwidget.AppWidgetManager.staticClass, global::android.appwidget.AppWidgetManager._getAppWidgetIds971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		public static global::java.lang.String ACTION_APPWIDGET_PICK
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_PICK";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_CONFIGURE
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_CONFIGURE";
			}
		}
		public static global::java.lang.String EXTRA_APPWIDGET_ID
		{
			get
			{
				return "appWidgetId";
			}
		}
		public static global::java.lang.String EXTRA_APPWIDGET_IDS
		{
			get
			{
				return "appWidgetIds";
			}
		}
		public static global::java.lang.String EXTRA_CUSTOM_INFO
		{
			get
			{
				return "customInfo";
			}
		}
		public static global::java.lang.String EXTRA_CUSTOM_EXTRAS
		{
			get
			{
				return "customExtras";
			}
		}
		public static int INVALID_APPWIDGET_ID
		{
			get
			{
				return 0;
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_UPDATE
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_UPDATE";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_DELETED
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_DELETED";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_DISABLED
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_DISABLED";
			}
		}
		public static global::java.lang.String ACTION_APPWIDGET_ENABLED
		{
			get
			{
				return "android.appwidget.action.APPWIDGET_ENABLED";
			}
		}
		public static global::java.lang.String META_DATA_APPWIDGET_PROVIDER
		{
			get
			{
				return "android.appwidget.provider";
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.appwidget.AppWidgetManager.staticClass = @__class;
			global::android.appwidget.AppWidgetManager._getInstance964 = @__env.GetStaticMethodID(global::android.appwidget.AppWidgetManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/appwidget/AppWidgetManager;");
			global::android.appwidget.AppWidgetManager._getAppWidgetInfo965 = @__env.GetMethodID(global::android.appwidget.AppWidgetManager.staticClass, "getAppWidgetInfo", "(I)Landroid/appwidget/AppWidgetProviderInfo;");
			global::android.appwidget.AppWidgetManager._updateAppWidget966 = @__env.GetMethodID(global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "(Landroid/content/ComponentName;Landroid/widget/RemoteViews;)V");
			global::android.appwidget.AppWidgetManager._updateAppWidget967 = @__env.GetMethodID(global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "([ILandroid/widget/RemoteViews;)V");
			global::android.appwidget.AppWidgetManager._updateAppWidget968 = @__env.GetMethodID(global::android.appwidget.AppWidgetManager.staticClass, "updateAppWidget", "(ILandroid/widget/RemoteViews;)V");
			global::android.appwidget.AppWidgetManager._getInstalledProviders969 = @__env.GetMethodID(global::android.appwidget.AppWidgetManager.staticClass, "getInstalledProviders", "()Ljava/util/List;");
			global::android.appwidget.AppWidgetManager._bindAppWidgetId970 = @__env.GetMethodID(global::android.appwidget.AppWidgetManager.staticClass, "bindAppWidgetId", "(ILandroid/content/ComponentName;)V");
			global::android.appwidget.AppWidgetManager._getAppWidgetIds971 = @__env.GetMethodID(global::android.appwidget.AppWidgetManager.staticClass, "getAppWidgetIds", "(Landroid/content/ComponentName;)[I");
		}
	}
}
