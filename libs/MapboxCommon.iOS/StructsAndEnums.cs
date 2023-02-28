using System.Runtime.InteropServices;
using Foundation;
using MapboxCommon;
using ObjCRuntime;

namespace MapboxCommon
{
	public enum MBXGeometryType : uint
	{
		Empty,
		Point,
		Line,
		Polygon,
		MultiPoint,
		MultiLine,
		MultiPolygon,
		GeometryCollection
	}

	[Native]
	public enum MBXHttpMethod : long
	{
		Get,
		Head,
		Post
	}

	// static class CFunctions
	// {
	// 	// extern NSString * MBXHttpMethodToString (MBXHttpMethod http_method);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXHttpMethodToString (MBXHttpMethod http_method);

	// 	// extern NSString * MBXHttpRequestErrorTypeToString (MBXHttpRequestErrorType http_request_error_type);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXHttpRequestErrorTypeToString (MBXHttpRequestErrorType http_request_error_type);

	// 	// extern NSString * MBXDownloadErrorCodeToString (MBXDownloadErrorCode download_error_code);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXDownloadErrorCodeToString (MBXDownloadErrorCode download_error_code);

	// 	// extern NSString * MBXLocationErrorCodeToString (MBXLocationErrorCode location_error_code);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXLocationErrorCodeToString (MBXLocationErrorCode location_error_code);

	// 	// extern NSString * MBXAccuracyAuthorizationToString (MBXAccuracyAuthorization accuracy_authorization);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXAccuracyAuthorizationToString (MBXAccuracyAuthorization accuracy_authorization);

	// 	// extern NSString * MBXPermissionStatusToString (MBXPermissionStatus permission_status);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXPermissionStatusToString (MBXPermissionStatus permission_status);

	// 	// extern NSString * MBXLiveTrackingStateToString (MBXLiveTrackingState live_tracking_state);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXLiveTrackingStateToString (MBXLiveTrackingState live_tracking_state);

	// 	// extern NSString * MBXLoggingLevelToString (MBXLoggingLevel logging_level);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXLoggingLevelToString (MBXLoggingLevel logging_level);

	// 	// extern NSString * MBXTileDataDomainToString (MBXTileDataDomain tile_data_domain);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXTileDataDomainToString (MBXTileDataDomain tile_data_domain);

	// 	// extern NSString * MBXTileRegionErrorTypeToString (MBXTileRegionErrorType tile_region_error_type);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXTileRegionErrorTypeToString (MBXTileRegionErrorType tile_region_error_type);

	// 	// extern NSString * MBXUploadErrorCodeToString (MBXUploadErrorCode upload_error_code);
	// 	[DllImport ("__Internal")]
	// 	[Verify (PlatformInvoke)]
	// 	static extern NSString MBXUploadErrorCodeToString (MBXUploadErrorCode upload_error_code);
	// }

	[Native]
	public enum MBXNetworkRestriction : long
	{
		None = 0,
		DisallowExpensive = 1,
		DisallowAll = 255
	}

	[Native]
	public enum MBXHttpRequestErrorType : long
	{
		ConnectionError,
		SSLError,
		RequestCancelled,
		RequestTimedOut,
		RangeError,
		OtherError
	}

	[Native]
	public enum MBXDownloadErrorCode : long
	{
		FileSystemError,
		NetworkError
	}

	[Native]
	public enum MBXDownloadState : long
	{
		Pending,
		Downloading,
		Failed,
		Finished
	}

	[Native]
	public enum MBXLocationErrorCode : long
	{
		None,
		NotReady,
		NotAvailable,
		AccessDenied,
		InvalidArgument,
		FailedToDetectLocation,
		CommunicationFailure,
		Cancelled,
		NotSupported,
		Unknown
	}

	[Native]
	public enum MBXAccuracyAuthorization : long
	{
		None,
		Exact,
		Inexact
	}

	[Native]
	public enum MBXPermissionStatus : long
	{
		Denied,
		Granted,
		Foreground,
		Background
	}

	[Native]
	public enum MBXLiveTrackingState : long
	{
		opped,
		arting,
		arted,
		opping
	}

	[Native]
	public enum MBXLoggingLevel : long
	{
		Debug,
		Info,
		Warning,
		Error
	}

	[Native]
	public enum MBXSettingsServiceStorageType : long
	{
		Persistent,
		NonPersistent
	}

	[Native]
	public enum MBXTileDataDomain : long
	{
		Maps,
		Navigation,
		Search,
		Adas
	}

	[Native]
	public enum MBXTileRegionErrorType : long
	{
		Canceled,
		DoesNotExist,
		TilesetDescriptor,
		DiskFull,
		Other,
		TileCountExceeded
	}

	[Native]
	public enum MBXUploadState : long
	{
		Pending,
		Uploading,
		Failed,
		Finished
	}

	[Native]
	public enum MBXUploadErrorCode : long
	{
		FileSystemError,
		NetworkError
	}
}
