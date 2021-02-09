using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickswitch : MonoBehaviour
{

    //GameObjects
    [SerializeField]
    private GameObject DuckUnder;
    [SerializeField]
    private GameObject GoThrough;


    [SerializeField]
    private bool under;


    // Start is called before the first frame update
    void Start()
    {
      //  StartCoroutine(Switchflip());
    }

    // Update is called once per frame
    void Update()
    {
        







    }


    //IEnumerator Switchflip()
   // {
        


    //}


    void SetUpright()
    {
        under = false;
        DuckUnder.SetActive(false);
        GoThrough.SetActive(true);
    }

    void SetUnder()
    {
        under = true;
        DuckUnder.SetActive(true);
        GoThrough.SetActive(false);
    }

}
