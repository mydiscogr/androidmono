namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccountManager()
		{
			InitJNI();
		}
		protected AccountManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get74;
		public static global::android.accounts.AccountManager get(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._get74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.AccountManager;
		}
		internal static global::MonoJavaBridge.MethodId _setPassword75;
		public virtual void setPassword(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManager._setPassword75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._setPassword75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _editProperties76;
		public virtual global::android.accounts.AccountManagerFuture editProperties(java.lang.String arg0, android.app.Activity arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._editProperties76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._editProperties76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _addAccount77;
		public virtual global::android.accounts.AccountManagerFuture addAccount(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.os.Bundle arg3, android.app.Activity arg4, android.accounts.AccountManagerCallback arg5, android.os.Handler arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._addAccount77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._addAccount77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _confirmCredentials78;
		public virtual global::android.accounts.AccountManagerFuture confirmCredentials(android.accounts.Account arg0, android.os.Bundle arg1, android.app.Activity arg2, android.accounts.AccountManagerCallback arg3, android.os.Handler arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._confirmCredentials78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._confirmCredentials78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthToken79;
		public virtual global::android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, bool arg2, android.accounts.AccountManagerCallback arg3, android.os.Handler arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getAuthToken79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthToken79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthToken80;
		public virtual global::android.accounts.AccountManagerFuture getAuthToken(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, android.accounts.AccountManagerCallback arg4, android.os.Handler arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getAuthToken80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthToken80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _updateCredentials81;
		public virtual global::android.accounts.AccountManagerFuture updateCredentials(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, android.app.Activity arg3, android.accounts.AccountManagerCallback arg4, android.os.Handler arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._updateCredentials81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._updateCredentials81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _hasFeatures82;
		public virtual global::android.accounts.AccountManagerFuture hasFeatures(android.accounts.Account arg0, java.lang.String[] arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._hasFeatures82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._hasFeatures82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _getPassword83;
		public virtual global::java.lang.String getPassword(android.accounts.Account arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getPassword83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getPassword83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserData84;
		public virtual global::java.lang.String getUserData(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getUserData84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getUserData84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthenticatorTypes85;
		public virtual global::android.accounts.AuthenticatorDescription[] getAuthenticatorTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.accounts.AuthenticatorDescription>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getAuthenticatorTypes85)) as android.accounts.AuthenticatorDescription[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.accounts.AuthenticatorDescription>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthenticatorTypes85)) as android.accounts.AuthenticatorDescription[];
		}
		internal static global::MonoJavaBridge.MethodId _getAccounts86;
		public virtual global::android.accounts.Account[] getAccounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.accounts.Account>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getAccounts86)) as android.accounts.Account[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.accounts.Account>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAccounts86)) as android.accounts.Account[];
		}
		internal static global::MonoJavaBridge.MethodId _getAccountsByType87;
		public virtual global::android.accounts.Account[] getAccountsByType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.accounts.Account>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getAccountsByType87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.Account[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.accounts.Account>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAccountsByType87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.Account[];
		}
		internal static global::MonoJavaBridge.MethodId _getAccountsByTypeAndFeatures88;
		public virtual global::android.accounts.AccountManagerFuture getAccountsByTypeAndFeatures(java.lang.String arg0, java.lang.String[] arg1, android.accounts.AccountManagerCallback arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getAccountsByTypeAndFeatures88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAccountsByTypeAndFeatures88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _addAccountExplicitly89;
		public virtual bool addAccountExplicitly(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.accounts.AccountManager._addAccountExplicitly89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._addAccountExplicitly89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAccount90;
		public virtual global::android.accounts.AccountManagerFuture removeAccount(android.accounts.Account arg0, android.accounts.AccountManagerCallback arg1, android.os.Handler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._removeAccount90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._removeAccount90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateAuthToken91;
		public virtual void invalidateAuthToken(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManager._invalidateAuthToken91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._invalidateAuthToken91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _peekAuthToken92;
		public virtual global::java.lang.String peekAuthToken(android.accounts.Account arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._peekAuthToken92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._peekAuthToken92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearPassword93;
		public virtual void clearPassword(android.accounts.Account arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManager._clearPassword93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._clearPassword93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUserData94;
		public virtual void setUserData(android.accounts.Account arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManager._setUserData94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._setUserData94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthToken95;
		public virtual void setAuthToken(android.accounts.Account arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManager._setAuthToken95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._setAuthToken95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _blockingGetAuthToken96;
		public virtual global::java.lang.String blockingGetAuthToken(android.accounts.Account arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._blockingGetAuthToken96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._blockingGetAuthToken96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthTokenByFeatures97;
		public virtual global::android.accounts.AccountManagerFuture getAuthTokenByFeatures(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, android.app.Activity arg3, android.os.Bundle arg4, android.os.Bundle arg5, android.accounts.AccountManagerCallback arg6, android.os.Handler arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AccountManager._getAuthTokenByFeatures97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.accounts.AccountManagerFuture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.accounts.AccountManagerFuture>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._getAuthTokenByFeatures97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.accounts.AccountManagerFuture;
		}
		internal static global::MonoJavaBridge.MethodId _addOnAccountsUpdatedListener98;
		public virtual void addOnAccountsUpdatedListener(android.accounts.OnAccountsUpdateListener arg0, android.os.Handler arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManager._addOnAccountsUpdatedListener98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._addOnAccountsUpdatedListener98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnAccountsUpdatedListener99;
		public virtual void removeOnAccountsUpdatedListener(android.accounts.OnAccountsUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountManager._removeOnAccountsUpdatedListener99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountManager.staticClass, global::android.accounts.AccountManager._removeOnAccountsUpdatedListener99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int ERROR_CODE_REMOTE_EXCEPTION
		{
			get
			{
				return 1;
			}
		}
		public static int ERROR_CODE_NETWORK_ERROR
		{
			get
			{
				return 3;
			}
		}
		public static int ERROR_CODE_CANCELED
		{
			get
			{
				return 4;
			}
		}
		public static int ERROR_CODE_INVALID_RESPONSE
		{
			get
			{
				return 5;
			}
		}
		public static int ERROR_CODE_UNSUPPORTED_OPERATION
		{
			get
			{
				return 6;
			}
		}
		public static int ERROR_CODE_BAD_ARGUMENTS
		{
			get
			{
				return 7;
			}
		}
		public static int ERROR_CODE_BAD_REQUEST
		{
			get
			{
				return 8;
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_NAME
		{
			get
			{
				return "authAccount";
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_TYPE
		{
			get
			{
				return "accountType";
			}
		}
		public static global::java.lang.String KEY_AUTHTOKEN
		{
			get
			{
				return "authtoken";
			}
		}
		public static global::java.lang.String KEY_INTENT
		{
			get
			{
				return "intent";
			}
		}
		public static global::java.lang.String KEY_PASSWORD
		{
			get
			{
				return "password";
			}
		}
		public static global::java.lang.String KEY_ACCOUNTS
		{
			get
			{
				return "accounts";
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_AUTHENTICATOR_RESPONSE
		{
			get
			{
				return "accountAuthenticatorResponse";
			}
		}
		public static global::java.lang.String KEY_ACCOUNT_MANAGER_RESPONSE
		{
			get
			{
				return "accountManagerResponse";
			}
		}
		public static global::java.lang.String KEY_AUTHENTICATOR_TYPES
		{
			get
			{
				return "authenticator_types";
			}
		}
		public static global::java.lang.String KEY_AUTH_FAILED_MESSAGE
		{
			get
			{
				return "authFailedMessage";
			}
		}
		public static global::java.lang.String KEY_AUTH_TOKEN_LABEL
		{
			get
			{
				return "authTokenLabelKey";
			}
		}
		public static global::java.lang.String KEY_BOOLEAN_RESULT
		{
			get
			{
				return "booleanResult";
			}
		}
		public static global::java.lang.String KEY_ERROR_CODE
		{
			get
			{
				return "errorCode";
			}
		}
		public static global::java.lang.String KEY_ERROR_MESSAGE
		{
			get
			{
				return "errorMessage";
			}
		}
		public static global::java.lang.String KEY_USERDATA
		{
			get
			{
				return "userdata";
			}
		}
		public static global::java.lang.String ACTION_AUTHENTICATOR_INTENT
		{
			get
			{
				return "android.accounts.AccountAuthenticator";
			}
		}
		public static global::java.lang.String AUTHENTICATOR_META_DATA_NAME
		{
			get
			{
				return "android.accounts.AccountAuthenticator";
			}
		}
		public static global::java.lang.String AUTHENTICATOR_ATTRIBUTES_NAME
		{
			get
			{
				return "account-authenticator";
			}
		}
		public static global::java.lang.String LOGIN_ACCOUNTS_CHANGED_ACTION
		{
			get
			{
				return "android.accounts.LOGIN_ACCOUNTS_CHANGED";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountManager"));
			global::android.accounts.AccountManager._get74 = @__env.GetStaticMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "get", "(Landroid/content/Context;)Landroid/accounts/AccountManager;");
			global::android.accounts.AccountManager._setPassword75 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "setPassword", "(Landroid/accounts/Account;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._editProperties76 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "editProperties", "(Ljava/lang/String;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._addAccount77 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "addAccount", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._confirmCredentials78 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "confirmCredentials", "(Landroid/accounts/Account;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._getAuthToken79 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;ZLandroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._getAuthToken80 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._updateCredentials81 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "updateCredentials", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._hasFeatures82 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "hasFeatures", "(Landroid/accounts/Account;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._getPassword83 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getPassword", "(Landroid/accounts/Account;)Ljava/lang/String;");
			global::android.accounts.AccountManager._getUserData84 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getUserData", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;");
			global::android.accounts.AccountManager._getAuthenticatorTypes85 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getAuthenticatorTypes", "()[Landroid/accounts/AuthenticatorDescription;");
			global::android.accounts.AccountManager._getAccounts86 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getAccounts", "()[Landroid/accounts/Account;");
			global::android.accounts.AccountManager._getAccountsByType87 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getAccountsByType", "(Ljava/lang/String;)[Landroid/accounts/Account;");
			global::android.accounts.AccountManager._getAccountsByTypeAndFeatures88 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getAccountsByTypeAndFeatures", "(Ljava/lang/String;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._addAccountExplicitly89 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "addAccountExplicitly", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.accounts.AccountManager._removeAccount90 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "removeAccount", "(Landroid/accounts/Account;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._invalidateAuthToken91 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "invalidateAuthToken", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._peekAuthToken92 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "peekAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;");
			global::android.accounts.AccountManager._clearPassword93 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "clearPassword", "(Landroid/accounts/Account;)V");
			global::android.accounts.AccountManager._setUserData94 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "setUserData", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._setAuthToken95 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "setAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.AccountManager._blockingGetAuthToken96 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "blockingGetAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Z)Ljava/lang/String;");
			global::android.accounts.AccountManager._getAuthTokenByFeatures97 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "getAuthTokenByFeatures", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/app/Activity;Landroid/os/Bundle;Landroid/os/Bundle;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;");
			global::android.accounts.AccountManager._addOnAccountsUpdatedListener98 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "addOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;Landroid/os/Handler;Z)V");
			global::android.accounts.AccountManager._removeOnAccountsUpdatedListener99 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountManager.staticClass, "removeOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;)V");
		}
	}
}
