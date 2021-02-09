using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
  [SerializeField]
  private Transform target;

  [SerializeField]
  private float SmoothSpeed;

  [SerializeField]
  private Vector3 offset;


  void FixedUpdate()
  {
    Vector3 desiredPosition = target.position + offset;
    Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);
    transform.position = SmoothedPosition;




  }









}
