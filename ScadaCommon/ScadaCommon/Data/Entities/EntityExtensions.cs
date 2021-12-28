﻿/*
 * Copyright 2021 Rapid Software LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaCommon
 * Summary  : Provides extensions for entities of the configuration database
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2021
 * Modified : 2021
 */

using Scada.Data.Const;
using System;

namespace Scada.Data.Entities
{
    /// <summary>
    /// Provides extensions for entities of the configuration database.
    /// <para>Предоставляет расширения для сущностей базы конфигурации.</para>
    /// </summary>
    public static class EntityExtensions
    {
        /// <summary>
        /// Determines if the channel represents an array of numbers.
        /// </summary>
        public static bool IsNumericArray(this Cnl cnl)
        {
            return cnl.DataLen > 1 && DataTypeID.IsNumeric(cnl.DataTypeID);
        }

        /// <summary>
        /// Gets the normalized data length of the specified channel.
        /// </summary>
        public static int GetDataLength(this Cnl cnl)
        {
            return cnl.DataLen.HasValue ? Math.Max(cnl.DataLen.Value, 1) : 1;
        }
    }
}
