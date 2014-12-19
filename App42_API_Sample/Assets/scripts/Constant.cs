using System;
using UnityEngine;
using com.shephertz.app42.paas.sdk.csharp;

namespace AssemblyCSharp
{
		public class Constant
		{
				public string apiKey = "d794ed6fd8fa49da69e8cb6f3e19ac4a63a22f92d19f1aa7e658ba1d09b645be";// API key that you have receieved after the success of app creation from AppHQ
				public string secretKey = "3421b54ec141f0a7605662577a6aea355ba3b97f4d7143697888fa606f7a852b";// SECRET key that you have receieved after the success of app creation from AppHQ
				public string gameName = "UnityTestGame";						// Name of the game which you can create from AppHQ console by clicking 
				
				public string description = "Description";			// Enter your description
				public string userName = "NameOfTheUser"; 				// Name of the user for which you have to save score or create user etc.
				public string sessionId = "SessionIdOfTheActiveUser";   		// Session id of the user for which you have to have invalidate his session 
				public string emailId = "mailId@mail.com";    			// EmailId for the user creation
				public string updateEmailId = "UpdatedEmail@mail.com";  // EmailId which has to be updated in user profile.
		
				public string dbName = "Knock";   					// Name of the database for which you have to add json document
				public string docId = "ObjectIdOfTheUser";	 			// Object id of the json doc for which you have to fetch json doc,
				
				public string scoreId = "<Scoreid of the User>";				// Score id of the user for which you have to edit score , fetch user score etc..
				public string json = "{\"AppName\":\"devApp\",\"AppId\":\"123hg4bdb\"}"; 			// Json string which you want to save in insert json document
				public string key = "AppName"; 							// Key of json doc for fetch the doc details,update doc etc..
				public string val = "devApp"; 						// Value of json doc for fetch the doc details , updated doc etc..
				public string newJson = "{'AppName':'RealeaseApp'}"; 			// json string which you want to update from existing doc.
		
				public string testName = "TestABTest";
				public string variantName = "TestABTestVariant";
				public string fileName = "TestFileName";
				public string filePath = "D:\\1.png";
				
		} 

}
