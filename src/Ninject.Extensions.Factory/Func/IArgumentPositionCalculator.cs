﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IArgumentPositionCalculator.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2017 Ninject Project Contributors
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Ninject.Extensions.Factory
{
    using Ninject.Activation;
    using Ninject.Parameters;
    using Ninject.Planning.Targets;

    /// <summary>
    /// Calculates the position of method arguments
    /// </summary>
    public interface IArgumentPositionCalculator
    {
        /// <summary>
        /// Gets the position of the specified <see cref="FuncConstructorArgument"/> relative to the
        /// other <see cref="FuncConstructorArgument"/> of the same type in the specified context.
        /// </summary>
        /// <param name="argument">The argument for which the position is calculated.</param>
        /// <param name="context">The context of the argument.</param>
        /// <param name="target">The target.</param>
        /// <returns>
        ///     -1 if the parameter does not exist in the context or if another constructor argument applies for the target.
        ///     Otherwise the position of the specified <see cref="FuncConstructorArgument"/> within the other <see cref="FuncConstructorArgument"/> of the same type
        ///     contained in context.Parameters.
        /// </returns>
        int GetPositionOfFuncConstructorArgument(FuncConstructorArgument argument, IContext context, ITarget target);

        /// <summary>
        /// Gets the position of the parameter specified by the target relative to the other parameters of the same
        /// type of the method containing the target. Parameters that apply to other ConstructorArguments are ignored.
        /// </summary>
        /// <param name="context">The current context.</param>
        /// <param name="target">The target for which the position is calculated.</param>
        /// <returns>
        ///     -1 if the target is not found of the parameter applies to another constructor argument.
        ///     Otherwise the position of the target relative to the other parameters of the method that have the same type and
        ///     do not apply to another <see cref="ConstructorArgument"/>.
        /// </returns>
        int GetTargetPosition(IContext context, ITarget target);
    }
}