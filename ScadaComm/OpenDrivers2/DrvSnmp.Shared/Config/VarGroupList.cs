﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections;

namespace Scada.Comm.Drivers.DrvSnmp.Config
{
    /// <summary>
    /// Represents a list of variable groups.
    /// <para>Представляет список групп переменных.</para>
    /// </summary>
    [Serializable]
    internal class VarGroupList : List<VarGroupConfig>, ITreeNode
    {
        /// <summary>
        /// Gets or sets the parent tree node.
        /// </summary>
        ITreeNode ITreeNode.Parent
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Gets the child tree nodes.
        /// </summary>
        IList ITreeNode.Children
        {
            get
            {
                return this;
            }
        }
    }
}