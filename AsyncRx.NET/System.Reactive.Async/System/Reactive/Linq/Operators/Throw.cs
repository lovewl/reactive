﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

using System.Reactive.Concurrency;
using System.Reactive.Disposables;

namespace System.Reactive.Linq
{
    partial class AsyncObservable
    {
        public static IAsyncObservable<TSource> Throw<TSource>(Exception error)
        {
            if (error == null)
                throw new ArgumentNullException(nameof(error));

            return Create<TSource>(async observer =>
            {
                await observer.OnErrorAsync(error).ConfigureAwait(false);
                return AsyncDisposable.Nop;
            });
        }

        public static IAsyncObservable<TSource> Throw<TSource>(Exception error, IAsyncScheduler scheduler)
        {
            if (error == null)
                throw new ArgumentNullException(nameof(error));
            if (scheduler == null)
                throw new ArgumentNullException(nameof(scheduler));

            throw new NotImplementedException();
        }
    }
}