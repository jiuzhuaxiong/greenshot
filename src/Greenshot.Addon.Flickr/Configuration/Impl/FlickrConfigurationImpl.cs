﻿#region Greenshot GNU General Public License

// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

using Dapplo.Config.Ini;
using Greenshot.Core.Enums;

namespace Greenshot.Addon.Flickr.Configuration.Impl
{
    public class FlickrConfigurationImpl : IniSectionBase<IFlickrConfiguration>, IFlickrConfiguration
    {
        #region Implementation of IFileConfiguration

        public string OutputFilePath { get; set; }
        public bool OutputFileAllowOverwrite { get; set; }
        public string OutputFileFilenamePattern { get; set; }
        public OutputFormats OutputFileFormat { get; set; }
        public bool OutputFileReduceColors { get; set; }
        public bool OutputFileAutoReduceColors { get; set; }
        public int OutputFileReduceColorsTo { get; set; }
        public int OutputFileJpegQuality { get; set; }
        public bool OutputFilePromptQuality { get; set; }
        public uint OutputFileIncrementingNumber { get; set; }
        public string OptimizePNGCommand { get; set; }
        public string OptimizePNGCommandArguments { get; set; }

        #endregion

        #region Implementation of IDestinationFileConfiguration

        public bool UseOwnSettings { get; set; }

        #endregion

        #region Implementation of IOAuth1Token

        public string OAuthToken { get; set; }
        public string OAuthTokenSecret { get; set; }
        public string OAuthTokenVerifier { get; set; }

        #endregion

        #region Implementation of IFlickrConfiguration

        public bool IsPublic { get; set; }
        public bool IsFamily { get; set; }
        public bool IsFriend { get; set; }
        public SafetyLevel SafetyLevel { get; set; }
        public bool HiddenFromSearch { get; set; }
        public bool AfterUploadLinkToClipBoard { get; set; }
        public bool UsePageLink { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        #endregion
    }
}
