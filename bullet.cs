using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour{
	public Text ptext;
	public Transform l;
	float k,x,z;
	void Start(){
		k = l.transform.position.y;
		x = l.transform.position.x;
        z = l.transform.position.z;
	}
	public void Update(){

	}
	void OnCollisionEnter(Collision xw){
        if(xw.gameObject.tag=="Enemy"){
            Destroy(xw.gameObject);
            Destroy(gameObject);
            k+=10f;
           	ptext.text = "Point: "+ k;
            l.transform.position = new Vector3(x,k,z);
        }
    }
}