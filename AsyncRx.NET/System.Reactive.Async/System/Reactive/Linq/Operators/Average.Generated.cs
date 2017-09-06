﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

using System.Threading.Tasks;

namespace System.Reactive.Linq
{
    partial class AsyncObservable
    {
        public static IAsyncObservable<Double> Average(this IAsyncObservable<Int32> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageInt32(observer)));
        }

        public static IAsyncObservable<Double> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Int32> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageInt32(observer, selector)));
        }

        public static IAsyncObservable<Double> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Int32>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageInt32(observer, selector)));
        }

        public static IAsyncObservable<Double?> Average(this IAsyncObservable<Int32?> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableInt32(observer)));
        }

        public static IAsyncObservable<Double?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Int32?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableInt32(observer, selector)));
        }

        public static IAsyncObservable<Double?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Int32?>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableInt32(observer, selector)));
        }

        public static IAsyncObservable<Double> Average(this IAsyncObservable<Int64> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageInt64(observer)));
        }

        public static IAsyncObservable<Double> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Int64> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageInt64(observer, selector)));
        }

        public static IAsyncObservable<Double> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Int64>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageInt64(observer, selector)));
        }

        public static IAsyncObservable<Double?> Average(this IAsyncObservable<Int64?> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableInt64(observer)));
        }

        public static IAsyncObservable<Double?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Int64?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableInt64(observer, selector)));
        }

        public static IAsyncObservable<Double?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Int64?>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableInt64(observer, selector)));
        }

        public static IAsyncObservable<Single> Average(this IAsyncObservable<Single> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Single>(observer => source.SubscribeAsync(AsyncObserver.AverageSingle(observer)));
        }

        public static IAsyncObservable<Single> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Single> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Single>(observer => source.SubscribeAsync(AsyncObserver.AverageSingle(observer, selector)));
        }

        public static IAsyncObservable<Single> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Single>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Single>(observer => source.SubscribeAsync(AsyncObserver.AverageSingle(observer, selector)));
        }

        public static IAsyncObservable<Single?> Average(this IAsyncObservable<Single?> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Single?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableSingle(observer)));
        }

        public static IAsyncObservable<Single?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Single?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Single?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableSingle(observer, selector)));
        }

        public static IAsyncObservable<Single?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Single?>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Single?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableSingle(observer, selector)));
        }

        public static IAsyncObservable<Double> Average(this IAsyncObservable<Double> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageDouble(observer)));
        }

        public static IAsyncObservable<Double> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Double> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageDouble(observer, selector)));
        }

        public static IAsyncObservable<Double> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Double>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double>(observer => source.SubscribeAsync(AsyncObserver.AverageDouble(observer, selector)));
        }

        public static IAsyncObservable<Double?> Average(this IAsyncObservable<Double?> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableDouble(observer)));
        }

        public static IAsyncObservable<Double?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Double?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableDouble(observer, selector)));
        }

        public static IAsyncObservable<Double?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Double?>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Double?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableDouble(observer, selector)));
        }

        public static IAsyncObservable<Decimal> Average(this IAsyncObservable<Decimal> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Decimal>(observer => source.SubscribeAsync(AsyncObserver.AverageDecimal(observer)));
        }

        public static IAsyncObservable<Decimal> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Decimal> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Decimal>(observer => source.SubscribeAsync(AsyncObserver.AverageDecimal(observer, selector)));
        }

        public static IAsyncObservable<Decimal> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Decimal>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Decimal>(observer => source.SubscribeAsync(AsyncObserver.AverageDecimal(observer, selector)));
        }

        public static IAsyncObservable<Decimal?> Average(this IAsyncObservable<Decimal?> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return Create<Decimal?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableDecimal(observer)));
        }

        public static IAsyncObservable<Decimal?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Decimal?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Decimal?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableDecimal(observer, selector)));
        }

        public static IAsyncObservable<Decimal?> Average<TSource>(this IAsyncObservable<TSource> source, Func<TSource, Task<Decimal?>> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Create<Decimal?>(observer => source.SubscribeAsync(AsyncObserver.AverageNullableDecimal(observer, selector)));
        }

    }

    partial class AsyncObserver
    {
        public static IAsyncObserver<TSource> AverageInt32<TSource>(this IAsyncObserver<Double> observer, Func<TSource, Int32> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageInt32(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageInt32<TSource>(this IAsyncObserver<Double> observer, Func<TSource, Task<Int32>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageInt32(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableInt32<TSource>(this IAsyncObserver<Double?> observer, Func<TSource, Int32?> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableInt32(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableInt32<TSource>(this IAsyncObserver<Double?> observer, Func<TSource, Task<Int32?>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableInt32(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageInt64<TSource>(this IAsyncObserver<Double> observer, Func<TSource, Int64> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageInt64(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageInt64<TSource>(this IAsyncObserver<Double> observer, Func<TSource, Task<Int64>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageInt64(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableInt64<TSource>(this IAsyncObserver<Double?> observer, Func<TSource, Int64?> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableInt64(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableInt64<TSource>(this IAsyncObserver<Double?> observer, Func<TSource, Task<Int64?>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableInt64(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageSingle<TSource>(this IAsyncObserver<Single> observer, Func<TSource, Single> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageSingle(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageSingle<TSource>(this IAsyncObserver<Single> observer, Func<TSource, Task<Single>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageSingle(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableSingle<TSource>(this IAsyncObserver<Single?> observer, Func<TSource, Single?> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableSingle(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableSingle<TSource>(this IAsyncObserver<Single?> observer, Func<TSource, Task<Single?>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableSingle(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageDouble<TSource>(this IAsyncObserver<Double> observer, Func<TSource, Double> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageDouble(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageDouble<TSource>(this IAsyncObserver<Double> observer, Func<TSource, Task<Double>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageDouble(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableDouble<TSource>(this IAsyncObserver<Double?> observer, Func<TSource, Double?> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableDouble(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableDouble<TSource>(this IAsyncObserver<Double?> observer, Func<TSource, Task<Double?>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableDouble(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageDecimal<TSource>(this IAsyncObserver<Decimal> observer, Func<TSource, Decimal> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageDecimal(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageDecimal<TSource>(this IAsyncObserver<Decimal> observer, Func<TSource, Task<Decimal>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageDecimal(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableDecimal<TSource>(this IAsyncObserver<Decimal?> observer, Func<TSource, Decimal?> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableDecimal(observer), selector);
        }

        public static IAsyncObserver<TSource> AverageNullableDecimal<TSource>(this IAsyncObserver<Decimal?> observer, Func<TSource, Task<Decimal?>> selector)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Select(AverageNullableDecimal(observer), selector);
        }

    }
}
