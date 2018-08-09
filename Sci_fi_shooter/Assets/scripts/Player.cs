using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    [System.Serializable]
    public class MouseInput
    {
        public Vector2 Damping;
        public Vector2 Sensitivity;
    }
    [SerializeField] float speed;
    [SerializeField] MouseInput MouseControl;

    InputController playerInput;

	void Awake () {
        playerInput = GameManager.Instance.InputController;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = new Vector2(playerInput.Vertical * speed, playerInput.Horizontal * speed);
		
	}
}
