﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Vertix
{
    class SearchServiceBinder : Binder
    {
        private Service Service;

        public SearchServiceBinder(Service service) {
            this.Service = service;
        }

        public void GetSuggestion(string partialQuery)
        {
            /*
            CursorAdapter neo = new CursorAdapter(new string[] { "_ID", "query" });

            return neo;
            */
        }
    }
}