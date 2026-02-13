using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaLiteUI;

public static class RandomExtension
{
    // return [0..max.X), [0..max.Y)
    public static Vector NextVector(this Random random, Vector max)
    {
        return new Vector(random.NextSingle() * max.X, random.NextSingle() * max.Y);
    }

    public static SKColor NextColor(this Random rand)
    {
        return new SKColor(     (byte)rand.Next(256), 
                                (byte)rand.Next(256), 
                                (byte)rand.Next(256));
    }

    public static RectWidget CreateRectWidget(this Random rand, Vector max, Vector size)
    {
        var widget = new RectWidget(rand.NextVector(max), size) {
            Color = rand.NextColor()
        };
        return widget;
    }
}

public static class Util
{
    public static SKPaint CreatePaint(SKColor color)
    {
        return new()
        {
            Color = color,
            IsAntialias = true,
            Style = SKPaintStyle.Fill,
        };
    }
}
