using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class GPSLocator
{
	private GPSData lastData;

	public bool isChanged = false;

	public void SetData(float accuracy, double latitude, double longitude, double altitude, long time) {
		isChanged = true;
		lastData = new GPSData (accuracy, latitude, longitude, altitude, time);
	}

	public GPSData GetData() {
		isChanged = false;
		return lastData;
	}
}
