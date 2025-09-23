using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotController : MonoBehaviour
{
    public spin[] lines;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lines[0].StartSpin();
            

            lines[1].StartSpin();
            lines[2].StartSpin();
        }
    }
}
