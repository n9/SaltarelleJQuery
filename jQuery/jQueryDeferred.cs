// jQueryDeferred.cs
// Script#/Libraries/jQuery/Core
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace jQueryApi
{
    [Imported]
    [IgnoreNamespace]
    public interface IjQueryPromise<out TResult> { }

    [Imported]
    [IgnoreNamespace]
    public interface IjQueryPromiseProgress<out TProgress> { }

    [Imported]
    [IgnoreNamespace]
    public interface IjQueryPromise<out TResult, out TProgress> : IjQueryPromise<TResult>, IjQueryPromiseProgress<TProgress> { }

    [Imported]
    [IgnoreNamespace]
    public static class jQueryPromiseEx
    {
        [InlineCode("{$System.Threading.Tasks.Task}.fromPromise({p}, 0)")]
        public static Task<TResult> ToTask<TResult>(this IjQueryPromise<TResult> p) { return null; } 

        [InstanceMethodOnFirstArgument]
        public static bool IsRejected<T>(this IjQueryPromise<T> t) { return default(bool); }

        [InstanceMethodOnFirstArgument]
        public static bool IsResolved<T>(this IjQueryPromise<T> t) { return default(bool); }


        [InstanceMethodOnFirstArgument]
        public static T Always<T>(this T t, params Action<object>[] callbacks)
            where T : IjQueryPromise<object> { return t; }

        [InstanceMethodOnFirstArgument]
        public static T Fail<T>(this T t, params Action<object>[] failCallbacks)
            where T : IjQueryPromise<object> { return t; }


        [InstanceMethodOnFirstArgument]
        public static T Done<T, TResult>(this T t, params Action<TResult>[] doneCallbacks)
            where T : IjQueryPromise<TResult> { return t; }

        [InstanceMethodOnFirstArgument]
        public static T Then<T, TResult>(this T t, Action<TResult> doneCallback)
            where T : IjQueryPromise<TResult> { return t; }

        [InstanceMethodOnFirstArgument]
        public static T Then<T, TResult>(this T t, Action<TResult> doneCallback, Action<object> failCallback)
            where T : IjQueryPromise<TResult> { return t; }


        [InstanceMethodOnFirstArgument]
        public static T Progress<T, TProgress>(this T t, params Action<TProgress>[] progressCallbacks)
            where T : IjQueryPromiseProgress<TProgress> { return t; }

        [InstanceMethodOnFirstArgument]
        public static T Then<T, TResult, TProgress>(this T t, Action<TResult> doneCallback, Action<object> failCallback, Action<TProgress> progressCallback)
            where T : IjQueryPromise<TResult, TProgress> { return t; }

    }

    [Imported]
    [IgnoreNamespace]
    public interface IjQueryDeferredCommon { }


    [Imported]
    [IgnoreNamespace]
    public interface IjQueryDeferred<TResult> : IjQueryPromise<TResult> { }

    [Imported]
    [IgnoreNamespace]
    public interface IjQueryDeferredProgress<TProgress> { }

    [Imported]
    [IgnoreNamespace]
    public interface IjQueryDeferred<TResult, TProgress> : IjQueryDeferred<TResult>, IjQueryDeferredProgress<TProgress>, IjQueryPromise<TResult, TProgress> { }


    [Imported]
    [IgnoreNamespace]
    public static class jQueryDeferredEx
    {
        [InstanceMethodOnFirstArgument]
        public static IjQueryPromise<T> Promise<T>(this IjQueryDeferred<T> d) { return null; }

        [InstanceMethodOnFirstArgument]
        public static T Reject<T>(this T t, object arg)
            where T : IjQueryDeferredCommon { return t; }

        [InstanceMethodOnFirstArgument]
        public static T RejectWith<T>(this T t, object context, object arg)
            where T : IjQueryDeferredCommon { return t; }


        [InstanceMethodOnFirstArgument]
        public static T Resolve<T, TResult>(this T t, TResult arg)
            where T : IjQueryDeferred<TResult> { return t; }

        [InstanceMethodOnFirstArgument]
        public static T ResolveWith<T, TResult>(this T t, object context, TResult arg)
            where T : IjQueryDeferred<TResult> { return t; }


        [InstanceMethodOnFirstArgument]
        public static T Notify<T, TProgress>(this T t, TProgress arg)
            where T : IjQueryDeferredProgress<TProgress> { return t; }

        [InstanceMethodOnFirstArgument]
        public static T NotifyWith<T, TProgress>(this T t, object context, TProgress arg)
            where T : IjQueryDeferredProgress<TProgress> { return t; }
    }
}

