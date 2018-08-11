using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLevel : MonoBehaviour {
    public string newGameScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            print("fdfds");
            SceneManager.LoadScene(newGameScene);
        }
    }

}
