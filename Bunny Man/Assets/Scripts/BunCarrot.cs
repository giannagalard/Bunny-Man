using System.Collections;
using UnityEngine;

public class BunCarrot : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D co)
     {
          if (co.name == "bunnyman")
               Destroy(gameObject);
     }
}

