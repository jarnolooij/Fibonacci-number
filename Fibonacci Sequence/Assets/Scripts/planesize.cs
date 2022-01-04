using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planesize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(Camera.main.orthographicSize * 0.29f * Screen.width / Screen.height, Camera.main.orthographicSize * 1.0f, 1f);
    }


        // Update is called once per frame
    void Update()
    {
        
    }
}
