using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookWalk : MonoBehaviour
{
    public float Velocity = 0.7f; // 速度
    public bool IsWalking = false;

    private CharacterController controller;
    private Clicker clicker;

	// Use this for initialization
	void Start () {
        this.controller = GetComponent<CharacterController>();
        this.clicker = new Clicker();
	}

    // Update is called once per frame
    void Update() {
        if (this.clicker.IsClicked())
        {
            this.IsWalking = !this.IsWalking;
        }
        if (IsWalking)
        {
            Vector3 moveDirection = Camera.main.transform.forward;
            moveDirection *= this.Velocity * Time.deltaTime;
            moveDirection.y = 0.0f;
            this.controller.Move(motion: moveDirection);
        }
	}
}
