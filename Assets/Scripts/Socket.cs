using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    clickndrag Target;
    public clickndrag BatteryOccupyingSocket;
    void OnTriggerEnter2D(Collider2D Col)
    {
        var clickcomponent = Col.GetComponent<clickndrag>();
        Debug.Log("Found something!");
        if(clickcomponent != null)
        {
            Debug.Log("Target Acquired!");
            Target = clickcomponent;
        }
    }
    void OnTriggerExit2D(Collider2D Col)
    {
        var clickcomponent = Col.GetComponent<clickndrag>();
        if(clickcomponent == Target)
        {
            Target = null;

        }
        if (clickcomponent == BatteryOccupyingSocket)
        {
            BatteryOccupyingSocket = null;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Target != null && !Target.IsBeingDragged)
        {
            Target.transform.position = transform.position;
            Target.transform.localRotation = Quaternion.identity;
            BatteryOccupyingSocket = Target;
            /*if(BatteryOccupyingSocket != null)
            {
                var thingtomove = BatteryOccupyingSocket;
              
                BatteryOccupyingSocket = Target;
                Target = null;
                thingtomove.transform.position += Vector3.up * 3;
            }
            else
            {
                BatteryOccupyingSocket = Target;
                Target = null;
            }*/
           /* BatteryOccupyingSocket = Target;
            Target = null;*/
        }
    }
}
