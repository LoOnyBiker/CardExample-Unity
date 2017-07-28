using UnityEngine;

static public class DirectoryUtility
{
	static public string ExternalAssets()
	{
		switch ( Application.platform )
		{
		default:
		case RuntimePlatform.OSXEditor:
		case RuntimePlatform.WindowsEditor:
			return Application.dataPath + "/../ExternalAssets/";
		case RuntimePlatform.OSXPlayer:
		case RuntimePlatform.WindowsPlayer:
		case RuntimePlatform.IPhonePlayer:
		case RuntimePlatform.LinuxPlayer:
			return Application.dataPath + "/ExternalAssets/";
		}
	}
}
