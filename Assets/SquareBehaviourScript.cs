using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBehaviourScript : MonoBehaviour
{
    Transform Board, Row_, GameManager;

    public Material normal, highlighted;

    // Start is called before the first frame update
    void Start()
    {
        Board = gameObject.transform.parent;
        Row_ = Board.transform.parent;
        GameManager = Row_.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        materialSelector();
        if (Input.GetKeyDown("space"))
        {
            print("Debug: Spaced");
            transform.position += new Vector3(1, 0, 0);
        }
    }

    private void materialSelector()
    {
        if (GameManager.GetComponent<GameManagerBehaviour>().squareSelected == gameObject)
            gameObject.GetComponent<MeshRenderer>().material = highlighted;
        else
            gameObject.GetComponent<MeshRenderer>().material = normal;
    }

    private void OnMouseDown()
    {
        print("Debug: Clicked");
        GameManager.GetComponent<GameManagerBehaviour>().squareSelected = gameObject;
    }
}
