using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public Transform board, building, building1Options;

	public void Building (bool clicked){	
		if (clicked == true) {
			building.gameObject.SetActive (clicked);
		} 

		else {
			building.gameObject.SetActive (clicked);
		}
	}

	public void Building1Options (bool clicked) {
		if (clicked == true) {
			building.gameObject.SetActive (false);
			building1Options.gameObject.SetActive (clicked);
		}
	}

}
