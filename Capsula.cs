using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula : MonoBehaviour
{
  private Rigidbody rb_Hndl_capsule;
  private Transform tf_Hndl_capsule;
  public float speed = 7f;
  // Start is called before the first frame update
  void Start()
  {
      rb_Hndl_capsule = GetComponent<Rigidbody>();
      tf_Hndl_capsule = GetComponent<Transform>();
  }

  // {{{Update is called once per frame
  void FixedUpdate()
  {
    rb_Hndl_capsule.AddForce(0, 0, speed * Time.deltaTime);
    if (Input.GetKey(KeyCode.L)) {
      rb_Hndl_capsule.AddForce(speed * Time.deltaTime,
                               0, 
                               0, 
                               ForceMode.VelocityChange);
    }

    if (Input.GetKey(KeyCode.J)) {
      rb_Hndl_capsule.AddForce(-speed * Time.deltaTime,
                               0, 
                               0, 
                               ForceMode.VelocityChange);
    }

    if (Input.GetKey(KeyCode.I)) {
      rb_Hndl_capsule.AddForce(0,
                               0,
                               speed * Time.deltaTime,
                               ForceMode.VelocityChange);
    }

    if (Input.GetKey(KeyCode.K)) {
      rb_Hndl_capsule.AddForce(0,
                               0,
                               -speed * Time.deltaTime,
                               ForceMode.VelocityChange);
    }
  }
  //}}}

  void OnCollisionEnter(Collision accused) {
    Debug.Log("WHy are YoU touching ME?!");
  }
}
