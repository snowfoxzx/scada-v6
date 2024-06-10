﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Scada.Web.Api;
using Scada.Web.Authorization;
using Scada.Web.Lang;
using Scada.Web.Plugins.PlgMimic.Controllers;
using Scada.Web.Plugins.PlgMimic.Models;
using Scada.Web.Plugins.PlgMimicEditor.Code;
using Scada.Web.Services;

namespace Scada.Web.Plugins.PlgMimicEditor.Controllers
{
    /// <summary>
    /// Represents the mimic editor web API.
    /// <para>Представляет веб-API редактора мнемосхем.</para>
    /// </summary>
    [ApiController]
    [Route("Api/MimicEditor/[action]")]
    [Authorize(Policy = PolicyName.Administrators)]
    [CamelCaseJsonFormatter]
    public class MimicEditorApiController(
        IWebContext webContext,
        EditorManager editorManager) : ControllerBase, IMimicApiController
    {
        /// <summary>
        /// Gets the mimic properties.
        /// </summary>
        public Dto<MimicPacket> GetMimicProperties(long key)
        {
            try
            {
                if (editorManager.FindMimic(key, out MimicInstance mimicInstance, out string errMsg))
                {
                    return Dto<MimicPacket>.Success(new MimicPacket
                    {
                        MimicStamp = key,
                        Dependencies = mimicInstance.Mimic.Dependencies,
                        Document = mimicInstance.Mimic.Document
                    });
                }
                else
                {
                    return Dto<MimicPacket>.Fail(errMsg);
                }
            }
            catch (Exception ex)
            {
                webContext.Log.WriteError(ex.BuildErrorMessage(WebPhrases.ErrorInWebApi, nameof(GetMimicProperties)));
                return Dto<MimicPacket>.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Gets a range of components.
        /// </summary>
        public Dto<ComponentPacket> GetComponents(long key, int index, int count)
        {
            return null;
        }

        /// <summary>
        /// Gets a range of images.
        /// </summary>
        public Dto<ComponentPacket> GetImages(long key, int index, int count, int size)
        {
            return null;
        }

        /// <summary>
        /// Gets the faceplate.
        /// </summary>
        public Dto<FaceplatePacket> GetFaceplate(long key, string typeName)
        {
            return null;
        }
    }
}