using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class LocationListenerCallback : AndroidJavaProxy
{
	// This is a global reference to the ENGINE which provides access to EVERYTHING in this project.
//	protected AppEngine Engine;

	GPSLocator holder;
	public LocationListenerCallback(GPSLocator _holder) : base ("com.google.android.gms.location.LocationListener")
	{
//		Engine = GameObject.FindObjectOfType<AppEngine>();
		holder = _holder;
	}

	void onLocationChanged(AndroidJavaObject locationObject)
	{
		try
		{
			float accuracy = locationObject.Call<float>("getAccuracy");
			double altitude = locationObject.Call<double>("getAltitude");
			double latitude = locationObject.Call<double>("getLatitude");
			double longitude = locationObject.Call<double>("getLongitude");
			long time = locationObject.Call<long>("getTime");

			holder.SetData(accuracy,latitude,longitude,altitude,time);
		}
		catch (Exception error)
		{
//			Engine.TryShowExceptionOnScreen(error);
			throw;
		}

	}
}
