﻿using System;
using System.Diagnostics;
using CoreLocation;
using Foundation;
using UIKit;
using MapboxCoreMaps;
using MapboxMaps;
using MapboxMapsObjC;
using MapKit;

namespace Mapbox.iOSQs
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public T GetValueFromExpression<T>(NSExpression expr) where T : NSObject
        {
            if (expr == null) return default(T);
            switch (expr.ExpressionType)
            {
                case NSExpressionType.ConstantValue:
                    return expr.ConstantValue as T;
                case NSExpressionType.NSAggregate:
                    if (expr.Collection is T)
                        return expr.Collection as T;
                    if (expr.Collection is NSArray array
                        && array.Count != 0)
                    {
                        var first = array.GetItem<T>(0);
                        if (first is NSExpression innerExpr)
                        {
                            return GetValueFromExpression<T>(innerExpr);
                        }
                        return first;
                    }
                    return default(T);
                case NSExpressionType.Function:
                    //TODO
                    var function = expr.Function; //"mgl_interpolate:withCurveType:parameters:stops:"
                    if (expr.Arguments is NSExpression[] args)// $zoomLevel, exponential, 1.299999, {{ 13 = "0.5", 20 = 2;}}
                    {
                        //TODO
                    }
                    return default(T);
                default:
                    return default(T);
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MapInitOptions options = MapInitOptionsFactory.CreateWithResourceOptions(
                null,
                null,
                null,
                "mapbox://styles/examples/cke97f49z5rlg19l310b7uu7j",
                null);
            // Perform any additional setup after loading the view, typically from a nib.
            var mapView = MapViewFactory.CreateWithFrame(
                View.Bounds,
                options
            );
            mapView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight
                | UIViewAutoresizing.FlexibleWidth;

            View.AddSubview(mapView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
