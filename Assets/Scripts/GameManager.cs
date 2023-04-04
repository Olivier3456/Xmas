using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    GameObject snowBall;
   
    void Start()
    {
        snowBall = GameObject.Find("SnowBall");
    }

   

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.E))
        {
            snowBall.transform.SetParent(null);
            snowBall.GetComponent<Rigidbody>().useGravity = true;        
            snowBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 15), ForceMode.Impulse);            
        }
    }
}
