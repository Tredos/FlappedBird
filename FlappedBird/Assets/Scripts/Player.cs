using UnityEngine;using System.Collections;

public class Player : MonoBehaviour {
    public float speed;
    public float min, max;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion crtRot = GetComponent<Cardboard>().HeadRotation;
        Vector3 lookDir = crtRot.eulerAngles;
        lookDir = new Vector3(lookDir.x, 0, lookDir.z);
        crtRot = Quaternion.Euler(lookDir.x, lookDir.y, lookDir.z); 
        GetComponent<Rigidbody>().velocity =   crtRot *  new Vector3(0, 0, 1) * speed;

        transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y, min, max), transform.position.z); 
    }
    void OnTriggerEnter(Collider col)
    {
        transform.position = Vector3.zero;
    }
}
