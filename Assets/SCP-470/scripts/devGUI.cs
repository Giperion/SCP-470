using UnityEngine;
using System.Collections;

public class devGUI : MonoBehaviour {
	private Player player;
	private RayCasting raycast;
	void Start () {
		print ("WARNING! Development GUI loaded! Make sure it's not a production or public build!");
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent <Player>();
	
	}
	
	void OnGUI () {
	GUI.Label (new Rect (Screen.width - 160, Screen.height - 60, 180, 50), "[EUPHORIA] Alpha project");
	GUI.Label (new Rect (Screen.width - 160, Screen.height - 40, 120, 30), "version: " + SCP470.GetGameVersion ());
	GUI.Label (new Rect (Screen.width - 160, Screen.height - 25, 120, 30), "Health: " + player.health.ToString());

}
}