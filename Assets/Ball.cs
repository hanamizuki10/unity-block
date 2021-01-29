using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private float speed = 20.0f;    //これを追加

    // Use this for initialization
    void Start () {
        //以下を追加
        this.GetComponent<Rigidbody>().AddForce(
            (transform.forward + transform.right) * speed,
            ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update () {

    }
}