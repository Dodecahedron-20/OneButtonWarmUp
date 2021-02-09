using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  //speed of movement
  [SerializeField]
  private float Speed;



private bool CanMove = true;



    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {




      if (CanMove == true)
      {
        //auto movement:
        var horiz = 0;

        horiz += 1;

        var movement = new Vector3(horiz, 0, 0).normalized * Speed * Time.deltaTime;
        transform.position += movement;
      }


    }



    private void Movable()
    {
      CanMove = true;
    }

    public void NotMovable()
    {
      CanMove = false;
      StartCoroutine(Refresh());
    }

    IEnumerator Refresh()
    {
      yield return new WaitForSeconds(0.15f);

      Movable();

    }





}
