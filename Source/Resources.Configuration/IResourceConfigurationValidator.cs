/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Dolittle.Resources.Configuration
{
    /// <summary>
    /// Defines a system that can validate a <see cref="IResourceConfiguration"/>
    /// </summary>
    public interface IResourceConfigurationValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        ResourceConfigurationValidationResult ValidationResult(IResourceConfiguration configuration);
    }
}