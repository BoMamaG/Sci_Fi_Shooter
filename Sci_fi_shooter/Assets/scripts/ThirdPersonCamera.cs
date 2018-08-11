using System.Collections;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    [SerializeField] Vector3 cameraOffset;
    [SerializeField] float damping;

    Transform cameraLookTarget;
    Player localPlayer;

	void Awake () {
        GameManager.Instance.OnLocalPlayerJoined += HandleOnLocalPlayerJoined;;
		
	}
	
    void HandleOnLocalPlayerJoined (Player player)
    {
        localPlayer = player;
        cameraLookTarget = localPlayer.transform.Find("cameraLookTarget");

        if(cameraLookTarget == null)
            cameraLookTarget = localPlayer.transform;
    }


	void Update () {
        Vector3 targetPosition = cameraLookTarget.position + localPlayer.transform.forward * cameraOffset.z +
            localPlayer.transform.up * cameraOffset.y +
            localPlayer.transform.right * cameraOffset.x;
	}
}
