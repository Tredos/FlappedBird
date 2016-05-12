using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Game : MonoBehaviour {
    public GameObject player;
    public GameObject points;
	// Use this for initialization
	void Start () {
	        
	}
	
	// Update is called once per frame
	void Update () {
        points.GetComponent<Text>().text = player.transform.position.z.ToString();
	}
}
