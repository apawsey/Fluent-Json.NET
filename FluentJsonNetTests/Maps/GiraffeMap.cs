﻿using FluentJsonNet;
using FluentJsonNetTests.Models;

namespace FluentJsonNetTests.Maps
{
    public class GiraffeMap : JsonSubclassMap<Giraffe>
    {
        public GiraffeMap()
        {
            this.Map(x => x.Height, "Height");
        }
    }
}