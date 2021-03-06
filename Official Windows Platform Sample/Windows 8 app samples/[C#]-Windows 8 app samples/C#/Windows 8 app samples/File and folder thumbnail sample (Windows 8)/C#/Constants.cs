﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace SDKTemplate
{
    internal class FileExtensions
    {
        public static readonly string[] Document = new string[] { ".doc", ".xls", ".ppt", ".docx", ".xlsx", ".pptx", ".pdf", ".txt", ".rtf" };
        public static readonly string[] Image    = new string[] { ".jpg", ".png", ".bmp", ".gif", ".tif" };
        public static readonly string[] Music    = new string[] { ".mp3", ".wma", ".m4a", ".aac" };
    }

    internal class Errors
    {
        public static readonly string NoExifThumbnail   = "No result (no EXIF thumbnail or cached thumbnail available for fast retrieval)";
        public static readonly string NoThumbnail       = "No result (no thumbnail could be obtained from the selected file)";
        public static readonly string NoAlbumArt        = "No result (no album art available for this song)";
        public static readonly string NoIcon            = "No result (no icon available for this document type)";
        public static readonly string NoImages          = "No result (no thumbnail could be obtained from the selected folder - make sure that the folder contains images)";
        public static readonly string FileGroupEmpty    = "No result (unexpected error: retrieved file group was null)";
        public static readonly string FileGroupLocation = "File groups are only available for library locations, please select a folder from one of your libraries";
        public static readonly string Cancel            = "No result (operation cancelled, no item selected)";
    }

    public partial class MainPage : SDKTemplate.Common.LayoutAwarePage
    {
        public const string FEATURE_NAME = "File thumbnails C# sample";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title = "Display a thumbnail for a picture",    ClassType = typeof(FileThumbnails.Scenario1) },
            new Scenario() { Title = "Display album art for a song",         ClassType = typeof(FileThumbnails.Scenario2) },
            new Scenario() { Title = "Display an icon for a document",       ClassType = typeof(FileThumbnails.Scenario3) },
            new Scenario() { Title = "Display a thumbnail for a folder",     ClassType = typeof(FileThumbnails.Scenario4) },
            new Scenario() { Title = "Display a thumbnail for a file group", ClassType = typeof(FileThumbnails.Scenario5) },
        };

        private BitmapImage _placeholder;
        private BitmapImage PlaceHolderImage
        {
            get
            {
                if (_placeholder == null)
                {
                    _placeholder = new BitmapImage(new Uri(this.BaseUri, "Assets/placeholder-sdk.png"));
                }
                return _placeholder;
            }
        }

        internal bool EnsureUnsnapped()
        {
            // FilePicker APIs will not work if the application is in a snapped state.
            // If an app wants to show a FilePicker while snapped, it must attempt to unsnap first
            bool unsnapped = ((ApplicationView.Value != ApplicationViewState.Snapped) || ApplicationView.TryUnsnap());
            if (!unsnapped)
            {
                NotifyUser("Cannot unsnap the sample.", NotifyType.StatusMessage);
            }

            return unsnapped;
        }

        public static void DisplayResult(Image image, TextBlock textBlock, string thumbnailModeName, uint size, IStorageItem item, StorageItemThumbnail thumbnail, bool isGroup)
        {
            // ErrorMessage.Visibility = Visibility.Collapsed;
            BitmapImage bitmapImage = new BitmapImage();

            bitmapImage.SetSource(thumbnail);
            image.Source = bitmapImage;

            textBlock.Text = String.Format("ThumbnailMode.{0}\n"
                                           + "{1} used: {2}\n"
                                           + "Requested size: {3}\n"
                                           + "Returned size: {4}x{5}",
                                           thumbnailModeName,
                                           isGroup ? "Group" : item.IsOfType(StorageItemTypes.File) ? "File" : "Folder",
                                           item.Name,
                                           size,
                                           thumbnail.OriginalWidth,
                                           thumbnail.OriginalHeight);
        }

        public void ResetOutput(Image image, TextBlock output, TextBlock outputDetails = null)
        {
            image.Source = PlaceHolderImage;
            NotifyUser("", NotifyType.ErrorMessage);
            NotifyUser("", NotifyType.StatusMessage);
            output.Text = "";
            if (outputDetails != null)
            {
                outputDetails.Text = "";
            }
        }
    }

    public class Scenario
    {
        public string Title { get; set; }

        public Type ClassType { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
