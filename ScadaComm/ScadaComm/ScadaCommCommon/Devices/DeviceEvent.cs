﻿/*
 * Copyright 2020 Mikhail Shiryaev
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
 * Module   : ScadaCommCommon
 * Summary  : Represents an event created by a device driver
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2020
 * Modified : 2020
 */

using Scada.Data.Models;
using System;

namespace Scada.Comm.Devices
{
    /// <summary>
    /// Represents an event created by a device driver.
    /// <para>Представляет событие, созданное драйвером КП.</para>
    /// </summary>
    public class DeviceEvent : Event
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public DeviceEvent()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public DeviceEvent(DeviceTag deviceTag)
            : base()
        {
            DeviceTag = deviceTag;
            ArchiveMask = Scada.Data.Models.ArchiveMask.Default;
            Descr = "";
            DataSentCallback = null;
            FailedToSendCallback = null;
        }


        /// <summary>
        /// Gets or sets the device tag, the event relates.
        /// </summary>
        public DeviceTag DeviceTag { get; set; }

        /// <summary>
        /// Gets or sets the mask that identifies the target archives.
        /// </summary>
        public int ArchiveMask { get; set; }

        /// <summary>
        /// Gets or sets the description to display.
        /// </summary>
        public string Descr { get; set; }

        /// <summary>
        /// Gets or sets the method that is executed when the event is successfully sent.
        /// </summary>
        public Action<DeviceEvent> DataSentCallback { get; set; }

        /// <summary>
        /// Gets or sets the method that is executed when the event could not be sent.
        /// </summary>
        public Action<DeviceSlice> FailedToSendCallback { get; set; }
    }
}
