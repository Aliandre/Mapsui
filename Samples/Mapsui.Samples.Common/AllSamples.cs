﻿using System;
using System.Collections.Generic;
using Mapsui.Samples.Common.Maps;

namespace Mapsui.Samples.Common
{
    public static class AllSamples
    {
        public static Dictionary<string, Func<Map>> CreateList()
        {
            return new Dictionary<string, Func<Map>>
            {
                ["OpenStreetMap"] = OsmSample.CreateMap,
                ["Bing maps"] = BingSample.CreateMap,
                ["Simple Points"] = PointsSample.CreateMap,
                ["Simple LineStrings"] = LineStringSample.CreateMap,
                ["Simple Polygons"] = PolygonSample.CreateMap,
                ["Various"] = VariousSample.CreateMap,
                ["Labels"] = LabelsSample.CreateMap,
                ["Center on location"] = CenterOnLocationSample.CreateMap,
                ["Projected point"] = ProjectionSample.CreateMap,
                ["Stacked labels"] = StackedLabelsSample.CreateMap,
                ["Symbols"] = SymbolsSample.CreateMap,
                ["Info"] = InfoLayersSample.CreateMap,
                ["MbTiles"] = MbTilesSample.CreateMap,
                ["Animated point movement"] = AnimatedPointsSample.CreateMap,
                ["WMTS"] = WmtsSample.CreateMap,
                ["WMS called tiled"] = TiledWmsSample.CreateMap,
                ["Rasterizing Layer"] = RasterizingLayerSample.CreateMap,
                ["Empty Map"] = EmptyMapSample.CreateMap,
                ["Mutating triangle"] = MutatingTriangleSample.CreateMap,
                ["Symbols in World Units"] = SymbolsInWorldUnitsSample.CreateMap
            };
        }
    }
}
