using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.abTest;
using System.Net;

public class ABTestScript : MonoBehaviour
{
	Constant cons = new Constant ();
	ServiceAPI sp = null;
	ABTestService abTestService = null; // Initializing User Service.
	public string success, box;
	UserResponse callBack = new UserResponse ();
	
	#if UNITY_EDITOR
	public static bool Validator (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}
	#endif
	void Start ()
	{
		#if UNITY_EDITOR
		ServicePointManager.ServerCertificateValidationCallback = Validator;
		#endif
		sp = new ServiceAPI (cons.apiKey, cons.secretKey);
	}
	
	void OnGUI ()
	{
		
		if (Time.time % 2 < 1) {
			success = callBack.getResult ();
		}
		
		// For Setting Up ResponseBox.
		GUI.TextArea (new Rect (10, 5, 1300, 175), success);
		
		//=========================================================================	
		if (GUI.Button (new Rect (50, 200, 200, 30), "GoalAchieved")) {
			abTestService = sp.BuildABTestService (); // Initializing ABTestService.
			abTestService.GoalAchieved (cons.testName, cons.variantName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (260, 200, 200, 30), "Execute")) {
			abTestService = sp.BuildABTestService (); // Initializing ABTestService.
			abTestService.Execute (cons.testName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (470, 200, 200, 30), "ExecuteDataDriven")) {
			abTestService = sp.BuildABTestService (); // Initializing ABTestService.
			abTestService.ExecuteDataDriven (cons.testName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (680, 200, 200, 30), "IsActive")) {
			abTestService = sp.BuildABTestService (); // Initializing ABTestService.
			abTestService.IsActive (cons.testName, callBack);
		}
		
		//=========================================================================	
		if (GUI.Button (new Rect (890, 200, 200, 30), "GetVariantData")) {
			abTestService = sp.BuildABTestService (); // Initializing ABTestService.
			abTestService.GetVariantData (cons.testName,cons.variantName, callBack);
		}
	}
}