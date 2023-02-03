// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BarbezDotEu.Generic
{
    /// <summary>
    /// Generic helper extension method adapted for Linq
    /// from https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list, 
    /// http://www.albahari.com/nutshell/predicatebuilder.aspxamongst, and others.
    /// </summary>
    public static class LinqHelper
    {
        /// <summary>
        /// From a given <see cref="IEnumerable{T}"/>, selects a random single item.
        /// </summary>
        /// <typeparam name="T">The type to pick one of.</typeparam>
        /// <param name="source">The source collection to pick one item out of.</param>
        /// <returns>One item, randomly chosen from the given collection.</returns>
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        /// <summary>
        /// Picks an n number of items randomly from the <see cref="IEnumerable{T}"/>. If n is larger than the number of items in the list, returns all items in the list only (which in this case is less than the number of items given to return).
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The number of items to take.</param>
        /// <returns>The random list.</returns>
        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        /// <summary>
        /// Randomly shuffles the given source collection.
        /// </summary>
        /// <typeparam name="T">The types to be found in the collection to shuffle.</typeparam>
        /// <param name="source">The collection to shuffle.</param>
        /// <returns>A shuffled version of the given collection.</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }

        /// <summary>
        /// Generates n number of items randomly from a given <see cref="IEnumerable{T}"/> source,
        /// even if the source list has less items than the number of items to return (as provided by the numberOfThings).
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="numberOfItems">The number of items to take.</param>
        /// <returns>The random list.</returns>
        public static IEnumerable<T> GenerateRandomList<T>(this IEnumerable<T> source, int numberOfItems)
        {
            var sourceItemCount = source.Count();
            var lastIterationIndex = numberOfItems / sourceItemCount;
            var itemsInLastIteration = numberOfItems % sourceItemCount;

            var results = new List<T>();
            for (int i = default; i < lastIterationIndex; i++)
            {
                var items = source.PickRandom(sourceItemCount);
                results.AddRange(items);
            }

            var lastItems = source.PickRandom(itemsInLastIteration);
            results.AddRange(lastItems);
            return results;
        }

        public static Expression<Func<T, bool>> True<T>() { return f => true; }
        public static Expression<Func<T, bool>> False<T>() { return f => false; }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.OrElse(expr1.Body, invokedExpr), expr1.Parameters);
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
        }
    }
}
