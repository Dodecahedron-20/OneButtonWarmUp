using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

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




}
