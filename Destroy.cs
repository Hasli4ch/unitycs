using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Уничтожение игрового объекта, к которому прикреплён скрипт
        Destroy(gameObject);
    }
 
}
