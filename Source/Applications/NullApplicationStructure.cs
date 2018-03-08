/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Dolittle.Applications
{
    /// <summary>
    /// Null representation of <see cref="NullApplicationStructure"/>
    /// </summary>
    public class NullApplicationStructure : IApplicationStructure
    {
        /// <inheritdoc/>
        public IApplicationStructureFragment Root => NullApplicationStructureFragment.Instance;
    }
}