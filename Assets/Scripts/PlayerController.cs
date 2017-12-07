using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public Text CountText;

    private Rigidbody rb;
    private int count = 0;

    private void Start()
    {
        SetCountText();
        this.rb = GetComponent<Rigidbody>();
    }
    // called before performing any physics calculations (rigitbody toka)
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis(axisName: "Horizontal");
        float moveVertical = Input.GetAxis(axisName: "Vertical");

        var movement = new Vector3(x: moveHorizontal, y: 0.0f, z: moveVertical);

        this.rb.AddForce(force: movement * this.Speed);
    }

    // called by Unity when our player game object first touches a trigger collider 
    private void OnTriggerEnter(Collider other /* タッチしたコライダー(衝突型加速器) */)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            this.count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        this.CountText.text = "Count: " + this.count.ToString();
    }
}
