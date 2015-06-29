using System;

using UIKit;
using Foundation;
using AVFoundation;
using ObjCRuntime;

namespace AVCam
{
	public class PreviewView : UIView
	{
		public static Class LayerClass
		{
			[Export("layerClass")]
			get {
				return new Class (typeof(AVCaptureVideoPreviewLayer));
			}
		}

		public AVCaptureSession session {
			get {
				var previewLayer = (AVCaptureVideoPreviewLayer)Layer;
				return previewLayer.Session;
			}
			set {
				var previewLayer = (AVCaptureVideoPreviewLayer)Layer;
				previewLayer.Session = session;
			}
		}
	}
}