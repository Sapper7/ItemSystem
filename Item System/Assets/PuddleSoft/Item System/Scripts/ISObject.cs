using UnityEngine;
using System.Collections;

public class ISObject : IISObject {
	[SerializeField]Sprite _icon;
	[SerializeField]string _name;
	[SerializeField]int _value;
	[SerializeField]int _burden;
	[SerializeField]ISQuality quality;

	#region IISObject implementation

	public string ISName {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}

	public int ISValue {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}

	public Sprite ISIcon {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}

	public int ISBurden {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}

	public ISQuality ISquality {
		get {
			throw new System.NotImplementedException ();
		}
		set {
			throw new System.NotImplementedException ();
		}
	}

	#endregion


}
