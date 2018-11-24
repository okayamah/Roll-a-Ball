using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  // speedを制御する
  public float speed = 10;

  void FixedUpdate ()
  {
    // // キーボード
    // float x = Input.GetAxis("Horizontal");
    // float z = Input.GetAxis("Vertical");

    // ターゲット端末の縦横の表示に合わせてremapする
    float x = Input.acceleration.x;
    float z = Input.acceleration.y;

    Rigidbody rigidbody = GetComponent<Rigidbody>();

    // xとzにspeedを掛ける
    rigidbody.AddForce(x * speed, 0, z * speed);
  }
}
