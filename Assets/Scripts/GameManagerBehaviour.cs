using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehaviour : MonoBehaviour
{
    public GameObject pieceSelected = null;
    public GameObject squareSelected = null;
    public Camera camera1 = null;
    public Camera camera2 = null;

    public double lastTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(lastTime > 3)
        {
            lastTime = 0;
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
        lastTime += Time.deltaTime;
}
}
