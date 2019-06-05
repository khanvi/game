using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playeer : MonoBehaviour
{
   float Score = 100;
   Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
      float moveVertical = Input.GetAxis("Vertical");
      rb.AddForce(transform.forward * moveVertical * 15f);
      
      float moveHorizontal =  Input.GetAxis("Horizontal");
      transform.Rotate(0f, moveHorizontal * 5f, 0f);
    }
    void OnCollisionEnter(Collision dad)
    {
     if(dad.gameObject.tag == "enemy"){
     		SceneManager.LoadScene(1);
     		//Destroy(gameObject);
     	}
    }
    //public void SceneSwitcher(){
	//вызывается когда плеер нажал на кнопку (предварительно настраиваем компонент Button(Script))
	//}

}
