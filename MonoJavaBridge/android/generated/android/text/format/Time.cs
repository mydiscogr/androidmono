namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Time : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Time(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString13189;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.format.Time._toString13189) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear13190;
		public virtual void clear(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "clear", "(Ljava/lang/String;)V", ref global::android.text.format.Time._clear13190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _format13191;
		public virtual global::java.lang.String format(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "format", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.text.format.Time._format13191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compare13192;
		public static int compare(android.text.format.Time arg0, android.text.format.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._compare13192.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._compare13192 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I");
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._compare13192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set13193;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(IIIIII)V", ref global::android.text.format.Time._set13193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _set13194;
		public virtual void set(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(III)V", ref global::android.text.format.Time._set13194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set13195;
		public virtual void set(android.text.format.Time arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(Landroid/text/format/Time;)V", ref global::android.text.format.Time._set13195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set13196;
		public virtual void set(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(J)V", ref global::android.text.format.Time._set13196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalize13197;
		public virtual long normalize(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.format.Time.staticClass, "normalize", "(Z)J", ref global::android.text.format.Time._normalize13197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _after13198;
		public virtual bool after(android.text.format.Time arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "after", "(Landroid/text/format/Time;)Z", ref global::android.text.format.Time._after13198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before13199;
		public virtual bool before(android.text.format.Time arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "before", "(Landroid/text/format/Time;)Z", ref global::android.text.format.Time._before13199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse13200;
		public virtual bool parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "parse", "(Ljava/lang/String;)Z", ref global::android.text.format.Time._parse13200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toMillis13201;
		public virtual long toMillis(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.format.Time.staticClass, "toMillis", "(Z)J", ref global::android.text.format.Time._toMillis13201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum13202;
		public virtual int getActualMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.format.Time.staticClass, "getActualMaximum", "(I)I", ref global::android.text.format.Time._getActualMaximum13202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _switchTimezone13203;
		public virtual void switchTimezone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "switchTimezone", "(Ljava/lang/String;)V", ref global::android.text.format.Time._switchTimezone13203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse333913204;
		public virtual bool parse3339(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "parse3339", "(Ljava/lang/String;)Z", ref global::android.text.format.Time._parse333913204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String CurrentTimezone
		{
			get
			{
				return getCurrentTimezone();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTimezone13205;
		public static global::java.lang.String getCurrentTimezone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._getCurrentTimezone13205.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._getCurrentTimezone13205 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getCurrentTimezone", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.Time.staticClass, global::android.text.format.Time._getCurrentTimezone13205)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setToNow13206;
		public virtual void setToNow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "setToNow", "()V", ref global::android.text.format.Time._setToNow13206);
		}
		internal static global::MonoJavaBridge.MethodId _format244513207;
		public virtual global::java.lang.String format2445()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "format2445", "()Ljava/lang/String;", ref global::android.text.format.Time._format244513207) as java.lang.String;
		}
		public new int WeekNumber
		{
			get
			{
				return getWeekNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeekNumber13208;
		public virtual int getWeekNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.format.Time.staticClass, "getWeekNumber", "()I", ref global::android.text.format.Time._getWeekNumber13208);
		}
		internal static global::MonoJavaBridge.MethodId _format333913209;
		public virtual global::java.lang.String format3339(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "format3339", "(Z)Ljava/lang/String;", ref global::android.text.format.Time._format333913209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEpoch13210;
		public static bool isEpoch(android.text.format.Time arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._isEpoch13210.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._isEpoch13210 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "isEpoch", "(Landroid/text/format/Time;)Z");
			return @__env.CallStaticBooleanMethod(android.text.format.Time.staticClass, global::android.text.format.Time._isEpoch13210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getJulianDay13211;
		public static int getJulianDay(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._getJulianDay13211.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._getJulianDay13211 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getJulianDay", "(JJ)I");
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._getJulianDay13211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int JulianDay
		{
			set
			{
				setJulianDay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setJulianDay13212;
		public virtual long setJulianDay(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.format.Time.staticClass, "setJulianDay", "(I)J", ref global::android.text.format.Time._setJulianDay13212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Time13213;
		public Time(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._Time13213.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._Time13213 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time13213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time13214;
		public Time() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._Time13214.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._Time13214 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time13214);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time13215;
		public Time(android.text.format.Time arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._Time13215.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._Time13215 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Landroid/text/format/Time;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time13215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TIMEZONE_UTC
		{
			get
			{
				return "UTC";
			}
		}
		public static int EPOCH_JULIAN_DAY
		{
			get
			{
				return 2440588;
			}
		}
		internal static global::MonoJavaBridge.FieldId _allDay13218;
		public bool allDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _allDay13218);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _second13219;
		public int second
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _second13219);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minute13220;
		public int minute
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minute13220);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hour13221;
		public int hour
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hour13221);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _monthDay13222;
		public int monthDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _monthDay13222);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _month13223;
		public int month
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _month13223);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _year13224;
		public int year
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _year13224);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _weekDay13225;
		public int weekDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _weekDay13225);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _yearDay13226;
		public int yearDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _yearDay13226);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isDst13227;
		public int isDst
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _isDst13227);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gmtoff13228;
		public long gmtoff
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _gmtoff13228);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _timezone13229;
		public global::java.lang.String timezone
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _timezone13229)) as java.lang.String;
			}
			set
			{
			}
		}
		public static int SECOND
		{
			get
			{
				return 1;
			}
		}
		public static int MINUTE
		{
			get
			{
				return 2;
			}
		}
		public static int HOUR
		{
			get
			{
				return 3;
			}
		}
		public static int MONTH_DAY
		{
			get
			{
				return 4;
			}
		}
		public static int MONTH
		{
			get
			{
				return 5;
			}
		}
		public static int YEAR
		{
			get
			{
				return 6;
			}
		}
		public static int WEEK_DAY
		{
			get
			{
				return 7;
			}
		}
		public static int YEAR_DAY
		{
			get
			{
				return 8;
			}
		}
		public static int WEEK_NUM
		{
			get
			{
				return 9;
			}
		}
		public static int SUNDAY
		{
			get
			{
				return 0;
			}
		}
		public static int MONDAY
		{
			get
			{
				return 1;
			}
		}
		public static int TUESDAY
		{
			get
			{
				return 2;
			}
		}
		public static int WEDNESDAY
		{
			get
			{
				return 3;
			}
		}
		public static int THURSDAY
		{
			get
			{
				return 4;
			}
		}
		public static int FRIDAY
		{
			get
			{
				return 5;
			}
		}
		public static int SATURDAY
		{
			get
			{
				return 6;
			}
		}
		static Time()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.Time.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/Time"));
			global::android.text.format.Time._allDay13218 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "allDay", "Z");
			global::android.text.format.Time._second13219 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "second", "I");
			global::android.text.format.Time._minute13220 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "minute", "I");
			global::android.text.format.Time._hour13221 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "hour", "I");
			global::android.text.format.Time._monthDay13222 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "monthDay", "I");
			global::android.text.format.Time._month13223 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "month", "I");
			global::android.text.format.Time._year13224 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "year", "I");
			global::android.text.format.Time._weekDay13225 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "weekDay", "I");
			global::android.text.format.Time._yearDay13226 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "yearDay", "I");
			global::android.text.format.Time._isDst13227 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "isDst", "I");
			global::android.text.format.Time._gmtoff13228 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "gmtoff", "J");
			global::android.text.format.Time._timezone13229 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "timezone", "Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}