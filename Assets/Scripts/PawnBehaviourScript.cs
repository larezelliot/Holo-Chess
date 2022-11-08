using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnBehaviourScript : MonoBehaviour
{
    Transform Square, Board, Row_, GameManager;

    public Material normal, highlighted;

    // Start is called before the first frame update
    void Start()
    {
        Square = gameObject.transform.parent;
        Board = Square.transform.parent;
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
        if (GameManager.GetComponent<GameManagerBehaviour>().pieceSelected == gameObject)
            gameObject.GetComponent<MeshRenderer>().material = highlighted;
        else
            gameObject.GetComponent<MeshRenderer>().material = normal;
    }

    private void OnMouseDown()
    {
        print("Debug: Clicked");
        GameManager.GetComponent<GameManagerBehaviour>().pieceSelected = gameObject;
    }
}
