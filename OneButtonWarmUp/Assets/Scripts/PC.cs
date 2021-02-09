using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PC : MonoBehaviour
{



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
    [SerializeField]
    private string hp;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {



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


    private void MakeBrickTall()
    {
        TallbrickActive = true;
        PCBrick.SetActive(true);
        PCBrickFlat.SetActive(false);
    }

    private void MakeBrickFlat()
    {
        TallbrickActive = false;
        PCBrick.SetActive(false);
        PCBrickFlat.SetActive(true);
    }

    //health goes here:

    public void LoseHealth()
    {

    }





}
