using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

    private float accel = 1000.0f;//加える力の大きさ
    private Vector3 inputVector;
    private Rigidbody rig;

    // Use this for initialization
    void Start () {
        rig = this.GetComponent<Rigidbody>();
        inputVector = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update () {
        //入力を拾う
        inputVector = transform.right * Input.GetAxisRaw("Horizontal") * accel;
    }
    void FixedUpdate() {
        //力を加える
        rig.AddForce(inputVector, ForceMode.Impulse);
    }

}