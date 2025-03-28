﻿/*
 * Copyright 2025 Rapid Software LLC
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
 * Summary  : Defines functionality of a data queue
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2022
 * Modified : 2022
 */

using System;

namespace Scada.Data.Queues
{
    /// <summary>
    /// Defines functionality of a data queue.
    /// <para>Определяет функциональность очереди данных.</para>
    /// </summary>
    public interface IDataQueue<T>
    {
        /// <summary>
        /// Enqueues the specified value.
        /// </summary>
        bool Enqueue(DateTime creationTime, T value, out string errMsg);

        /// <summary>
        /// Occurs when the queue is empty.
        /// </summary>
        event EventHandler Empty;
    }
}
