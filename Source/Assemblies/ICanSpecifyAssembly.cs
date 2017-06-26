﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace doLittle.Assemblies
{
    /// <summary>
    /// Specifies what assemblies to include
    /// </summary>
    /// <remarks>
    /// Typically used by implementations of <see cref="IAssemblies"/> to 
    /// get the correct assemblies located 
    /// </remarks>
    public interface ICanSpecifyAssemblies
    {
        /// <summary>
        /// Method that gets called for specifying which assemblies to include or not
        /// </summary>
        /// <param name="builder"><see cref="IAssemblyRuleBuilder"/> object to build specification on</param>
        void Specify(IAssemblyRuleBuilder builder);
    }
}