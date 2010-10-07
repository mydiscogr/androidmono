namespace android.speech
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RecognizerIntent : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static RecognizerIntent()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.RecognizerIntent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.speech.RecognizerIntent(@__env);
			}
		}
		protected RecognizerIntent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceDetailsIntent7028;
		public static global::android.content.Intent getVoiceDetailsIntent(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallStaticObjectMethodPtr(android.speech.RecognizerIntent.staticClass, global::android.speech.RecognizerIntent._getVoiceDetailsIntent7028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		public static global::java.lang.String EXTRA_CALLING_PACKAGE
		{
			get
			{
				return "calling_package";
			}
		}
		public static global::java.lang.String ACTION_RECOGNIZE_SPEECH
		{
			get
			{
				return "android.speech.action.RECOGNIZE_SPEECH";
			}
		}
		public static global::java.lang.String ACTION_WEB_SEARCH
		{
			get
			{
				return "android.speech.action.WEB_SEARCH";
			}
		}
		public static global::java.lang.String EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS
		{
			get
			{
				return "android.speech.extras.SPEECH_INPUT_MINIMUM_LENGTH_MILLIS";
			}
		}
		public static global::java.lang.String EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS
		{
			get
			{
				return "android.speech.extras.SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS";
			}
		}
		public static global::java.lang.String EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS
		{
			get
			{
				return "android.speech.extras.SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS";
			}
		}
		public static global::java.lang.String EXTRA_LANGUAGE_MODEL
		{
			get
			{
				return "android.speech.extra.LANGUAGE_MODEL";
			}
		}
		public static global::java.lang.String LANGUAGE_MODEL_FREE_FORM
		{
			get
			{
				return "free_form";
			}
		}
		public static global::java.lang.String LANGUAGE_MODEL_WEB_SEARCH
		{
			get
			{
				return "web_search";
			}
		}
		public static global::java.lang.String EXTRA_PROMPT
		{
			get
			{
				return "android.speech.extra.PROMPT";
			}
		}
		public static global::java.lang.String EXTRA_LANGUAGE
		{
			get
			{
				return "android.speech.extra.LANGUAGE";
			}
		}
		public static global::java.lang.String EXTRA_MAX_RESULTS
		{
			get
			{
				return "android.speech.extra.MAX_RESULTS";
			}
		}
		public static global::java.lang.String EXTRA_PARTIAL_RESULTS
		{
			get
			{
				return "android.speech.extra.PARTIAL_RESULTS";
			}
		}
		public static global::java.lang.String EXTRA_RESULTS_PENDINGINTENT
		{
			get
			{
				return "android.speech.extra.RESULTS_PENDINGINTENT";
			}
		}
		public static global::java.lang.String EXTRA_RESULTS_PENDINGINTENT_BUNDLE
		{
			get
			{
				return "android.speech.extra.RESULTS_PENDINGINTENT_BUNDLE";
			}
		}
		public static int RESULT_NO_MATCH
		{
			get
			{
				return 1;
			}
		}
		public static int RESULT_CLIENT_ERROR
		{
			get
			{
				return 2;
			}
		}
		public static int RESULT_SERVER_ERROR
		{
			get
			{
				return 3;
			}
		}
		public static int RESULT_NETWORK_ERROR
		{
			get
			{
				return 4;
			}
		}
		public static int RESULT_AUDIO_ERROR
		{
			get
			{
				return 5;
			}
		}
		public static global::java.lang.String EXTRA_RESULTS
		{
			get
			{
				return "android.speech.extra.RESULTS";
			}
		}
		public static global::java.lang.String DETAILS_META_DATA
		{
			get
			{
				return "android.speech.DETAILS";
			}
		}
		public static global::java.lang.String ACTION_GET_LANGUAGE_DETAILS
		{
			get
			{
				return "android.speech.action.GET_LANGUAGE_DETAILS";
			}
		}
		public static global::java.lang.String EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE
		{
			get
			{
				return "android.speech.extra.ONLY_RETURN_LANGUAGE_PREFERENCE";
			}
		}
		public static global::java.lang.String EXTRA_LANGUAGE_PREFERENCE
		{
			get
			{
				return "android.speech.extra.LANGUAGE_PREFERENCE";
			}
		}
		public static global::java.lang.String EXTRA_SUPPORTED_LANGUAGES
		{
			get
			{
				return "android.speech.extra.SUPPORTED_LANGUAGES";
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.speech.RecognizerIntent.staticClass = @__class;
			global::android.speech.RecognizerIntent._getVoiceDetailsIntent7028 = @__env.GetStaticMethodID(global::android.speech.RecognizerIntent.staticClass, "getVoiceDetailsIntent", "(Landroid/content/Context;)Landroid/content/Intent;");
		}
	}
}
