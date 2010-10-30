namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathShape : android.graphics.drawable.shapes.Shape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone6244;
		public virtual global::android.graphics.drawable.shapes.PathShape clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.shapes.PathShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/PathShape;", ref global::android.graphics.drawable.shapes.PathShape._clone6244) as android.graphics.drawable.shapes.PathShape;
		}
		internal static global::MonoJavaBridge.MethodId _draw6245;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.PathShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.shapes.PathShape._draw6245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onResize6246;
		protected override void onResize(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.PathShape.staticClass, "onResize", "(FF)V", ref global::android.graphics.drawable.shapes.PathShape._onResize6246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _PathShape6247;
		public PathShape(android.graphics.Path arg0, float arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.shapes.PathShape._PathShape6247.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.shapes.PathShape._PathShape6247 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.PathShape.staticClass, "<init>", "(Landroid/graphics/Path;FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.PathShape.staticClass, global::android.graphics.drawable.shapes.PathShape._PathShape6247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PathShape()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.PathShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/PathShape"));
		}
		internal static void InitJNI()
		{
		}
	}
}