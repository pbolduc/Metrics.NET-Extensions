using System;
using System.Diagnostics.CodeAnalysis;

namespace Metrics
{
    public static class TimerExtensions
    {
        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, TResult>(this Timer source, Func<T1, T2, TResult> action, T1 arg1, T2 arg2, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, TResult>(this Timer source, Func<T1, T2, T3, TResult> action, T1 arg1, T2 arg2, T3 arg3, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, TResult>(this Timer source, Func<T1, T2, T3, T4, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg14">The fourteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg14">The fourteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg15">The fifteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg14">The fourteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg15">The fifteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg16">The sixteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        /// <typeparam name="TResult">The type of the return value of the method that the <paramref name="action"/> delegate encapsulates.</typeparam>
        public static TResult Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Timer source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, string userValue = null)
        {
			using (source.NewContext())
			{
                return action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2>(this Timer source, Action<T1, T2> action, T1 arg1, T2 arg2, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3>(this Timer source, Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4>(this Timer source, Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5>(this Timer source, Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6>(this Timer source, Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg14">The fourteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg14">The fourteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg15">The fifteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			}
        }

        /// <summary>
        /// Runs the <paramref name="action"/> and records the time it took.
        /// </summary>
        /// <typeparam name="T1">The type of the first parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T2">The type of the second parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T3">The type of the third parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T6">The type of the sixth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T7">The type of the seventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T8">The type of the eighth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T9">The type of the nineth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T10">The type of the tenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T11">The type of the eleventh parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T12">The type of the twelfth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth parameter to the <paramref name="action"/> delegate.</typeparam>
        /// <param name="source"></param>
        /// <param name="action">Action to run and record time for.</param>
        /// <param name="arg1">The first parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg2">The second parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg3">The third parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg4">The fourth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg5">The fifth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg6">The sixth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg7">The seventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg8">The eighth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg9">The nineth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg10">The tenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg11">The eleventh parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg12">The twelfth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg13">The thirteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg14">The fourteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg15">The fifteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="arg16">The sixteenth parameter of the <paramref name="action"/> delegate.</param>
        /// <param name="userValue">A custom user value that will be associated to the results.
        /// Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        public static void Time<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Timer source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, string userValue = null)
        {
			using (source.NewContext())
			{
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			}
        }

    }
}
