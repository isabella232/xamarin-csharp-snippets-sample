﻿//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Xamarin_CS_Snippets
{
    public class StoryDefinition : ViewModelBase
    {
        public string GroupName { get; set; }
        public string Title { get; set; }

        public string ScopeGroup { get; set; }

        // Delegate method to call
        public Func<Task<bool>> RunStoryAsync { get; set; }

        bool _isRunning = false;
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                SetProperty(ref _isRunning, value);
            }
        }

        bool? _result = null;
        public bool? Result
        {
            get
            {
                return _result;
            }
            set
            {
                SetProperty(ref _result, value);
            }
        }

        long? _durationMS = 0;
        public long? DurationMS
        {
            get
            {
                return _durationMS;
            }
            set
            {
                SetProperty(ref _durationMS, value);
            }
        }

    }


}

