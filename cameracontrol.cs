using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cameracontrol : MonoBehaviour
{
    Rigidbody rb;
    public GameObject bullet;
    public Text mytext;
    public Transform lol;
    GameObject cloneBullet;
    Rigidbody rbClone;
    int i=50;
    float x,y,z;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void Update(){

        //Движение вперед/назад
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveVertical * 20f);

        //Поворот
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0f,moveHorizontal*2f,0f);

        
        if(Input.GetKeyDown("space")){
            cloneBullet = Instantiate(bullet, new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity);
            rbClone = cloneBullet.GetComponent<Rigidbody>();
            rbClone.AddForce(transform.forward * 1000f);
        }

        if(i==0){
            SceneManager.LoadScene(1);
        }
        if(lol.transform.position.y==40){
            SceneManager.LoadScene(2);
        }
    }
    void OnCollisionEnter(Collision a){
        if(a.gameObject.tag=="Enemy"){
            i-=10;
            mytext.text = i + " HP";
        }
    }
}