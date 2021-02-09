using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{

    //speed of movement
    [SerializeField]
    private float Speed;

    //KeyCodeButton
    [SerializeField]
    private KeyCode Action;

    private bool TallbrickActive = true;



    //Brick gmaeobjects

    [SerializeField]
    private GameObject PCBrick;
    [SerializeField]
    private GameObject PCBrickFlat;


    //health tests:
    [SerializeField]
    private int Health;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //auto movement:
        var horiz = 0;

        horiz += 1;

        var movement = new Vector3(horiz, 0, 0).normalized * Speed * Time.deltaTime;
        transform.position += movement;

        //Action Button

        if (Input.GetKeyDown(Action))
        {
            if(TallbrickActive == false)
            {
                MakeBrickTall();
            }
            else
            {
                MakeBrickFlat();
            }
        }
    }


    void MakeBrickTall()
    {
        TallbrickActive = true;
        PCBrick.SetActive(true);
        PCBrickFlat.SetActive(false);
    }

    void MakeBrickFlat()
    {
        TallbrickActive = false;
        PCBrick.SetActive(false);
        PCBrickFlat.SetActive(true);
    }




}
