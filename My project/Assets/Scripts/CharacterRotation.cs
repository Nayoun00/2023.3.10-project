using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    float rotspeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 10000;
        }

        transform.Rotate(0, this.rotspeed * Time.deltaTime, 0);         //
                                                                        //
        rotspeed *= 0.99f;                                              //
    }


}
