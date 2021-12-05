using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energytracking : MonoBehaviour
{
    public SpriteRenderer background;
    public TextMesh readouttext;
    public List <Socket> Sockets;
    public TextMesh levelreadouttext;
    int energy = 0;
    int level = 1;
    private void OnMouseDown()
    {
        if(background.color == Color.green || background.color == Color.yellow)
        {
            energy = 0;
            foreach (var socket in Sockets)
            {
                if (socket.BatteryOccupyingSocket != null)
                {
                    energy += socket.BatteryOccupyingSocket.GetComponent<BatteryCharge>().charge;
                }
            }
            
            foreach (var socket in Sockets)
            {
                if (socket.BatteryOccupyingSocket != null)
                {
                    var batteryenergy = socket.BatteryOccupyingSocket.GetComponent<BatteryCharge>().charge;
                    var amountofenergytoconsume = Mathf.Min(batteryenergy, energy);
                    socket.BatteryOccupyingSocket.GetComponent<BatteryCharge>().charge -= amountofenergytoconsume;
                    energy -= amountofenergytoconsume;
                }
            }
            level += 1;
            levelreadouttext.text = "Warp "+level.ToString();

        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energy = 0;
        foreach(var socket in Sockets)
        {
            if(socket.BatteryOccupyingSocket != null)
            {
                energy += socket.BatteryOccupyingSocket.GetComponent<BatteryCharge>().charge;
            }
        }
        if(energy == 100)
        {
            background.color = Color.green;
            readouttext.color = Color.black;
            levelreadouttext.color = Color.black;

        }
        else if(energy > 100)
        {
            background.color = Color.yellow;
            readouttext.color = Color.black;
            levelreadouttext.color = Color.black;

        }
        else
        {
            readouttext.color = Color.white;
            levelreadouttext.color = Color.white;
            background.color = Color.red;
        }
        readouttext.text = "Energy: "+energy.ToString() + "/100";
        
    }
}
