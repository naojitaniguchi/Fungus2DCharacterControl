using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SendMessageTestToFlowChart : MonoBehaviour {
    // public Flowchart f;
    public GameObject flowchartObj;

	// Use this for initialization
	void Start () {
        //f.SendMessage("Start");
        // flowchartObj.SetActive(true);



    }
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKeyDown(KeyCode.A)){
            flowchartObj.SetActive(true);
        }
	}
}
