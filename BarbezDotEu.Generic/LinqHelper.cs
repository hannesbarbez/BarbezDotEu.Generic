// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.Generic
{
    /// <summary>
    /// Generic helper extension method adapted for Linq from multiple sources, including:
    /// https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list and 
    /// http://www.albahari.com/nutshell/predicatebuilder.aspx.
    /// </summary>
    public static class LinqHelper
    {
        /// <summary>
        /// Selects a random single item from a given <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <returns>A randomly chosen item from the collection.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the source collection is empty.</exception>
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        /// <summary>
        /// Picks a specified number of random items from a given <see cref="IEnumerable{T}"/>.
        /// If the requested count is larger than the collection size, all available items are returned.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <param name="count">The number of items to retrieve.</param>
        /// <returns>A random subset of items.</returns>
        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        /// <summary>
        /// Randomly shuffles a given collection.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="source">The collection to shuffle.</param>
        /// <returns>A shuffled version of the original collection.</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(_ => Guid.NewGuid());
        }

        /// <summary>
        /// Generates a randomized list of a specified length from a given <see cref="IEnumerable{T}"/>.
        /// If the required size exceeds the collection, elements are repeatedly selected.
        /// </summary>
        /// <typeparam name="T">The type of elements.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <param name="numberOfItems">The number of items required.</param>
        /// <returns>A randomized list.</returns>
        public static IEnumerable<T> GenerateRandomList<T>(this IEnumerable<T> source, int numberOfItems)
        {
            var sourceItemCount = source.Count();
            var lastIterationIndex = numberOfItems / sourceItemCount;
            var itemsInLastIteration = numberOfItems % sourceItemCount;

            var results = new List<T>();
            for (int i = 0; i < lastIterationIndex; i++)
            {
                results.AddRange(source.PickRandom(sourceItemCount));
            }

            results.AddRange(source.PickRandom(itemsInLastIteration));
            return results;
        }

        /// <summary>
        /// Returns an expression that always evaluates to true.
        /// </summary>
        /// <typeparam name="T">The type of the expression.</typeparam>
        public static Expression<Func<T, bool>> True<T>() => f => true;

        /// <summary>
        /// Returns an expression that always evaluates to false.
        /// </summary>
        /// <typeparam name="T">The type of the expression.</typeparam>
        public static Expression<Func<T, bool>> False<T>() => f => false;

        /// <summary>
        /// Combines two boolean expressions using a logical OR operation.
        /// </summary>
        /// <typeparam name="T">The type of the expressions.</typeparam>
        /// <param name="expr1">The first expression.</param>
        /// <param name="expr2">The second expression.</param>
        /// <returns>A combined expression that evaluates to true if either input expression evaluates to true.</returns>
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>(Expression.OrElse(expr1.Body, invokedExpr), expr1.Parameters);
        }

        /// <summary>
        /// Combines two boolean expressions using a logical AND operation.
        /// </summary>
        /// <typeparam name="T">The type of the expressions.</typeparam>
        /// <param name="expr1">The first expression.</param>
        /// <param name="expr2">The second expression.</param>
        /// <returns>A combined expression that evaluates to true only if both input expressions evaluate to true.</returns>
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
        }
    }
}
