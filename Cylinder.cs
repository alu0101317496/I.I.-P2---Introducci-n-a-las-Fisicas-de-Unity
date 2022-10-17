using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
  Rigidbody rb_Hndl_cylinder;
  Transform tf_Hndl_cylinder;
  GameObject obj;
  float detection_range = 2f;
  Transform player;

  // {{{Start is called before the first frame update
  void Start()
  {
    rb_Hndl_cylinder = GetComponent<Rigidbody>();
    tf_Hndl_cylinder = GetComponent<Transform>();
    player = GameObject.FindWithTag("Player").transform;
  }
  //}}}

  // {{{Update is called once per frame
  void Update()
  {  
    if ((Vector3.Distance(player.position, transform.position) <= detection_range) &&
        this.tag == "Cilindro_escape") {
      float x = Random.Range(-1f, 1f);
      float z = Random.Range(-1f, 1f);
      transform.Translate(x,
                          0f,
                          z);
    }
  }
  //}}}
  
  void OnCollisionEnter(Collision accused) {
    GameObject acc = accused.gameObject;
    if (acc.tag == "Player" && this.tag == "Cilindro") {
      Vector3 new_scale = new Vector3(0f, 0.1f, 0f);
      transform.localScale += new_scale;
      if (this.tag == "Cilindro_A" && Input.GetKey(KeyCode.Space)) {
        transform.Translate(Input.GetAxis("Horizontal")*2f,
                            0,
                            Input.GetAxis("Vertical")*2f);
      }
    }
  }
}
