namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService_))]
	public abstract partial class AbstractInputMethodService : android.app.Service, android.view.KeyEvent.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractInputMethodService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_))]
		public abstract partial class AbstractInputMethodImpl : java.lang.Object, android.view.inputmethod.InputMethod
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AbstractInputMethodImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _attachToken6527;
			public abstract void attachToken(android.os.IBinder arg0);
			internal static global::MonoJavaBridge.MethodId _bindInput6528;
			public abstract void bindInput(android.view.inputmethod.InputBinding arg0);
			internal static global::MonoJavaBridge.MethodId _unbindInput6529;
			public abstract void unbindInput();
			internal static global::MonoJavaBridge.MethodId _startInput6530;
			public abstract void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _restartInput6531;
			public abstract void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1);
			internal static global::MonoJavaBridge.MethodId _showSoftInput6532;
			public abstract void showSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _hideSoftInput6533;
			public abstract void hideSoftInput(int arg0, android.os.ResultReceiver arg1);
			internal static global::MonoJavaBridge.MethodId _createSession6534;
			public virtual void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._createSession6534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public void createSession(global::android.view.inputmethod.InputMethod_SessionCallbackDelegate arg0)
			{
				createSession((global::android.view.inputmethod.InputMethod_SessionCallbackDelegateWrapper)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setSessionEnabled6535;
			public virtual void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._setSessionEnabled6535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _revokeSession6536;
			public virtual void revokeSession(android.view.inputmethod.InputMethodSession arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._revokeSession6536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodImpl6537;
			public AbstractInputMethodImpl(android.inputmethodservice.AbstractInputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl6537.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl6537 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl._AbstractInputMethodImpl6537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AbstractInputMethodImpl()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl))]
		internal sealed partial class AbstractInputMethodImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AbstractInputMethodImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _attachToken6538;
			public override void attachToken(android.os.IBinder arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "attachToken", "(Landroid/os/IBinder;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._attachToken6538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _bindInput6539;
			public override void bindInput(android.view.inputmethod.InputBinding arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "bindInput", "(Landroid/view/inputmethod/InputBinding;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._bindInput6539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _unbindInput6540;
			public override void unbindInput()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "unbindInput", "()V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._unbindInput6540);
			}
			internal static global::MonoJavaBridge.MethodId _startInput6541;
			public override void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._startInput6541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _restartInput6542;
			public override void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._restartInput6542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _showSoftInput6543;
			public override void showSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "showSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._showSoftInput6543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _hideSoftInput6544;
			public override void hideSoftInput(int arg0, android.os.ResultReceiver arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass, "hideSoftInput", "(ILandroid/os/ResultReceiver;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_._hideSoftInput6544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static AbstractInputMethodImpl_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_))]
		public abstract partial class AbstractInputMethodSessionImpl : java.lang.Object, android.view.inputmethod.InputMethodSession
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AbstractInputMethodSessionImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finishInput6545;
			public abstract void finishInput();
			internal static global::MonoJavaBridge.MethodId _updateSelection6546;
			public abstract void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
			internal static global::MonoJavaBridge.MethodId _updateCursor6547;
			public abstract void updateCursor(android.graphics.Rect arg0);
			internal static global::MonoJavaBridge.MethodId _displayCompletions6548;
			public abstract void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0);
			internal static global::MonoJavaBridge.MethodId _updateExtractedText6549;
			public abstract void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1);
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand6550;
			public abstract void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput6551;
			public abstract void toggleSoftInput(int arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _isEnabled6552;
			public virtual bool isEnabled()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isEnabled", "()Z", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isEnabled6552);
			}
			internal static global::MonoJavaBridge.MethodId _setEnabled6553;
			public virtual void setEnabled(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "setEnabled", "(Z)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._setEnabled6553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent6554;
			public virtual void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchKeyEvent6554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			public void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, global::android.view.inputmethod.InputMethodSession_EventCallbackDelegate arg2)
			{
				dispatchKeyEvent(arg0, arg1, (global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent6555;
			public virtual void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCallback;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._dispatchTrackballEvent6555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			public void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, global::android.view.inputmethod.InputMethodSession_EventCallbackDelegate arg2)
			{
				dispatchTrackballEvent(arg0, arg1, (global::android.view.inputmethod.InputMethodSession_EventCallbackDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _isRevoked6556;
			public virtual bool isRevoked()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "isRevoked", "()Z", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._isRevoked6556);
			}
			internal static global::MonoJavaBridge.MethodId _revokeSelf6557;
			public virtual void revokeSelf()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "revokeSelf", "()V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._revokeSelf6557);
			}
			internal static global::MonoJavaBridge.MethodId _AbstractInputMethodSessionImpl6558;
			public AbstractInputMethodSessionImpl(android.inputmethodservice.AbstractInputMethodService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl6558.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl6558 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, "<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl._AbstractInputMethodSessionImpl6558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AbstractInputMethodSessionImpl()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl))]
		internal sealed partial class AbstractInputMethodSessionImpl_ : android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AbstractInputMethodSessionImpl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finishInput6559;
			public override void finishInput()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "finishInput", "()V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._finishInput6559);
			}
			internal static global::MonoJavaBridge.MethodId _updateSelection6560;
			public override void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateSelection", "(IIIIII)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateSelection6560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _updateCursor6561;
			public override void updateCursor(android.graphics.Rect arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateCursor", "(Landroid/graphics/Rect;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateCursor6561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _displayCompletions6562;
			public override void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._displayCompletions6562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _updateExtractedText6563;
			public override void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._updateExtractedText6563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _appPrivateCommand6564;
			public override void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._appPrivateCommand6564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _toggleSoftInput6565;
			public override void toggleSoftInput(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass, "toggleSoftInput", "(II)V", ref global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_._toggleSoftInput6565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static AbstractInputMethodSessionImpl_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown6566;
		public abstract bool onKeyDown(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress6567;
		public abstract bool onKeyLongPress(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyUp6568;
		public abstract bool onKeyUp(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple6569;
		public abstract bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2);
		internal static global::MonoJavaBridge.MethodId _onBind6570;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.inputmethodservice.AbstractInputMethodService._onBind6570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _dump6571;
		protected override void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ref global::android.inputmethodservice.AbstractInputMethodService._dump6571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent6572;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService._onTrackballEvent6572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyDispatcherState6573;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.AbstractInputMethodService.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", ref global::android.inputmethodservice.AbstractInputMethodService._getKeyDispatcherState6573) as android.view.KeyEvent.DispatcherState;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface6574;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface();
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface6575;
		public abstract global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface();
		internal static global::MonoJavaBridge.MethodId _AbstractInputMethodService6576;
		public AbstractInputMethodService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService6576.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService6576 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.AbstractInputMethodService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.AbstractInputMethodService.staticClass, global::android.inputmethodservice.AbstractInputMethodService._AbstractInputMethodService6576);
			Init(@__env, handle);
		}
		static AbstractInputMethodService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.inputmethodservice.AbstractInputMethodService))]
	internal sealed partial class AbstractInputMethodService_ : android.inputmethodservice.AbstractInputMethodService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractInputMethodService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown6577;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._onKeyDown6577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress6578;
		public override bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._onKeyLongPress6578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp6579;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._onKeyUp6579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple6580;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.inputmethodservice.AbstractInputMethodService_._onKeyMultiple6580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodInterface6581;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl onCreateInputMethodInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;", ref global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodInterface6581) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputMethodSessionInterface6582;
		public override global::android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl onCreateInputMethodSessionInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.AbstractInputMethodService_.staticClass, "onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl;", ref global::android.inputmethodservice.AbstractInputMethodService_._onCreateInputMethodSessionInterface6582) as android.inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl;
		}
		static AbstractInputMethodService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.AbstractInputMethodService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/AbstractInputMethodService"));
		}
		internal static void InitJNI()
		{
		}
	}
}