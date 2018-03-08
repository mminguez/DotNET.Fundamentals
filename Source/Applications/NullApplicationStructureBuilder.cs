/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Dolittle.Applications
{
    /// <summary>
    /// Null representation of <see cref="IApplicationStructureBuilder"/>
    /// </summary>
    public class NullApplicationStructureBuilder : IApplicationStructureBuilder
    {
        /// <inheritdoc/>
        public IApplicationStructure Build()
        {
            return new NullApplicationStructure();
        }
    }
}