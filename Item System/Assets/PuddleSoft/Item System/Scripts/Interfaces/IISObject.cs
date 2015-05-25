using UnityEngine;
using System.Collections;

public interface IISObject {
	//name
	//value - gold
	//icon
	//burden
	//quality level
	string ISName { get; set;}
	int ISValue { get; set;}
	Sprite ISIcon { get; set;}
	int ISBurden { get; set;}
	ISQuality ISquality { get; set;}

	//equipable
	//questItem flag
	//durabilit
	//takedamag
	//prefab
}
