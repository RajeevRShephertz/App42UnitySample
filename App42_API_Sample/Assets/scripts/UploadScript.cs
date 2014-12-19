using UnityEngine;
using System.Collections;
using com.shephertz.app42.paas.sdk.csharp;
using System.Net;
using com.shephertz.app42.paas.sdk.csharp.upload;
using System;
using System.Collections.Generic;
using System.IO;
using AssemblyCSharp;

public class UploadScript : MonoBehaviour
{
	ServiceAPI sp = null;
	UploadService uploadService = null; // Initializing Upload Service.
	Constant cons = new Constant ();
	Uploadresponse callBack = new Uploadresponse ();
	public string success, box;
		#if UNITY_EDITOR
		public static bool Validator (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
		{return true;}
		#endif

	void Start ()
	{
		#if UNITY_EDITOR
		ServicePointManager.ServerCertificateValidationCallback = Validator;
		#endif
		sp = new ServiceAPI (cons.apiKey, cons.secretKey);
	}
	
	void Update ()
	{
		
	}
	
	void OnGUI ()
	{
		
		if (Time.time % 2 < 1) {
			success = callBack.getResult ();
		}
		// For Setting Up ResponseBox.
		GUI.TextArea (new Rect (10, 5, 1000, 175), success);
		
		//===================================**************=========================================
		if (GUI.Button (new Rect (50, 200, 200, 30), "UploadFile")) {
			uploadService = sp.BuildUploadService (); // Initializing UploadService.
			uploadService.UploadFile (cons.fileName, cons.filePath, UploadFileType.IMAGE, cons.description, callBack);
		}
		
		//===================================**************=========================================
		if (GUI.Button (new Rect (260, 200, 200, 30), "GetFileByName")) {
			uploadService = sp.BuildUploadService (); // Initializing UploadService.
			uploadService.GetFileByName (cons.fileName, callBack);
		}
		
		//===================================**************=========================================
		if (GUI.Button (new Rect (470, 200, 200, 30), "UploadFileForUser")) {
			uploadService = sp.BuildUploadService (); // Initializing UploadService.
			uploadService.UploadFileForUser (cons.fileName, cons.userName, cons.filePath, UploadFileType.IMAGE, cons.description, callBack);
			
		}
		
		//===================================**************=========================================
		if (GUI.Button (new Rect (680, 200, 200, 30), "UploadFileStream")) {
			uploadService = sp.BuildUploadService (); // Initializing UploadService.
			Stream stream = new FileStream(cons.filePath, FileMode.Open);
			uploadService.UploadFile (cons.fileName, stream, UploadFileType.IMAGE, cons.description, callBack);
			
		}
		
	}
	

}
