﻿using UnityEngine;
using System.Collections;

public class ISQuality : IISQuality {
	[SerializeField]string _name;
	[SerializeField]Sprite _icon;

	ISQuality()
	{
		_name = "Common";
		_icon = new Sprite ();
	}

	#region IISQuality implementation
	public string Name 
	{
		get {return _name;}
		set {_name = value;}
	}
	public Sprite Icon
	{
		get {return _icon;}
		set {_icon = value;}
	}
	#endregion

}
