using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_hurt : MonoBehaviour
{
  [SerializeField]
  private Movement move;

  [SerializeField]
  private PC hitpoints;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
      move.NotMovable();
      hitpoints.LoseHealth();





    }





}
