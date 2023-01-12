﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.ComponentModel;
using System.Xml;

namespace Scada.Comm.Drivers.DrvSnmp.Config
{
    /// <summary>
    /// Represents device options.
    /// <para>Представляет параметры устройства.</para>
    /// </summary>
    [Serializable]
    internal class DeviceOptions
    {
        /// <summary>
        /// Gets or sets the password for reading data.
        /// </summary>
        [DisplayName, Category, Description]
        public string ReadCommunity { get; set; } = "public";

        /// <summary>
        /// Gets or sets the password for writing data.
        /// </summary>
        [DisplayName, Category, Description]
        public string WriteCommunity { get; set; } = "private";

        /// <summary>
        /// Gets or sets the SNMP version.
        /// </summary>
        [DisplayName, Category, Description]
        public int SnmpVersion { get; set; } = 2;


        /// <summary>
        /// Loads the options from the XML node.
        /// </summary>
        public void LoadFromXml(XmlNode xmlNode)
        {
            ArgumentNullException.ThrowIfNull(xmlNode, nameof(xmlNode));
            ReadCommunity = xmlNode.GetChildAsString("ReadCommunity", ReadCommunity);
            WriteCommunity = xmlNode.GetChildAsString("WriteCommunity", WriteCommunity);
            SnmpVersion = xmlNode.GetChildAsInt("SnmpVersion", SnmpVersion);
        }

        /// <summary>
        /// Saves the options into the XML node.
        /// </summary>
        public void SaveToXml(XmlElement xmlElem)
        {
            ArgumentNullException.ThrowIfNull(xmlElem, nameof(xmlElem));
            xmlElem.AppendElem("ReadCommunity", ReadCommunity);
            xmlElem.AppendElem("WriteCommunity", WriteCommunity);
            xmlElem.AppendElem("SnmpVersion", SnmpVersion);
        }
    }
}
