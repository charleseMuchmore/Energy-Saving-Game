using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCharge : MonoBehaviour
{
    public int charge;
    public TextMesh numbermesh;
    // Start is called before the first frame update
    void Start()
    {
        numbermesh.text = charge.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        numbermesh.text = charge.ToString();
    }
}
