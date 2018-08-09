using System.Collections;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {


    Player localPlayer;

	void Awake () {
        GameManager.Instance.OnLocalPlayerJoined += HandleOnLocalPlayerJoined;;
		
	}
	
    void HandleOnLocalPlayerJoined (Player player)
    {
        localPlayer = player;
    }


	// Update is called once per frame
	void Update () {
		
	}
}
