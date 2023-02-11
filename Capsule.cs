using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollissionEnter(Collision myobject)
    {
        if(myobject.gameObject.name == "red"){
            print("bad");
            Destroy(gameObject);
        };
    }
}
