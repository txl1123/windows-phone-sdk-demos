﻿#pragma checksum "C:\Users\Cloud\Documents\windows-phone-sdk-demos\LeanCloud.Demo.CSharp\LeanCloud.LeanMeaasge.Demo.WindowsPhone8(&8.1).Silverlight\Media\AudioRecord.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "23926B5FF53C577A05FAD573FBB1DF77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace LeanCloud.LeanMeaasge.Demo.Media {
    
    
    public partial class AudioRecord : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Shell.ApplicationBar PhoneAppBar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton StartRecording;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton StopPlaybackRecording;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/LeanCloud.LeanMeaasge.Demo;component/Media/AudioRecord.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PhoneAppBar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("PhoneAppBar")));
            this.StartRecording = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("StartRecording")));
            this.StopPlaybackRecording = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("StopPlaybackRecording")));
        }
    }
}
