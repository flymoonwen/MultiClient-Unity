using UnityEngine;
using System.Collections;

public class net : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {


        
        Debug.Log(" timeSinceLevelLost " + Time.timeSinceLevelLoad.ToString());
        Debug.Log(" time " + Time.time.ToString());


	}
}
