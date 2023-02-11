using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spherecontr : MonoBehaviour
{
    // Start is called before the first frame update
    int num = 0;
    static int points = 0;
    [SerializeField] TextMeshProUGUI PointsText;
    [SerializeField] TextMeshProUGUI Win;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(points > 700){
           Win.text = "WON";
        };
    }

    void OnCollisionEnter(Collision arg)
    {
        if(arg.gameObject.name == "Plane"){
            num = num + 1;
            print(num);

            if(num>2){
                print("end");
                Destroy(gameObject);
                
            }
        };
    }
    void OnMouseDown()
    {
        points = points + 100;
        PointsText.text = points + "";
        print(points);
        Destroy(gameObject);
    }

}
