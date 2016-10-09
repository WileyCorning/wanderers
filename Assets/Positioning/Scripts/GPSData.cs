using UnityEngine;
using System.Collections;

public struct GPSData {
	public float accuracy;
	public float latitude;
	public float longitude;
	public float altitude;
	public long timestamp;

	public GPSData(float _accuracy, double _latitude, double _longitude, double _altitude, long _timestamp) {
		accuracy = _accuracy;
		latitude = System.Convert.ToSingle (_latitude);
		longitude = System.Convert.ToSingle (_longitude);
		altitude = System.Convert.ToSingle (_altitude);
		timestamp = _timestamp;
	}
}
