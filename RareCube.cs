using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RareCube : MonoBehaviour
{
  private float detection_range = 2f;
  Transform player;
  Transform sphere;
  Vector3 new_scale = new Vector3(0f, 0.2f, 0f);
  // Start is called before the first frame update
  void Start()
  {
    player = GameObject.FindWithTag("Player").transform;
    sphere = GameObject.FindWithTag("Esfera").transform;
  }

  // Update is called once per frame
  void Update()
  {
    if (Vector3.Distance(player.position, transform.position) <= 
        detection_range && transform.localScale.y > 0.5) {
      transform.localScale -= new_scale;
    }
    if (Vector3.Distance(sphere.position, transform.position) <=
        detection_range && transform.localScale.y < 5) {
      transform.localScale += new_scale;
    }
  }
}
