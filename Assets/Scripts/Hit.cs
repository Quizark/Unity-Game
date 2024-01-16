using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision theObject)
    {
        if (theObject.gameObject.name == "coconut")
        {
            GetComponent<Animator>().SetTrigger("hit");
        }
        
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
