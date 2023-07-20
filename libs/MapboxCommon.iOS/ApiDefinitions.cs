using CoreLocation;
using Foundation;
using MapboxCommon;
using ObjCRuntime;
using System;

namespace MapboxCommon
{
	// typedef void (^MBXDataCallback)(NSData * _Nonnull);
	delegate void MBXDataCallback (NSData arg0);

	// @interface MBXDataRef : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXDataRef
	{
		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		IntPtr Constructor (NSData data);

		// -(instancetype _Nonnull)initWithMutableData:(NSMutableData * _Nonnull)mutableData;
		[Export ("initWithMutableData:")]
		IntPtr Constructor (NSMutableData mutableData);

		// -(void)withData:(MBXDataCallback _Nonnull)callback __attribute__((swift_name("withData(_:)")));
		[Export ("withData:")]
		void WithData (MBXDataCallback callback);
	}

	// @interface MBXFeature : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXFeature
	{
		// @property (readonly, retain) NSObject * _Nonnull identifier;
		[Export ("identifier", ArgumentSemantic.Retain)]
		NSObject Identifier { get; }

		// @property (readonly, retain) MBXGeometry * _Nonnull geometry;
		[Export ("geometry", ArgumentSemantic.Retain)]
		MBXGeometry Geometry { get; }

		// @property (readonly, retain) NSDictionary<NSString *,NSObject *> * _Nonnull properties;
		[Export ("properties", ArgumentSemantic.Retain)]
		NSDictionary Properties { get; }

		// -(instancetype _Nonnull)initWithIdentifier:(NSObject * _Nonnull)identifier geometry:(MBXGeometry * _Nonnull)geometry properties:(NSDictionary<NSString *,NSObject *> * _Nonnull)properties;
		[Export ("initWithIdentifier:geometry:properties:")]
		IntPtr Constructor (NSObject identifier, MBXGeometry geometry, NSDictionary properties);
	}

	// @interface MBXGeometry : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXGeometry
	{
		// @property (readonly, assign) MBXGeometryType geometryType;
		[Export ("geometryType", ArgumentSemantic.Assign)]
		MBXGeometryType GeometryType { get; }

		// @property (readonly, assign) void * _Nonnull geometry;
		[Export ("geometry", ArgumentSemantic.Assign)]
		unsafe IntPtr Geometry { get; }

		// -(instancetype _Nonnull)initWithPoint:(NSValue * _Nonnull)location;
		[Export ("initWithPoint:")]
		IntPtr Constructor (NSValue location);

		// -(instancetype _Nonnull)initWithLine:(NSArray<NSValue *> * _Nonnull)locations;
		[Export ("initWithLine:")]
		IntPtr Constructor (NSValue[] locations);

		// -(instancetype _Nonnull)initWithPolygon:(NSArray<NSArray<NSValue *> *> * _Nonnull)locations;
		[Export ("initWithPolygon:")]
		IntPtr Constructor (NSArray locations);

		// TODO add support method
		// // -(instancetype _Nonnull)initWithMultiPoint:(NSArray<NSValue *> * _Nonnull)locations;
		// [Export ("initWithMultiPoint:")]
		// IntPtr Constructor (NSValue[] locations);

		// TODO add support method
		// // -(instancetype _Nonnull)initWithMultiLine:(NSArray<NSArray<NSValue *> *> * _Nonnull)locations;
		// [Export ("initWithMultiLine:")]
		// IntPtr Constructor (NSArray locations);

		// -(instancetype _Nonnull)initWithMultiPolygon:(NSArray<NSArray<NSArray<NSValue *> *> *> * _Nonnull)locations;
		[Export ("initWithMultiPolygon:")]
		IntPtr Constructor (NSArray[] locations);

		// -(instancetype _Nonnull)initWithGeometryCollection:(NSArray<MBXGeometry *> * _Nonnull)geometries;
		[Export ("initWithGeometryCollection:")]
		IntPtr Constructor (MBXGeometry[] geometries);

		// -(NSValue * _Nullable)extractLocations;
		[NullAllowed, Export ("extractLocations")]
		NSValue ExtractLocations ();

		// -(NSArray<NSValue *> * _Nullable)extractLocationsArray;
		[NullAllowed, Export ("extractLocationsArray")]
		NSValue[] ExtractLocationsArray ();

		// -(NSArray<NSArray<NSValue *> *> * _Nullable)extractLocations2DArray;
		[NullAllowed, Export ("extractLocations2DArray")]
		NSArray ExtractLocations2DArray ();

		// -(NSArray<NSArray<NSArray<NSValue *> *> *> * _Nullable)extractLocations3DArray;
		[NullAllowed, Export ("extractLocations3DArray")]
		NSArray ExtractLocations3DArray();

		// -(NSArray<MBXGeometry *> * _Nullable)extractGeometriesArray;
		[NullAllowed, Export ("extractGeometriesArray")]
		MBXGeometry[] ExtractGeometriesArray ();
	}

	// @interface MBXTilesetDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTilesetDescriptor
	{
	}

