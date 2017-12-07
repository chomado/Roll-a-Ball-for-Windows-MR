using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public bool IsClicked()
    {
        //return Input.anyKeyDown;
        return true; // なぜかキー操作を感知してくれないので取りあえずtrueにする
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
