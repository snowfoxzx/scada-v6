﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Config;
using Scada.Server.Archives;
using System.Globalization;

namespace Scada.Server.Modules.ModArcPostgreSql.Config
{
    /// <summary>
    /// Represents options of a historical data archive.
    /// <para>Представляет параметры архива исторических данных.</para>
    /// </summary>
    internal class PostgreHAO : HistoricalArchiveOptions, IDatabaseOptions
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public PostgreHAO(OptionList options)
            : base(options)
        {
            UseDefaultConn = options.GetValueAsBool("UseDefaultConn", true);
            Connection = options.GetValueAsString("Connection");
            PartitionSize = options.GetValueAsEnum("PartitionSize", PartitionSize.OneMonth);
            MaxQueueSize = options.GetValueAsInt("MaxQueueSize", ModuleUtils.DefaultQueueSize);
            BatchSize = options.GetValueAsInt("BatchSize", ModuleUtils.DefaultBatchSize);
            UseMemoryCache = options.GetValueAsBool("UseMemoryCache", false);
            CacheSizeRatio = options.GetValueAsDouble("CacheSizeRatio", 1.0);
        }


        /// <summary>
        /// Gets or sets a value indicating whether to use a connection specified in the instance configuration.
        /// </summary>
        public bool UseDefaultConn { get; set; }

        /// <summary>
        /// Gets or sets the connection name.
        /// </summary>
        public string Connection { get; set; }

        /// <summary>
        /// Gets a value indicating whether partitioning is used.
        /// </summary>
        public bool UsePartitioning => true;

        /// <summary>
        /// Gets or sets the partition size.
        /// </summary>
        public PartitionSize PartitionSize { get; set; }

        /// <summary>
        /// Gets or sets the maximum queue size.
        /// </summary>
        public int MaxQueueSize { get; set; }

        /// <summary>
        /// Gets or sets the number of data points transferred in one transaction.
        /// </summary>
        public int BatchSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use a memory cache when reading individual data points.
        /// </summary>
        public bool UseMemoryCache { get; set; }

        /// <summary>
        /// Gets or sets the ratio of the cache size to the number of archive channels.
        /// </summary>
        public double CacheSizeRatio { get; set; }


        /// <summary>
        /// Adds the options to the list.
        /// </summary>
        public override void AddToOptionList(OptionList options)
        {
            base.AddToOptionList(options);
            options["UseDefaultConn"] = UseDefaultConn.ToLowerString();
            options["Connection"] = Connection;

            if (!ReadOnly)
            {
                options["PartitionSize"] = PartitionSize.ToString();
                options["MaxQueueSize"] = MaxQueueSize.ToString();
                options["BatchSize"] = BatchSize.ToString();
            }

            options["UseMemoryCache"] = UseMemoryCache.ToString();
            options["CacheSizeRatio"] = CacheSizeRatio.ToString(NumberFormatInfo.InvariantInfo);
        }
    }
}