	// @interface MBXCancelable : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXCancelable
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();
	}

	// @interface MBXUAComponents : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXUAComponents
	{
		// -(instancetype _Nonnull)initWithAppNameComponent:(NSString * _Nonnull)appNameComponent appVersionComponent:(NSString * _Nonnull)appVersionComponent appIdentifierComponent:(NSString * _Nonnull)appIdentifierComponent appBuildNumberComponent:(NSString * _Nonnull)appBuildNumberComponent osNameComponent:(NSString * _Nonnull)osNameComponent osVersionComponent:(NSString * _Nonnull)osVersionComponent sdkNameComponent:(NSString * _Nonnull)sdkNameComponent sdkVersionComponent:(NSString * _Nonnull)sdkVersionComponent sdkIdentifierComponent:(NSString * _Nonnull)sdkIdentifierComponent sdkBuildNumberComponent:(NSString * _Nonnull)sdkBuildNumberComponent;
		[Export ("initWithAppNameComponent:appVersionComponent:appIdentifierComponent:appBuildNumberComponent:osNameComponent:osVersionComponent:sdkNameComponent:sdkVersionComponent:sdkIdentifierComponent:sdkBuildNumberComponent:")]
		IntPtr Constructor (string appNameComponent, string appVersionComponent, string appIdentifierComponent, string appBuildNumberComponent, string osNameComponent, string osVersionComponent, string sdkNameComponent, string sdkVersionComponent, string sdkIdentifierComponent, string sdkBuildNumberComponent);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appNameComponent;
		[Export ("appNameComponent")]
		string AppNameComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appVersionComponent;
		[Export ("appVersionComponent")]
		string AppVersionComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appIdentifierComponent;
		[Export ("appIdentifierComponent")]
		string AppIdentifierComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appBuildNumberComponent;
		[Export ("appBuildNumberComponent")]
		string AppBuildNumberComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull osNameComponent;
		[Export ("osNameComponent")]
		string OsNameComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull osVersionComponent;
		[Export ("osVersionComponent")]
		string OsVersionComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkNameComponent;
		[Export ("sdkNameComponent")]
		string SdkNameComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkVersionComponent;
		[Export ("sdkVersionComponent")]
		string SdkVersionComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkIdentifierComponent;
		[Export ("sdkIdentifierComponent")]
		string SdkIdentifierComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkBuildNumberComponent;
		[Export ("sdkBuildNumberComponent")]
		string SdkBuildNumberComponent { get; }
	}

	// @interface MBXHttpRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpRequest
	{
		// -(instancetype _Nonnull)initWithUrl:(NSString * _Nonnull)url headers:(NSDictionary<NSString *,NSString *> * _Nonnull)headers uaComponents:(MBXUAComponents * _Nonnull)uaComponents body:(NSData * _Nullable)body;
		[Export ("initWithUrl:headers:uaComponents:body:")]
		IntPtr Constructor (string url, NSDictionary headers, MBXUAComponents uaComponents, [NullAllowed] NSData body);

		// -(instancetype _Nonnull)initWithMethod:(MBXHttpMethod)method url:(NSString * _Nonnull)url headers:(NSDictionary<NSString *,NSString *> * _Nonnull)headers keepCompression:(BOOL)keepCompression timeout:(uint64_t)timeout networkRestriction:(MBXNetworkRestriction)networkRestriction uaComponents:(MBXUAComponents * _Nonnull)uaComponents body:(NSData * _Nullable)body;
		[Export ("initWithMethod:url:headers:keepCompression:timeout:networkRestriction:uaComponents:body:")]
		IntPtr Constructor (MBXHttpMethod method, string url, NSDictionary headers, bool keepCompression, ulong timeout, MBXNetworkRestriction networkRestriction, MBXUAComponents uaComponents, [NullAllowed] NSData body);

		// @property (readwrite, nonatomic) MBXHttpMethod method;
		[Export ("method", ArgumentSemantic.Assign)]
		MBXHttpMethod Method { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export ("url")]
		string Url { get; }

		// @property (readwrite, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary Headers { get; set; }

		// @property (readonly, getter = isKeepCompression, nonatomic) BOOL keepCompression;
		[Export ("keepCompression")]
		bool KeepCompression { [Bind ("isKeepCompression")] get; }

		// @property (readonly, nonatomic) uint64_t timeout;
		[Export ("timeout")]
		ulong Timeout { get; }

		// @property (readonly, nonatomic) MBXNetworkRestriction networkRestriction;
		[Export ("networkRestriction")]
		MBXNetworkRestriction NetworkRestriction { get; }

		// @property (readonly, nonatomic) MBXUAComponents * _Nonnull uaComponents;
		[Export ("uaComponents")]
		MBXUAComponents UaComponents { get; }

		// @property (readonly, nonatomic) NSData * _Nullable body;
		[NullAllowed, Export ("body")]
		NSData Body { get; }
	}

	// @interface MBXHttpRequestError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpRequestError
	{
		// -(instancetype _Nonnull)initWithType:(MBXHttpRequestErrorType)type message:(NSString * _Nonnull)message;
		[Export ("initWithType:message:")]
		IntPtr Constructor (MBXHttpRequestErrorType type, string message);

		// @property (readonly, nonatomic) MBXHttpRequestErrorType type;
		[Export ("type")]
		MBXHttpRequestErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXHttpResponseData : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpResponseData
	{
		// -(instancetype _Nonnull)initWithHeaders:(NSDictionary<NSString *,NSString *> * _Nonnull)headers code:(int64_t)code data:(NSData * _Nonnull)data;
		[Export ("initWithHeaders:code:data:")]
		IntPtr Constructor (NSDictionary headers, long code, NSData data);

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary Headers { get; }

		// @property (readonly, nonatomic) int64_t code;
		[Export ("code")]
		long Code { get; }

		// @property (readonly, nonatomic) NSData * _Nonnull data;
		[Export ("data")]
		NSData Data { get; }
	}

	// @interface MBXHttpResponse : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpResponse
	{
		// @property (readonly, nonatomic) MBXHttpRequest * _Nonnull request;
		[Export ("request")]
		MBXHttpRequest Request { get; }
	}

	// @interface MBXDownloadOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXDownloadOptions
	{
		// -(instancetype _Nonnull)initWithRequest:(MBXHttpRequest * _Nonnull)request localPath:(NSString * _Nonnull)localPath;
		[Export ("initWithRequest:localPath:")]
		IntPtr Constructor (MBXHttpRequest request, string localPath);

		// -(instancetype _Nonnull)initWithRequest:(MBXHttpRequest * _Nonnull)request localPath:(NSString * _Nonnull)localPath resume:(BOOL)resume;
		[Export ("initWithRequest:localPath:resume:")]
		IntPtr Constructor (MBXHttpRequest request, string localPath, bool resume);

		// @property (readwrite, nonatomic) MBXHttpRequest * _Nonnull request;
		[Export ("request", ArgumentSemantic.Assign)]
		MBXHttpRequest Request { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localPath;
		[Export ("localPath")]
		string LocalPath { get; }

		// @property (getter = isResume, readwrite, nonatomic) BOOL resume;
		[Export ("resume")]
		bool Resume { [Bind ("isResume")] get; set; }
	}

	// @interface MBXDownloadError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXDownloadError
	{
		// -(instancetype _Nonnull)initWithCode:(MBXDownloadErrorCode)code message:(NSString * _Nonnull)message;
		[Export ("initWithCode:message:")]
		IntPtr Constructor (MBXDownloadErrorCode code, string message);

		// @property (readonly, nonatomic) MBXDownloadErrorCode code;
		[Export ("code")]
		MBXDownloadErrorCode Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXDownloadStatus : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXDownloadStatus
	{
		// @property (readwrite, nonatomic) uint64_t downloadId;
		[Export ("downloadId")]
		ulong DownloadId { get; set; }

		// @property (readwrite, nonatomic) MBXDownloadState state;
		[Export ("state", ArgumentSemantic.Assign)]
		MBXDownloadState State { get; set; }

		// @property (readwrite, nonatomic) MBXDownloadError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Assign)]
		MBXDownloadError Error { get; set; }

		// @property (readwrite, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * totalBytes __attribute__((swift_private));
		[Export ("totalBytes", ArgumentSemantic.Assign)]
		NSNumber TotalBytes { get; set; }

		// @property (readwrite, nonatomic) uint64_t receivedBytes;
		[Export ("receivedBytes")]
		ulong ReceivedBytes { get; set; }

		// @property (readwrite, nonatomic) uint64_t transferredBytes;
		[Export ("transferredBytes")]
		ulong TransferredBytes { get; set; }

		// @property (readwrite, nonatomic) MBXDownloadOptions * _Nonnull downloadOptions;
		[Export ("downloadOptions", ArgumentSemantic.Assign)]
		MBXDownloadOptions DownloadOptions { get; set; }
	}

	partial interface IMBXHttpServiceInterface {}

	// @interface MBXHttpServiceFactory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpServiceFactory
	{
		// +(void)setUserDefinedForCustom:(id<MBXHttpServiceInterface> _Nonnull)custom;
		[Static]
		[Export ("setUserDefinedForCustom:")]
		void SetUserDefinedForCustom (IMBXHttpServiceInterface custom);

		// +(void)reset;
		[Static]
		[Export ("reset")]
		void Reset ();

		// +(id<MBXHttpServiceInterface> _Nonnull)getInstance __attribute__((ns_returns_retained));
		[Static]
		[Export ("getInstance")]
		IMBXHttpServiceInterface Instance { get; }
	}

	// @protocol MBXHttpServiceInterceptorInterface
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface MBXHttpServiceInterceptorInterface
	{
		// @required -(MBXHttpRequest * _Nonnull)onRequestForRequest:(MBXHttpRequest * _Nonnull)request;
		[Abstract]
		[Export ("onRequestForRequest:")]
		MBXHttpRequest OnRequestForRequest (MBXHttpRequest request);

		// @required -(MBXDownloadOptions * _Nonnull)onDownloadForDownload:(MBXDownloadOptions * _Nonnull)download;
		[Abstract]
		[Export ("onDownloadForDownload:")]
		MBXDownloadOptions OnDownloadForDownload (MBXDownloadOptions download);

		// @required -(MBXHttpResponse * _Nonnull)onResponseForResponse:(MBXHttpResponse * _Nonnull)response;
		[Abstract]
		[Export ("onResponseForResponse:")]
		MBXHttpResponse OnResponseForResponse (MBXHttpResponse response);
	}

	// typedef void (^MBXDownloadStatusCallback)(MBXDownloadStatus * _Nonnull);
	delegate void MBXDownloadStatusCallback (MBXDownloadStatus arg0);

	// typedef void (^MBXHttpResponseCallback)(MBXHttpResponse * _Nonnull);
	delegate void MBXHttpResponseCallback (MBXHttpResponse arg0);

	// typedef void (^MBXResultCallback)(BOOL);
	delegate void MBXResultCallback (bool arg0);

	partial interface IMBXHttpServiceInterceptorInterface {}

	// @protocol MBXHttpServiceInterface
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface MBXHttpServiceInterface
	{
		// @required -(void)setInterceptorForInterceptor:(id<MBXHttpServiceInterceptorInterface> _Nullable)interceptor;
		[Abstract]
		[Export ("setInterceptorForInterceptor:")]
		void SetInterceptorForInterceptor ([NullAllowed] IMBXHttpServiceInterceptorInterface interceptor);

		// @required -(void)setMaxRequestsPerHostForMax:(uint8_t)max;
		[Abstract]
		[Export ("setMaxRequestsPerHostForMax:")]
		void SetMaxRequestsPerHostForMax (byte max);

		// @required -(uint64_t)requestForRequest:(MBXHttpRequest * _Nonnull)request callback:(MBXHttpResponseCallback _Nonnull)callback;
		[Abstract]
		[Export ("requestForRequest:callback:")]
		ulong RequestForRequest (MBXHttpRequest request, MBXHttpResponseCallback callback);

		// @required -(void)cancelRequestForId:(uint64_t)id callback:(MBXResultCallback _Nonnull)callback;
		[Abstract]
		[Export ("cancelRequestForId:callback:")]
		void CancelRequestForId (ulong id, MBXResultCallback callback);

		// @required -(BOOL)supportsKeepCompression;
		[Abstract]
		[Export ("supportsKeepCompression")]
		bool SupportsKeepCompression { get; }

		// @required -(uint64_t)downloadForOptions:(MBXDownloadOptions * _Nonnull)options callback:(MBXDownloadStatusCallback _Nonnull)callback;
		[Abstract]
		[Export ("downloadForOptions:callback:")]
		ulong DownloadForOptions (MBXDownloadOptions options, MBXDownloadStatusCallback callback);
	}

	// @interface MBXHttpHeaders : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXHttpHeaders
	{
		// @property (readonly, nonatomic, class) NSString * CacheControl;
		[Static]
		[Export ("CacheControl")]
		string CacheControl { get; }

		// @property (readonly, nonatomic, class) NSString * ContentEncoding;
		[Static]
		[Export ("ContentEncoding")]
		string ContentEncoding { get; }

		// @property (readonly, nonatomic, class) NSString * ContentLength;
		[Static]
		[Export ("ContentLength")]
		string ContentLength { get; }

		// @property (readonly, nonatomic, class) NSString * ContentType;
		[Static]
		[Export ("ContentType")]
		string ContentType { get; }

		// @property (readonly, nonatomic, class) NSString * Digest;
		[Static]
		[Export ("Digest")]
		string Digest { get; }

		// @property (readonly, nonatomic, class) NSString * ETag;
		[Static]
		[Export ("ETag")]
		string ETag { get; }

		// @property (readonly, nonatomic, class) NSString * IfNoneMatch;
		[Static]
		[Export ("IfNoneMatch")]
		string IfNoneMatch { get; }

		// @property (readonly, nonatomic, class) NSString * LastModified;
		[Static]
		[Export ("LastModified")]
		string LastModified { get; }

		// @property (readonly, nonatomic, class) NSString * UserAgent;
		[Static]
		[Export ("UserAgent")]
		string UserAgent { get; }

		// @property (readonly, nonatomic, class) NSString * XAcceptEncoding;
		[Static]
		[Export ("XAcceptEncoding")]
		string XAcceptEncoding { get; }

		// @property (readonly, nonatomic, class) NSString * XContentEncoding;
		[Static]
		[Export ("XContentEncoding")]
		string XContentEncoding { get; }

		// @property (readonly, nonatomic, class) NSString * XAcceptDelta;
		[Static]
		[Export ("XAcceptDelta")]
		string XAcceptDelta { get; }

		// @property (readonly, nonatomic, class) NSString * XCanonicalETag;
		[Static]
		[Export ("XCanonicalETag")]
		string XCanonicalETag { get; }

		// @property (readonly, nonatomic, class) NSString * XDeltaBase;
		[Static]
		[Export ("XDeltaBase")]
		string XDeltaBase { get; }

		// @property (readonly, nonatomic, class) NSString * XRateLimitReset;
		[Static]
		[Export ("XRateLimitReset")]
		string XRateLimitReset { get; }

		// @property (readonly, nonatomic, class) NSString * XAppInfo;
		[Static]
		[Export ("XAppInfo")]
		string XAppInfo { get; }
	}

	// @interface MBXLocation : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXLocation
	{
		// -(instancetype _Nonnull)initWithLatitude:(double)latitude longitude:(double)longitude timestamp:(uint64_t)timestamp monotonicTimestamp:(NSNumber * _Nullable)monotonicTimestamp altitude:(NSNumber * _Nullable)altitude horizontalAccuracy:(NSNumber * _Nullable)horizontalAccuracy verticalAccuracy:(NSNumber * _Nullable)verticalAccuracy speed:(NSNumber * _Nullable)speed speedAccuracy:(NSNumber * _Nullable)speedAccuracy bearing:(NSNumber * _Nullable)bearing bearingAccuracy:(NSNumber * _Nullable)bearingAccuracy floor:(NSNumber * _Nullable)floor source:(NSString * _Nullable)source extra:(id _Nullable)extra;
		[Export ("initWithLatitude:longitude:timestamp:monotonicTimestamp:altitude:horizontalAccuracy:verticalAccuracy:speed:speedAccuracy:bearing:bearingAccuracy:floor:source:extra:")]
		IntPtr Constructor (double latitude, double longitude, ulong timestamp, [NullAllowed] NSNumber monotonicTimestamp, [NullAllowed] NSNumber altitude, [NullAllowed] NSNumber horizontalAccuracy, [NullAllowed] NSNumber verticalAccuracy, [NullAllowed] NSNumber speed, [NullAllowed] NSNumber speedAccuracy, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber bearingAccuracy, [NullAllowed] NSNumber floor, [NullAllowed] string source, [NullAllowed] NSObject extra);

		// @property (readonly, nonatomic) double latitude;
		[Export ("latitude")]
		double Latitude { get; }

		// @property (readonly, nonatomic) double longitude;
		[Export ("longitude")]
		double Longitude { get; }

		// @property (readonly, nonatomic) uint64_t timestamp;
		[Export ("timestamp")]
		ulong Timestamp { get; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable monotonicTimestamp;
		[NullAllowed, Export ("monotonicTimestamp", ArgumentSemantic.Assign)]
		NSNumber MonotonicTimestamp { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable altitude;
		[NullAllowed, Export ("altitude", ArgumentSemantic.Assign)]
		NSNumber Altitude { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable horizontalAccuracy;
		[NullAllowed, Export ("horizontalAccuracy", ArgumentSemantic.Assign)]
		NSNumber HorizontalAccuracy { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable verticalAccuracy;
		[NullAllowed, Export ("verticalAccuracy", ArgumentSemantic.Assign)]
		NSNumber VerticalAccuracy { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable speed;
		[NullAllowed, Export ("speed", ArgumentSemantic.Assign)]
		NSNumber Speed { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable speedAccuracy;
		[NullAllowed, Export ("speedAccuracy", ArgumentSemantic.Assign)]
		NSNumber SpeedAccuracy { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable bearing;
		[NullAllowed, Export ("bearing", ArgumentSemantic.Assign)]
		NSNumber Bearing { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable bearingAccuracy;
		[NullAllowed, Export ("bearingAccuracy", ArgumentSemantic.Assign)]
		NSNumber BearingAccuracy { get; set; }

		// @property (readwrite, nonatomic) NSNumber * _Nullable floor;
		[NullAllowed, Export ("floor", ArgumentSemantic.Assign)]
		NSNumber Floor { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * _Nullable source;
		[NullAllowed, Export ("source")]
		string Source { get; set; }

		// @property (readonly, copy, nonatomic) id _Nullable extra;
		[NullAllowed, Export ("extra", ArgumentSemantic.Copy)]
		NSObject Extra { get; }
	}

	// @interface MBXLocationError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXLocationError
	{
		// -(instancetype _Nonnull)initWithCode:(MBXLocationErrorCode)code message:(NSString * _Nonnull)message;
		[Export ("initWithCode:message:")]
		IntPtr Constructor (MBXLocationErrorCode code, string message);

		// @property (readonly, nonatomic) MBXLocationErrorCode code;
		[Export ("code")]
		MBXLocationErrorCode Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXLocationServiceFactory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXLocationServiceFactory
	{
		// +(void)reset;
		[Static]
		[Export ("reset")]
		void Reset ();
	}

	// @protocol MBXLocationServiceObserver
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface MBXLocationServiceObserver
	{
		// @required -(void)onAvailabilityChangedForIsAvailable:(BOOL)isAvailable;
		[Abstract]
		[Export ("onAvailabilityChangedForIsAvailable:")]
		void OnAvailabilityChangedForIsAvailable (bool isAvailable);

		// @required -(void)onPermissionStatusChangedForPermission:(MBXPermissionStatus)permission;
		[Abstract]
		[Export ("onPermissionStatusChangedForPermission:")]
		void OnPermissionStatusChangedForPermission (MBXPermissionStatus permission);

		// @required -(void)onAccuracyAuthorizationChangedForAuthorization:(MBXAccuracyAuthorization)authorization;
		[Abstract]
		[Export ("onAccuracyAuthorizationChangedForAuthorization:")]
		void OnAccuracyAuthorizationChangedForAuthorization (MBXAccuracyAuthorization authorization);
	}

	// typedef void (^MBXLocationClientStartStopCallback)(MBXLocationError * _Nullable);
	delegate void MBXLocationClientStartStopCallback ([NullAllowed] MBXLocationError arg0);

	// @interface MBXLocationExtraKeys : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLocationExtraKeys
	{
		// @property (readonly, nonatomic, class) NSString * IsMock;
		[Static]
		[Export ("IsMock")]
		string IsMock { get; }

		// @property (readonly, nonatomic, class) NSString * IsExternal;
		[Static]
		[Export ("IsExternal")]
		string IsExternal { get; }
	}

	// @interface MBXLiveTrackingClientSettings : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLiveTrackingClientSettings
	{
		// @property (readonly, nonatomic, class) NSString * AccuracyCategory;
		[Static]
		[Export ("AccuracyCategory")]
		string AccuracyCategory { get; }

		// @property (readonly, nonatomic, class) NSString * Accuracy;
		[Static]
		[Export ("Accuracy")]
		string Accuracy { get; }

		// @property (readonly, nonatomic, class) NSString * MinimumDisplacementCategory;
		[Static]
		[Export ("MinimumDisplacementCategory")]
		string MinimumDisplacementCategory { get; }

		// @property (readonly, nonatomic, class) NSString * MinimumDisplacement;
		[Static]
		[Export ("MinimumDisplacement")]
		string MinimumDisplacement { get; }

		// @property (readonly, nonatomic, class) NSString * Interval;
		[Static]
		[Export ("Interval")]
		string Interval { get; }

		// @property (readonly, nonatomic, class) NSString * MinimumInterval;
		[Static]
		[Export ("MinimumInterval")]
		string MinimumInterval { get; }

		// @property (readonly, nonatomic, class) NSString * MaximumInterval;
		[Static]
		[Export ("MaximumInterval")]
		string MaximumInterval { get; }

		// @property (readonly, nonatomic, class) NSString * WaitForAccurateLocation;
		[Static]
		[Export ("WaitForAccurateLocation")]
		string WaitForAccurateLocation { get; }

		// @property (readonly, nonatomic, class) NSString * ActivityType;
		[Static]
		[Export ("ActivityType")]
		string ActivityType { get; }
	}

	// @interface MBXLiveTrackingClientAccuracyCategory : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLiveTrackingClientAccuracyCategory
	{
		// @property (readonly, nonatomic, class) NSString * ExtraHigh;
		[Static]
		[Export ("ExtraHigh")]
		string ExtraHigh { get; }

		// @property (readonly, nonatomic, class) NSString * High;
		[Static]
		[Export ("High")]
		string High { get; }

		// @property (readonly, nonatomic, class) NSString * Medium;
		[Static]
		[Export ("Medium")]
		string Medium { get; }

		// @property (readonly, nonatomic, class) NSString * Low;
		[Static]
		[Export ("Low")]
		string Low { get; }

		// @property (readonly, nonatomic, class) NSString * Passive;
		[Static]
		[Export ("Passive")]
		string Passive { get; }
	}

	// @interface MBXLiveTrackingClientMinimumDisplacementCategory : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLiveTrackingClientMinimumDisplacementCategory
	{
		// @property (readonly, nonatomic, class) NSString * Any;
		[Static]
		[Export ("Any")]
		string Any { get; }

		// @property (readonly, nonatomic, class) NSString * Significant;
		[Static]
		[Export ("Significant")]
		string Significant { get; }
	}

	// @interface MBXLiveTrackingActivityType : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLiveTrackingActivityType
	{
		// @property (readonly, nonatomic, class) NSString * Unknown;
		[Static]
		[Export ("Unknown")]
		string Unknown { get; }

		// @property (readonly, nonatomic, class) NSString * GenericNavigation;
		[Static]
		[Export ("GenericNavigation")]
		string GenericNavigation { get; }

		// @property (readonly, nonatomic, class) NSString * AutomotiveNavigation;
		[Static]
		[Export ("AutomotiveNavigation")]
		string AutomotiveNavigation { get; }

		// @property (readonly, nonatomic, class) NSString * Fitness;
		[Static]
		[Export ("Fitness")]
		string Fitness { get; }

		// @property (readonly, nonatomic, class) NSString * Airborne;
		[Static]
		[Export ("Airborne")]
		string Airborne { get; }
	}

	// @interface MBXLiveTrackingClients : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLiveTrackingClients
	{
		// @property (readonly, nonatomic, class) NSString * Android;
		[Static]
		[Export ("Android")]
		string Android { get; }

		// @property (readonly, nonatomic, class) NSString * PlayServicesLocation;
		[Static]
		[Export ("PlayServicesLocation")]
		string PlayServicesLocation { get; }

		// @property (readonly, nonatomic, class) NSString * AppleCoreLocation;
		[Static]
		[Export ("AppleCoreLocation")]
		string AppleCoreLocation { get; }

		// @property (readonly, nonatomic, class) NSString * Gpsd;
		[Static]
		[Export ("Gpsd")]
		string Gpsd { get; }

		// @property (readonly, nonatomic, class) NSString * GeoClue;
		[Static]
		[Export ("GeoClue")]
		string GeoClue { get; }
	}

	// @interface MBXLiveTrackingClientLifecycleMode : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLiveTrackingClientLifecycleMode
	{
		// @property (readonly, nonatomic, class) NSString * None;
		[Static]
		[Export ("None")]
		string None { get; }

		// @property (readonly, nonatomic, class) NSString * Foreground;
		[Static]
		[Export ("Foreground")]
		string Foreground { get; }

		// @property (readonly, nonatomic, class) NSString * Background;
		[Static]
		[Export ("Background")]
		string Background { get; }
	}

	// @interface MBXLiveTrackingClientCapabilities : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXLiveTrackingClientCapabilities
	{
		// @property (readonly, nonatomic, class) NSString * LifecycleMode;
		[Static]
		[Export ("LifecycleMode")]
		string LifecycleMode { get; }
	}

	partial interface IMBXLogWriterBackend {}

	// @interface MBXLogConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXLogConfiguration
	{
		// +(void)registerLogWriterBackendForLogWriter:(id<MBXLogWriterBackend> _Nullable)logWriter;
		[Static]
		[Export ("registerLogWriterBackendForLogWriter:")]
		void RegisterLogWriterBackendForLogWriter ([NullAllowed] IMBXLogWriterBackend logWriter);

		// +(void)setLoggingLevelForUpTo:(NSNumber * _Nullable)upTo;
		[Static]
		[Export ("setLoggingLevelForUpTo:")]
		void SetLoggingLevelForUpTo ([NullAllowed] NSNumber upTo);

		// +(NSNumber * _Nullable)getLoggingLevel __attribute__((ns_returns_retained));
		[Static]
		[NullAllowed, Export ("getLoggingLevel")]
		NSNumber LoggingLevel { get; }

		// +(void)setLoggingLevelForCategory:(NSString * _Nonnull)category upTo:(NSNumber * _Nullable)upTo;
		[Static]
		[Export ("setLoggingLevelForCategory:upTo:")]
		void SetLoggingLevelForCategory (string category, [NullAllowed] NSNumber upTo);

		// +(NSNumber * _Nullable)getLoggingLevelForCategory:(NSString * _Nonnull)category __attribute__((ns_returns_retained));
		[Static]
		[Export ("getLoggingLevelForCategory:")]
		[return: NullAllowed]
		NSNumber GetLoggingLevelForCategory (string category);

		// +(void)resetLoggingLevelForCategory:(NSString * _Nonnull)category;
		[Static]
		[Export ("resetLoggingLevelForCategory:")]
		void ResetLoggingLevelForCategory (string category);
	}

	// @protocol MBXLogWriterBackend
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface MBXLogWriterBackend
	{
		// @required -(void)writeLogForLevel:(MBXLoggingLevel)level message:(NSString * _Nonnull)message;
		[Abstract]
		[Export ("writeLogForLevel:message:")]
		void Message (MBXLoggingLevel level, string message);
	}

	// @interface MBXOfflineSwitch : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXOfflineSwitch
	{
		// -(void)setMapboxStackConnectedForConnected:(BOOL)connected;
		[Export ("setMapboxStackConnectedForConnected:")]
		void SetMapboxStackConnectedForConnected (bool connected);

		// -(BOOL)isMapboxStackConnected;
		[Export ("isMapboxStackConnected")]
		bool IsMapboxStackConnected { get; }

		// +(MBXOfflineSwitch * _Nonnull)getInstance __attribute__((ns_returns_retained));
		[Static]
		[Export ("getInstance")]
		MBXOfflineSwitch Instance { get; }

		// +(void)reset;
		[Static]
		[Export ("reset")]
		void Reset ();
	}

	// @interface MBXSettingsServiceFactory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXSettingsServiceFactory
	{
	}

	// @interface MBXMapboxCommonSettings : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXMapboxCommonSettings
	{
		// @property (readonly, nonatomic, class) NSString * Language;
		[Static]
		[Export ("Language")]
		string Language { get; }

		// @property (readonly, nonatomic, class) NSString * Worldview;
		[Static]
		[Export ("Worldview")]
		string Worldview { get; }
	}

	// typedef void (^MBXTileRegionLoadProgressCallback)(MBXTileRegionLoadProgress * _Nonnull);
	delegate void MBXTileRegionLoadProgressCallback (MBXTileRegionLoadProgress arg0);

	// @interface MBXTileStore : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileStore
	{
		// +(MBXTileStore * _Nonnull)createForPath:(NSString * _Nonnull)path __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Static]
		[Export ("createForPath:")]
		MBXTileStore CreateForPath (string path);

		// +(MBXTileStore * _Nonnull)create __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Static]
		[Export ("create")]
		MBXTileStore Create();

		// -(MBXCancelable * _Nonnull)loadTileRegionForId:(NSString * _Nonnull)id loadOptions:(MBXTileRegionLoadOptions * _Nonnull)loadOptions __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Export ("loadTileRegionForId:loadOptions:")]
		MBXCancelable LoadTileRegionForId (string id, MBXTileRegionLoadOptions loadOptions);

		// -(void)removeTileRegionForId:(NSString * _Nonnull)id;
		[Export ("removeTileRegionForId:")]
		void RemoveTileRegionForId (string id);

		// -(void)setOptionForKey:(NSString * _Nonnull)key value:(id _Nonnull)value;
		[Export ("setOptionForKey:value:")]
		void SetOptionForKey (string key, NSObject value);

		// -(void)setOptionForKey:(NSString * _Nonnull)key domain:(MBXTileDataDomain)domain value:(id _Nonnull)value;
		[Export ("setOptionForKey:domain:value:")]
		void SetOptionForKey (string key, MBXTileDataDomain domain, NSObject value);
	}

	// @interface MBXTileRegion : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegion
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id requiredResourceCount:(uint64_t)requiredResourceCount completedResourceCount:(uint64_t)completedResourceCount completedResourceSize:(uint64_t)completedResourceSize expires:(NSDate * _Nullable)expires;
		[Export ("initWithId:requiredResourceCount:completedResourceCount:completedResourceSize:expires:")]
		IntPtr Constructor (string id, ulong requiredResourceCount, ulong completedResourceCount, ulong completedResourceSize, [NullAllowed] NSDate expires);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, nonatomic) uint64_t requiredResourceCount;
		[Export ("requiredResourceCount")]
		ulong RequiredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceCount;
		[Export ("completedResourceCount")]
		ulong CompletedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceSize;
		[Export ("completedResourceSize")]
		ulong CompletedResourceSize { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable expires;
		[NullAllowed, Export ("expires")]
		NSDate Expires { get; }
	}

	// @interface MBXTileRegionLoadProgress : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegionLoadProgress
	{
		// -(instancetype _Nonnull)initWithCompletedResourceCount:(uint64_t)completedResourceCount completedResourceSize:(uint64_t)completedResourceSize erroredResourceCount:(uint64_t)erroredResourceCount requiredResourceCount:(uint64_t)requiredResourceCount loadedResourceCount:(uint64_t)loadedResourceCount loadedResourceSize:(uint64_t)loadedResourceSize;
		[Export ("initWithCompletedResourceCount:completedResourceSize:erroredResourceCount:requiredResourceCount:loadedResourceCount:loadedResourceSize:")]
		IntPtr Constructor (ulong completedResourceCount, ulong completedResourceSize, ulong erroredResourceCount, ulong requiredResourceCount, ulong loadedResourceCount, ulong loadedResourceSize);

		// @property (readonly, nonatomic) uint64_t completedResourceCount;
		[Export ("completedResourceCount")]
		ulong CompletedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceSize;
		[Export ("completedResourceSize")]
		ulong CompletedResourceSize { get; }

		// @property (readonly, nonatomic) uint64_t erroredResourceCount;
		[Export ("erroredResourceCount")]
		ulong ErroredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t requiredResourceCount;
		[Export ("requiredResourceCount")]
		ulong RequiredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t loadedResourceCount;
		[Export ("loadedResourceCount")]
		ulong LoadedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t loadedResourceSize;
		[Export ("loadedResourceSize")]
		ulong LoadedResourceSize { get; }
	}

	// @interface MBXTileRegionError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegionError
	{
		// -(instancetype _Nonnull)initWithType:(MBXTileRegionErrorType)type message:(NSString * _Nonnull)message;
		[Export ("initWithType:message:")]
		IntPtr Constructor (MBXTileRegionErrorType type, string message);

		// @property (readonly, nonatomic) MBXTileRegionErrorType type;
		[Export ("type")]
		MBXTileRegionErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXTileRegionLoadOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegionLoadOptions
	{
		// -(instancetype _Nonnull)initWithGeometry:(MBXGeometry * _Nullable)geometry descriptors:(NSArray<MBXTilesetDescriptor *> * _Nullable)descriptors metadata:(id _Nullable)metadata startLocation:(CLLocation * _Nullable)startLocation averageBytesPerSecond:(NSNumber * _Nullable)averageBytesPerSecond extraOptions:(id _Nullable)extraOptions __attribute__((swift_private));
		[Export ("initWithGeometry:descriptors:metadata:startLocation:averageBytesPerSecond:extraOptions:")]
		IntPtr Constructor ([NullAllowed] MBXGeometry geometry, [NullAllowed] MBXTilesetDescriptor[] descriptors, [NullAllowed] NSObject metadata, [NullAllowed] CLLocation startLocation, [NullAllowed] NSNumber averageBytesPerSecond, [NullAllowed] NSObject extraOptions);

		// -(instancetype _Nonnull)initWithGeometry:(MBXGeometry * _Nullable)geometry descriptors:(NSArray<MBXTilesetDescriptor *> * _Nullable)descriptors metadata:(id _Nullable)metadata acceptExpired:(BOOL)acceptExpired networkRestriction:(MBXNetworkRestriction)networkRestriction startLocation:(CLLocation * _Nullable)startLocation averageBytesPerSecond:(NSNumber * _Nullable)averageBytesPerSecond extraOptions:(id _Nullable)extraOptions __attribute__((swift_private));
		[Export ("initWithGeometry:descriptors:metadata:acceptExpired:networkRestriction:startLocation:averageBytesPerSecond:extraOptions:")]
		IntPtr Constructor ([NullAllowed] MBXGeometry geometry, [NullAllowed] MBXTilesetDescriptor[] descriptors, [NullAllowed] NSObject metadata, bool acceptExpired, MBXNetworkRestriction networkRestriction, [NullAllowed] CLLocation startLocation, [NullAllowed] NSNumber averageBytesPerSecond, [NullAllowed] NSObject extraOptions);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBXGeometry * geometry __attribute__((swift_private));
		[Export ("geometry")]
		MBXGeometry Geometry { get; }

		// @property (readonly, copy, nonatomic) NSArray<MBXTilesetDescriptor *> * _Nullable descriptors;
		[NullAllowed, Export ("descriptors", ArgumentSemantic.Copy)]
		MBXTilesetDescriptor[] Descriptors { get; }

		// @property (readonly, copy, nonatomic) id _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Copy)]
		NSObject Metadata { get; }

		// @property (readonly, getter = isAcceptExpired, nonatomic) BOOL acceptExpired;
		[Export ("acceptExpired")]
		bool AcceptExpired { [Bind ("isAcceptExpired")] get; }

		// @property (readonly, nonatomic) MBXNetworkRestriction networkRestriction;
		[Export ("networkRestriction")]
		MBXNetworkRestriction NetworkRestriction { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT CLLocation * startLocation __attribute__((swift_private));
		[Export ("startLocation")]
		CLLocation StartLocation { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * averageBytesPerSecond __attribute__((swift_private));
		[Export ("averageBytesPerSecond")]
		NSNumber AverageBytesPerSecond { get; }

		// @property (readonly, copy, nonatomic) id _Nullable extraOptions;
		[NullAllowed, Export ("extraOptions", ArgumentSemantic.Copy)]
		NSObject ExtraOptions { get; }
	}

	// @interface MBXTileStoreOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXTileStoreOptions
	{
		// @property (readonly, nonatomic, class) NSString * DiskQuota;
		[Static]
		[Export ("DiskQuota")]
		string DiskQuota { get; }

		// @property (readonly, nonatomic, class) NSString * MapboxAccessToken;
		[Static]
		[Export ("MapboxAccessToken")]
		string MapboxAccessToken { get; }

		// @property (readonly, nonatomic, class) NSString * MapboxAPIURL;
		[Static]
		[Export ("MapboxAPIURL")]
		string MapboxAPIURL { get; }

		// @property (readonly, nonatomic, class) NSString * TileURLTemplate;
		[Static]
		[Export ("TileURLTemplate")]
		string TileURLTemplate { get; }
	}

	// @interface MBXUploadOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXUploadOptions
	{
		// -(instancetype _Nonnull)initWithFilePath:(NSString * _Nonnull)filePath url:(NSString * _Nonnull)url headers:(NSDictionary<NSString *,NSString *> * _Nonnull)headers metadata:(NSString * _Nonnull)metadata mediaType:(NSString * _Nonnull)mediaType;
		[Export ("initWithFilePath:url:headers:metadata:mediaType:")]
		IntPtr Constructor (string filePath, string url, NSDictionary headers, string metadata, string mediaType);

		// -(instancetype _Nonnull)initWithFilePath:(NSString * _Nonnull)filePath url:(NSString * _Nonnull)url headers:(NSDictionary<NSString *,NSString *> * _Nonnull)headers metadata:(NSString * _Nonnull)metadata mediaType:(NSString * _Nonnull)mediaType networkRestriction:(MBXNetworkRestriction)networkRestriction timeout:(uint64_t)timeout;
		[Export ("initWithFilePath:url:headers:metadata:mediaType:networkRestriction:timeout:")]
		IntPtr Constructor (string filePath, string url, NSDictionary headers, string metadata, string mediaType, MBXNetworkRestriction networkRestriction, ulong timeout);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull filePath;
		[Export ("filePath")]
		string FilePath { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export ("url")]
		string Url { get; }

		// @property (readwrite, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary Headers { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull metadata;
		[Export ("metadata")]
		string Metadata { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull mediaType;
		[Export ("mediaType")]
		string MediaType { get; }

		// @property (readonly, nonatomic) MBXNetworkRestriction networkRestriction;
		[Export ("networkRestriction")]
		MBXNetworkRestriction NetworkRestriction { get; }

		// @property (readonly, nonatomic) uint64_t timeout;
		[Export ("timeout")]
		ulong Timeout { get; }
	}

	// @interface MBXUploadError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXUploadError
	{
		// -(instancetype _Nonnull)initWithCode:(MBXUploadErrorCode)code message:(NSString * _Nonnull)message;
		[Export ("initWithCode:message:")]
		IntPtr Constructor (MBXUploadErrorCode code, string message);

		// @property (readonly, nonatomic) MBXUploadErrorCode code;
		[Export ("code")]
		MBXUploadErrorCode Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXUploadStatus : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXUploadStatus
	{
		// @property (readwrite, nonatomic) uint64_t uploadId;
		[Export ("uploadId")]
		ulong UploadId { get; set; }

		// @property (readwrite, nonatomic) MBXUploadState state;
		[Export ("state", ArgumentSemantic.Assign)]
		MBXUploadState State { get; set; }

		// @property (readwrite, nonatomic) MBXUploadError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Assign)]
		MBXUploadError Error { get; set; }

		// @property (readwrite, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * totalBytes __attribute__((swift_private));
		[Export ("totalBytes", ArgumentSemantic.Assign)]
		NSNumber TotalBytes { get; set; }

		// @property (readwrite, nonatomic) uint64_t sentBytes;
		[Export ("sentBytes")]
		ulong SentBytes { get; set; }

		// @property (readwrite, nonatomic) uint64_t totalSentBytes;
		[Export ("totalSentBytes")]
		ulong TotalSentBytes { get; set; }
	}

	// @interface MBXUploadServiceFactory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXUploadServiceFactory
	{
		// +(void)setUserDefinedForCustom:(id<MBXUploadServiceInterface> _Nonnull)custom;
		[Static]
		[Export ("setUserDefinedForCustom:")]
		void SetUserDefinedForCustom (IMBXUploadServiceInterface custom);
	}

	// typedef void (^MBXUploadStatusCallback)(MBXUploadStatus * _Nonnull);
	delegate void MBXUploadStatusCallback (MBXUploadStatus arg0);

	partial interface IMBXUploadServiceInterface {}

	// @protocol MBXUploadServiceInterface
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface MBXUploadServiceInterface
	{
		// @required -(uint64_t)uploadForOptions:(MBXUploadOptions * _Nonnull)options callback:(MBXUploadStatusCallback _Nonnull)callback;
		[Abstract]
		[Export ("uploadForOptions:callback:")]
		ulong UploadForOptions (MBXUploadOptions options, MBXUploadStatusCallback callback);

		// @required -(void)cancelUploadForId:(uint64_t)id callback:(MBXResultCallback _Nonnull)callback;
		[Abstract]
		[Export ("cancelUploadForId:callback:")]
		void CancelUploadForId (ulong id, MBXResultCallback callback);
	}

	// @interface MBXValueConverter : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXValueConverter
	{
		// +(NSString * _Nonnull)toJsonForValue:(id _Nonnull)value __attribute__((ns_returns_retained));
		[Static]
		[Export ("toJsonForValue:")]
		string ToJsonForValue (NSObject value);

		// +(NSString * _Nonnull)toJsonForValue:(id _Nonnull)value indent:(uint32_t)indent __attribute__((ns_returns_retained));
		[Static]
		[Export ("toJsonForValue:indent:")]
		string ToJsonForValue (NSObject value, uint indent);
	}
}
