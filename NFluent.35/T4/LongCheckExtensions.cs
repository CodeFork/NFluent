﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LongCheckExtensions.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using NFluent.Helpers;

namespace NFluent
{
    using System;

    using NFluent.Extensibility;

    /// <summary>
    /// Provides check methods to be executed on an <see cref="long"/> value.
    /// </summary>
    public static class LongCheckExtensions
    {
        #pragma warning disable 169

        //// ---------------------- WARNING ----------------------
        //// AUTO-GENERATED FILE WHICH SHOULD NOT BE MODIFIED!
        //// To change this class, change the one that is used
        //// as the golden source/model for this autogeneration
        //// (i.e. the one dedicated to the integer values).
        //// -----------------------------------------------------

        #pragma warning restore 169
        
        /// <summary>
        /// Determines whether the specified value is before the other one.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <param name="givenValue">The other value.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The current value is not before the other one.</exception>
        public static ICheckLink<ICheck<long>> IsBefore(this ICheck<long> check, long givenValue)
        {
            var checker = ExtensibilityHelper.ExtractChecker(check);

            return checker.ExecuteCheck(
                () =>
                    {
                        if (checker.Value.CompareTo(givenValue) >= 0)
                        {
                            throw new FluentCheckException(checker.BuildMessage("The {0} is not before the reference value.").Expected(givenValue).Comparison("before").ToString());
                        }
                    },
                checker.BuildMessage("The {0} is before the reference value whereas it must not.").Expected(givenValue).Comparison("after").ToString());
        }

        /// <summary>
        /// Determines whether the specified value is after the other one.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <param name="givenValue">The other value.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The current value is not after the other one.</exception>
        public static ICheckLink<ICheck<long>> IsAfter(this ICheck<long> check, long givenValue)
        {
            var checker = ExtensibilityHelper.ExtractChecker(check);

            return checker.ExecuteCheck(
                () =>
                {
                    if (checker.Value.CompareTo(givenValue) <= 0)
                    {
                        throw new FluentCheckException(checker.BuildMessage("The {0} is not after the reference value.").Expected(givenValue).Comparison("after").ToString());
                    }
                },
                checker.BuildMessage("The {0} is after the reference value whereas it must not.").Expected(givenValue).Comparison("before").ToString());
        }

        /// <summary>
        /// Checks that the actual value is equal to zero.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The value is not equal to zero.</exception>
        public static ICheckLink<ICheck<long>> IsZero(this ICheck<long> check)
        {
            var numberCheckStrategy = new NumberCheck<long>(check);
            return numberCheckStrategy.IsZero();
        }

        /// <summary>
        /// Checks that the actual nullable value has a value and thus, is not null.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>A check link.</returns>
        /// <exception cref="FluentCheckException">The value is null.</exception>
        public static INullableOrNumberCheckLink<long> HasAValue(this ICheck<long?> check)
        {
            var checker = ExtensibilityHelper.ExtractChecker(check);

            checker.ExecuteCheck(
                () =>
                    {
                        if (checker.Value == null)
                        {
                            throw new FluentCheckException(
                                checker.BuildShortMessage(
                                    "The {0} has no value, which is unexpected.").For("nullable").ToString());
                        }
                    },
                checker.BuildMessage("The {0} has a value, which is unexpected.").For("nullable").ToString());

            return new NullableOrNumberCheckLink<long>(check);
        }

        /// <summary>
        /// Checks that the actual nullable value has no value and thus, is null. 
        /// Note: this method does not return A check link since the nullable is null.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <exception cref="FluentCheckException">The value is not null.</exception>
        public static void HasNoValue(this ICheck<long?> check)
        {
            var checker = ExtensibilityHelper.ExtractChecker(check);

            checker.ExecuteCheck(
                () =>
                    {
                        if (checker.Value != null)
                        {
                            throw new FluentCheckException(
                                checker.BuildMessage("The {0} has a value, whereas it must not.")
                                       .ToString());
                        }
                    },
                checker.BuildShortMessage("The {0} has no value, which is unexpected.").For("nullable").ToString());
        }
        
        /// <summary>
        /// Checks that the actual value is NOT equal to zero.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        ///   <returns>A check link.</returns>
        /// </returns>
        /// <exception cref="FluentCheckException">The value is equal to zero.</exception>
        public static ICheckLink<ICheck<long>> IsNotZero(this ICheck<long> check)
        {
            var numberCheckStrategy = new NumberCheck<long>(check);
            return numberCheckStrategy.IsNotZero();
        }

        /// <summary>
        /// Checks that the actual value is less than an operand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not less than the comparand.
        /// </exception>
        [Obsolete("Use IsStrictlyLessThan instead.")]
        public static ICheckLink<ICheck<long>> IsLessThan(this ICheck<long> check, long comparand)
        {
            var numberCheckStrategy = new NumberCheck<long>(check);
            return numberCheckStrategy.IsLessThan(comparand);
        }

        /// <summary>
        /// Checks that the checked value is strictly less than the comparand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not strictly less than the comparand.
        /// </exception>
        public static ICheckLink<ICheck<long>> IsStrictlyLessThan(this ICheck<long> check, long comparand)
        {
            var numberCheckStrategy = new NumberCheck<long>(check);
            return numberCheckStrategy.IsStrictlyLessThan(comparand);
        }

        /// <summary>
        /// Checks that the actual value is more than an operand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not less than the comparand.
        /// </exception>
        [Obsolete("Use IsStrictlyGreaterThan instead.")]
        public static ICheckLink<ICheck<long>> IsGreaterThan(this ICheck<long> check, long comparand)
        {
            var numberCheckStrategy = new NumberCheck<long>(check);
            return numberCheckStrategy.IsGreaterThan(comparand);
        }

        /// <summary>
        /// Checks that the checked value is strictly greater than the comparand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The checked value is not strictly greater than the comparand.
        /// </exception>
        public static ICheckLink<ICheck<long>> IsStrictlyGreaterThan(this ICheck<long> check, long comparand)
        {
            var numberCheckStrategy = new NumberCheck<long>(check);
            return numberCheckStrategy.IsStrictlyGreaterThan(comparand);
        }
        /// <summary>
        /// Checks that the actual value is equal to another expected value.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="expected">
        /// The expected value.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The actual value is not equal to the expected value.
        /// </exception>
        public static ICheckLink<ICheck<long>> IsEqualTo(this ICheck<long> check, long expected)
        {
            var checker = ExtensibilityHelper.ExtractChecker<long>(check);

            return checker.ExecuteCheck(
                () => EqualityHelper.IsEqualTo(checker, expected),
                EqualityHelper.BuildErrorMessage(checker, expected, true));
        }

    }
}
