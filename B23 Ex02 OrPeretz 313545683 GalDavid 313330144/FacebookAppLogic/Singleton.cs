using System;
using System.Reflection;

namespace FacebookAppLogic
{
    public sealed class Singleton<T>
    {
        private static readonly object sr_lock = new object();
        private static T s_Instance;

        static Singleton()
        {
        }

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_lock)
                    {
                        if (s_Instance == null)
                        {
                            Type typeOfT = typeof(T);
                            foreach (ConstructorInfo ctorInfo in typeOfT.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance))
                            {
                                s_Instance = (T)ctorInfo.Invoke(null);
                            }
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}
