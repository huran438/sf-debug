using System;
using JetBrains.Annotations;
using UnityEngine;
using Object = UnityEngine.Object;
namespace SFramework.Debug.Runtime
{
    public static class SFDebug
    {
        public static bool IsDebug { get; private set; }

        private static bool CanLog { get; } = !Application.isPlaying || IsDebug;
        
        [StringFormatMethod("message")]
        public static void Log(string message, params object[] args)
        {
            if (!CanLog) return;
            UnityEngine.Debug.LogFormat(LogType.Log, LogOption.None, null, message, args);
        }
        
        [StringFormatMethod("message")]
        public static void Log(string message, LogType logType = LogType.Log, params object[] args)
        {
            if (!CanLog) return;
            UnityEngine.Debug.LogFormat(logType, LogOption.None, null, message, args);
        }

        [StringFormatMethod("message")]
        public static void Log(string message, Object context, LogType logType, params object[] args)
        {
            if (!CanLog) return;
            UnityEngine.Debug.LogFormat(logType, LogOption.None, context, message, args);
        }

        public static void Exception(Exception exception)
        {
            UnityEngine.Debug.LogException(exception);
        }

        public static void Exception(Exception exception, Object context)
        {
            UnityEngine.Debug.LogException(exception, context);
        }

        public static void SetDebug(bool isDebug)
        {
            IsDebug = isDebug;
        }
    }
}
