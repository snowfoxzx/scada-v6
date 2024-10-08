﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Lang;
using System.Runtime.Serialization;

namespace Scada.Admin.Extensions.ExtProjectTools.Code
{
    /// <summary>
    /// The phrases used by the extension.
    /// <para>Фразы, используемые расширением.</para>
    /// </summary>
    internal class ExtensionPhrases
    {
        // Scada.Admin.Extensions.ExtProjectTools.Code.ChannelMap
        public static string MapByDeviceTitle { get; private set; }
        public static string MapByObjectTitle { get; private set; }
        public static string ChannelsCaption { get; private set; }
        public static string NoChannels { get; private set; }
        public static string GenerateChannelMapError { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Code.DeviceMap
        public static string DeviceMapTitle { get; private set; }
        public static string DevicesCaption { get; private set; }
        public static string NoDevices { get; private set; }
        public static string EmptyCommLine { get; private set; }
        public static string GenerateDeviceMapError { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Code.IntegrityCheck
        public static string IntegrityCheckTitle { get; private set; }
        public static string TableCorrect { get; private set; }
        public static string TableHasErrors { get; private set; }
        public static string LostPrimaryKeys { get; private set; }
        public static string BaseCorrect { get; private set; }
        public static string BaseHasErrors { get; private set; }
        public static string IntegrityCheckError { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Forms.FrmCnlClone
        public static string KeepUnchanged { get; private set; }
        public static string CloneChannelsCompleted { get; private set; }
        public static string CloneChannelsError { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Forms.FrmFindObject
        public static string ObjectNotFound { get; private set; }
        public static string SearchCompleted { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Forms.FrmObjectEditor
        public static string ObjNumInUse { get; private set; }
        public static string ObjNumReferenced { get; private set; }
        public static string ObjectReferenced { get; private set; }
        public static string ParentObjectNotExists { get; private set; }
        public static string InvalidParentObject { get; private set; }
        public static string UpdateObjNumError { get; private set; }
        public static string UpdateParentObjError { get; private set; }
        public static string DeleteObjectConfirm { get; private set; }
        public static string ObjectFilter { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Forms.FrmRightMatrix
        public static string ViewRightSymbol { get; private set; }
        public static string ViewRightLegend { get; private set; }
        public static string ControlRightSymbol { get; private set; }
        public static string ControlRightLegend { get; private set; }
        public static string DisplayMatrixError { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Forms.FrmTableExport
        public static string ExportTableFilter { get; private set; }
        public static string ExportTableError { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Forms.FrmTableImport
        public static string ImportTableFilter { get; private set; }
        public static string ImportTableCompleted { get; private set; }
        public static string ImportTableError { get; private set; }

        // Scada.Admin.Extensions.ExtProjectTools.Code.ObjectMap
        public static string ObjectMapTitle { get; private set; }
        public static string NoObjects { get; private set; }
        public static string GenerateObjectMapError { get; private set; }

        public static void Init()
        {
            LocaleDict dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Code.ChannelMap");
            MapByDeviceTitle = dict[nameof(MapByDeviceTitle)];
            MapByObjectTitle = dict[nameof(MapByObjectTitle)];
            ChannelsCaption = dict[nameof(ChannelsCaption)];
            NoChannels = dict[nameof(NoChannels)];
            GenerateChannelMapError = dict[nameof(GenerateChannelMapError)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Code.DeviceMap");
            DeviceMapTitle = dict[nameof(DeviceMapTitle)];
            DevicesCaption = dict[nameof(DevicesCaption)];
            NoDevices = dict[nameof(NoDevices)];
            EmptyCommLine = dict[nameof(EmptyCommLine)];
            GenerateDeviceMapError = dict[nameof(GenerateDeviceMapError)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Code.IntegrityCheck");
            IntegrityCheckTitle = dict[nameof(IntegrityCheckTitle)];
            TableCorrect = dict[nameof(TableCorrect)];
            TableHasErrors = dict[nameof(TableHasErrors)];
            LostPrimaryKeys = dict[nameof(LostPrimaryKeys)];
            BaseHasErrors = dict[nameof(BaseHasErrors)];
            IntegrityCheckError = dict[nameof(IntegrityCheckError)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Forms.FrmCnlClone");
            KeepUnchanged = dict[nameof(KeepUnchanged)];
            CloneChannelsCompleted = dict[nameof(CloneChannelsCompleted)];
            CloneChannelsError = dict[nameof(CloneChannelsError)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Forms.FrmFindObject");
            ObjectNotFound = dict[nameof(ObjectNotFound)];
            SearchCompleted = dict[nameof(SearchCompleted)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Forms.FrmObjectEditor");
            ObjNumInUse = dict[nameof(ObjNumInUse)];
            ObjNumReferenced = dict[nameof(ObjNumReferenced)];
            ObjectReferenced = dict[nameof(ObjectReferenced)];
            ParentObjectNotExists = dict[nameof(ParentObjectNotExists)];
            InvalidParentObject = dict[nameof(InvalidParentObject)];
            UpdateObjNumError = dict[nameof(UpdateObjNumError)];
            UpdateParentObjError = dict[nameof(UpdateParentObjError)];
            DeleteObjectConfirm = dict[nameof(DeleteObjectConfirm)];
            ObjectFilter = dict[nameof(ObjectFilter)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Forms.FrmRightMatrix");
            ViewRightSymbol = dict[nameof(ViewRightSymbol)];
            ViewRightLegend = dict[nameof(ViewRightLegend)];
            ControlRightSymbol = dict[nameof(ControlRightSymbol)];
            ControlRightLegend = dict[nameof(ControlRightLegend)];
            DisplayMatrixError = dict[nameof(DisplayMatrixError)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Forms.FrmTableExport");
            ExportTableFilter = dict[nameof(ExportTableFilter)];
            ExportTableError = dict[nameof(ExportTableError)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Forms.FrmTableImport");
            ImportTableFilter = dict[nameof(ImportTableFilter)];
            ImportTableCompleted = dict[nameof(ImportTableCompleted)];
            ImportTableError = dict[nameof(ImportTableError)];

            dict = Locale.GetDictionary("Scada.Admin.Extensions.ExtProjectTools.Code.ObjectMap");
            ObjectMapTitle = dict[nameof(ObjectMapTitle)];
            NoObjects = dict[nameof(NoObjects)];
            GenerateObjectMapError = dict[nameof(GenerateObjectMapError)];
        }
    }
}
