﻿using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace Docker.DotNet.Models
{
    internal class JsonQueryStringConverter : IQueryStringConverter
    {
        public bool CanConvert(Type t)
        {
            return true;
        }

        public string[] Convert(object o)
        {
            Debug.Assert(o != null);

            return new[] { JsonConvert.SerializeObject(o, Formatting.None) };
        }
    }
}