using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        this.offset = this.transform.position - this.Player.transform.position;
	}
	
	void LastUpdate () {
        this.transform.position = this.Player.transform.position + this.offset;
	}
}
