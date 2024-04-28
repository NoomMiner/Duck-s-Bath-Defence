using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileScript : MonoBehaviour, IPointerDownHandler
{

    public GameManager gameManager;
    public PlacementTiles tileManager;

    // Start is called before the first frame update
    private void Start()
    {
        AddPhysics2DRaycaster();

        //initialize GameManager
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        GameObject tileManagerObj = GameObject.FindGameObjectWithTag("TileAvailability");

        if (gameManagerObject != null )//&& tileManagerObj != null)
        {
            Debug.Log("Tile Manager found for TileScript");
            gameManager = gameManagerObject.GetComponent<GameManager>();
            tileManager = tileManagerObj.GetComponent<PlacementTiles>();
        }
        else
        {
            Debug.Log("Tile Manager not found for TileScript");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isTowerHeld)
        {
            gameManager.heldTower.canAttack = false;
        }

    }

    private void OnMouseOver()
    {
        
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        
        Vector3 mousePointer = eventData.pointerCurrentRaycast.gameObject.transform.position;

        //Check is user is placing a tower
        Debug.Log(mousePointer);
        if (gameManager.isTowerHeld == true)
        {
            
            
            //places tower and checks if user succeeded in placing tower
            if (gameManager.heldTower.placeTower(mousePointer))
            {
                gameManager.RemoveCurrency(gameManager.TowerCost);
                gameManager.isTowerHeld = false;
                //gameManager.heldTower.targetFamily = TargetFamily.Enemy;
                gameManager.heldTower.setCollidable(true);
                gameManager.heldTower.setCanAttack(true);


            }
        }

        //Checks if user is deleting a tower
        if (gameManager.isDeleting == true)
        {
            //gets all tower objects
            GameObject[] Towers = GameObject.FindGameObjectsWithTag("Tower");
            

            //Finds tower being deleted and deletes it
            for (int i = 0; i < Towers.Length; i++)
            {
                //sets all towers back to white
                Towers[i].GetComponent<SpriteRenderer>().color = Color.white;
                if (Towers[i].transform.position == mousePointer && Towers[i].name != "drain")
                {
                    //kills tower
                    Towers[i].GetComponent<Tower>().die();

                    //sets tile availability back to true
                    tileManager.getGrid().GetValue(mousePointer).setAvailable(true);
                }
            }

            
        }

        //Where was clicked
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
