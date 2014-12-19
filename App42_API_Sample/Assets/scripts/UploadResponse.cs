using UnityEngine;
using System.Collections;
using System;
using com.shephertz.app42.paas.sdk.csharp;

namespace AssemblyCSharp
{
public class Uploadresponse : App42CallBack
{
	private string result = "";
	public void OnSuccess(object obj)
	{
		result = obj.ToString();
	}
	
	
	public void OnException(Exception e)
	{
		result = e.ToString();
		Debug.Log ("Exception is : " + e);
	}
	
	public string getResult() {
		return result;
	}
	
}
}