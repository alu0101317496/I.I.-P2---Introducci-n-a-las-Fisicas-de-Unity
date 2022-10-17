using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
  public float speed = 7f;
  private Rigidbody rbHndl_player;
  public int score = 0;
  // {{{Start
  void Start()
  {
    //rbHndl_player = GetComponent<Rigidbody>();
  }
  //}}}

  // {{{Update
  void Update()
  {
    float aux = Time.deltaTime * speed;
    transform.Translate(Input.GetAxis("Horizontal")*aux,
                        0,
                        Input.GetAxis("Vertical")*aux);
  }
  //}}}

  void OnCollisionEnter(Collision accused) {
    if (accused.gameObject.tag == "Cilindro" || 
        accused.gameObject.tag == "Cilindro_A") {
      score += 1;
      Debug.Log("ONE POINT MORE\n Actual:");
      Debug.Log(score);
    }
  }
}
