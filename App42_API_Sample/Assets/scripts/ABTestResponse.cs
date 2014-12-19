using UnityEngine;
using System.Collections;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.abTest;
using System;
namespace AssemblyCSharp
{
public class ABTestResponse : App42CallBack
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