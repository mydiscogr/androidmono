namespace org.xmlpull.v1
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface XmlPullParser 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		global::java.lang.String getName();
		int next();
		int getLineNumber();
		bool isWhitespace();
		int nextToken();
		void setInput(java.io.InputStream arg0, java.lang.String arg1);
		void setInput(java.io.Reader arg0);
		global::java.lang.String getPrefix();
		global::java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getAttributeValue(int arg0);
		int getColumnNumber();
		global::java.lang.String getText();
		int getEventType();
		int getAttributeCount();
		global::java.lang.String getAttributeName(int arg0);
		global::java.lang.String getPositionDescription();
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		global::java.lang.String getInputEncoding();
		void defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1);
		int getNamespaceCount(int arg0);
		global::java.lang.String getNamespacePrefix(int arg0);
		global::java.lang.String getNamespaceUri(int arg0);
		global::java.lang.String getNamespace();
		global::java.lang.String getNamespace(java.lang.String arg0);
		int getDepth();
		char[] getTextCharacters(int[] arg0);
		bool isEmptyElementTag();
		global::java.lang.String getAttributeNamespace(int arg0);
		global::java.lang.String getAttributePrefix(int arg0);
		global::java.lang.String getAttributeType(int arg0);
		bool isAttributeDefault(int arg0);
		void require(int arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.lang.String nextText();
		int nextTag();
	}

	public partial class XmlPullParser_
	{
		public static global::java.lang.Class _class
		{
			get { return __XmlPullParser.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __XmlPullParser : java.lang.Object, XmlPullParser
	{
		internal static global::java.lang.Class staticClass;
		static __XmlPullParser()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xmlpull.v1.__XmlPullParser), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.xmlpull.v1.__XmlPullParser(@__env);
			}
		}
		internal __XmlPullParser(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProperty14633;
		 void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser._setProperty14633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._setProperty14633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProperty14634;
		 global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getProperty14634, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getProperty14634, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName14635;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getName14635));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getName14635));
		}
		internal static global::net.sf.jni4net.jni.MethodId _next14636;
		 int org.xmlpull.v1.XmlPullParser.next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._next14636);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._next14636);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineNumber14637;
		 int org.xmlpull.v1.XmlPullParser.getLineNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._getLineNumber14637);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getLineNumber14637);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWhitespace14638;
		 bool org.xmlpull.v1.XmlPullParser.isWhitespace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser._isWhitespace14638);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._isWhitespace14638);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextToken14639;
		 int org.xmlpull.v1.XmlPullParser.nextToken() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._nextToken14639);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._nextToken14639);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInput14640;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser._setInput14640, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._setInput14640, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInput14641;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser._setInput14641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._setInput14641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPrefix14642;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getPrefix14642));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getPrefix14642));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue14643;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getAttributeValue14643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getAttributeValue14643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue14644;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getAttributeValue14644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getAttributeValue14644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNumber14645;
		 int org.xmlpull.v1.XmlPullParser.getColumnNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._getColumnNumber14645);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getColumnNumber14645);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText14646;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getText14646));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getText14646));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEventType14647;
		 int org.xmlpull.v1.XmlPullParser.getEventType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._getEventType14647);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getEventType14647);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeCount14648;
		 int org.xmlpull.v1.XmlPullParser.getAttributeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._getAttributeCount14648);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getAttributeCount14648);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeName14649;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getAttributeName14649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getAttributeName14649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription14650;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getPositionDescription14650));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getPositionDescription14650));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeature14651;
		 void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser._setFeature14651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._setFeature14651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFeature14652;
		 bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser._getFeature14652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getFeature14652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputEncoding14653;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getInputEncoding14653));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getInputEncoding14653));
		}
		internal static global::net.sf.jni4net.jni.MethodId _defineEntityReplacementText14654;
		 void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser._defineEntityReplacementText14654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._defineEntityReplacementText14654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceCount14655;
		 int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._getNamespaceCount14655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getNamespaceCount14655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespacePrefix14656;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getNamespacePrefix14656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getNamespacePrefix14656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceUri14657;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getNamespaceUri14657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getNamespaceUri14657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace14658;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getNamespace14658));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getNamespace14658));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace14659;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getNamespace14659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getNamespace14659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDepth14660;
		 int org.xmlpull.v1.XmlPullParser.getDepth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._getDepth14660);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getDepth14660);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextCharacters14661;
		 char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getTextCharacters14661, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getTextCharacters14661, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmptyElementTag14662;
		 bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser._isEmptyElementTag14662);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._isEmptyElementTag14662);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeNamespace14663;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getAttributeNamespace14663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getAttributeNamespace14663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributePrefix14664;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getAttributePrefix14664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getAttributePrefix14664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeType14665;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._getAttributeType14665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._getAttributeType14665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAttributeDefault14666;
		 bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser._isAttributeDefault14666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._isAttributeDefault14666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _require14667;
		 void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser._require14667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._require14667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextText14668;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser._nextText14668));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._nextText14668));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextTag14669;
		 int org.xmlpull.v1.XmlPullParser.nextTag() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlPullParser._nextTag14669);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlPullParser.staticClass, global::org.xmlpull.v1.__XmlPullParser._nextTag14669);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xmlpull.v1.__XmlPullParser.staticClass = @__class;
			global::org.xmlpull.v1.__XmlPullParser._setProperty14633 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.__XmlPullParser._getProperty14634 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.__XmlPullParser._getName14635 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getName", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._next14636 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.next", "()I");
			global::org.xmlpull.v1.__XmlPullParser._getLineNumber14637 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getLineNumber", "()I");
			global::org.xmlpull.v1.__XmlPullParser._isWhitespace14638 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.isWhitespace", "()Z");
			global::org.xmlpull.v1.__XmlPullParser._nextToken14639 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextToken", "()I");
			global::org.xmlpull.v1.__XmlPullParser._setInput14640 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlPullParser._setInput14641 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/Reader;)V");
			global::org.xmlpull.v1.__XmlPullParser._getPrefix14642 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPrefix", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getAttributeValue14643 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getAttributeValue14644 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getColumnNumber14645 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getColumnNumber", "()I");
			global::org.xmlpull.v1.__XmlPullParser._getText14646 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getText", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getEventType14647 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getEventType", "()I");
			global::org.xmlpull.v1.__XmlPullParser._getAttributeCount14648 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeCount", "()I");
			global::org.xmlpull.v1.__XmlPullParser._getAttributeName14649 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeName", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getPositionDescription14650 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPositionDescription", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._setFeature14651 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.__XmlPullParser._getFeature14652 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.__XmlPullParser._getInputEncoding14653 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getInputEncoding", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._defineEntityReplacementText14654 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlPullParser._getNamespaceCount14655 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceCount", "(I)I");
			global::org.xmlpull.v1.__XmlPullParser._getNamespacePrefix14656 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespacePrefix", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getNamespaceUri14657 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceUri", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getNamespace14658 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getNamespace14659 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getDepth14660 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getDepth", "()I");
			global::org.xmlpull.v1.__XmlPullParser._getTextCharacters14661 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getTextCharacters", "([I)[C");
			global::org.xmlpull.v1.__XmlPullParser._isEmptyElementTag14662 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.isEmptyElementTag", "()Z");
			global::org.xmlpull.v1.__XmlPullParser._getAttributeNamespace14663 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeNamespace", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getAttributePrefix14664 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributePrefix", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._getAttributeType14665 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeType", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._isAttributeDefault14666 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.isAttributeDefault", "(I)Z");
			global::org.xmlpull.v1.__XmlPullParser._require14667 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.require", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlPullParser._nextText14668 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextText", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlPullParser._nextTag14669 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextTag", "()I");
		}
	}
}
