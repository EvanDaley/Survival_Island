using UnityEngine;
using System.Collections;

public static class TimeOfDay {
	
	public static int GetMinute()
	{
		return System.DateTime.Now.Minute;
	}

	public static int GetSecond()
	{
		return System.DateTime.Now.Second;
	}
}
