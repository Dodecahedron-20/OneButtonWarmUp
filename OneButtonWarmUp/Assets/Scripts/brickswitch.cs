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


    [SerializeField]
    private float seconds;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Switchflip());



    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Switchflip()
    {
      var delay = seconds;

      yield return new WaitForSeconds(delay);

      Switch();

      StartCoroutine(Switchflip());


    }

    private void Switch()
    {
      if (under == true)
      {
        SetUpright();
      }
      else
      {
        SetUnder();
      }
    }



    private void SetUpright()
    {
        under = false;
        DuckUnder.SetActive(false);
        GoThrough.SetActive(true);
    }

    private void SetUnder()
    {
        under = true;
        DuckUnder.SetActive(true);
        GoThrough.SetActive(false);
    }

}
