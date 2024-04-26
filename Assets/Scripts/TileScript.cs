using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileScript : MonoBehaviour, IPointerDownHandler
{

    public GameManager gameManager;
    public PlacementTiles tileManager;


    private Tower tw;
    public GameObject tileAvailability;


    // Start is called before the first frame update
    private void Start()
    {
        AddPhysics2DRaycaster();
        //initialize GameManager
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        //GameObject tileManagerObj = GameObject.FindGameObjectWithTag("TileAvailability");

        if (gameManagerObject != null )//&& tileManagerObj != null)
        {
            gameManager = gameManagerObject.GetComponent<GameManager>();
            //tileManager = tileManagerObj.GetComponent<PlacementTiles>();
        }

        tw = gameManager.drain;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        Vector3 mousePointer = eventData.pointerCurrentRaycast.gameObject.transform.position;

        Debug.Log("Tower held: " + gameManager.isTowerHeld);

        if (gameManager.isTowerHeld == true)
        {
            //if (gameManager.heldTower.placeTower(mousePointer))
            //{
                gameManager.RemoveCurrency(gameManager.TowerCost);
                gameManager.isTowerHeld = false;
                tw.placeTower(mousePointer);
            //}
        }

        Debug.Log("Tower held After Click: " + gameManager.isTowerHeld);


        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.transform.position);


    }

    private void AddPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }

    
}
