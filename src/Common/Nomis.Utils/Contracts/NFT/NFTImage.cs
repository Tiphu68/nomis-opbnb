﻿// ------------------------------------------------------------------------------------------------------
// <copyright file="NFTImage.cs" company="Nomis">
// Copyright (c) Nomis, 2023. All rights reserved.
// The Application under the MIT license. See LICENSE file in the solution root for full license information.
// </copyright>
// ------------------------------------------------------------------------------------------------------

namespace Nomis.Utils.Contracts.NFT
{
    /// <summary>
    /// NFT image.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class NFTImage
    {
        /// <summary>
        /// The image.
        /// </summary>
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image type.
        /// </summary>
        public string? ImageType { get; set; }
    }
}