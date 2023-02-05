using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    public GameObject SelectedPiece;
    int OIL = 1; //order in layer
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            
            if(hit.transform.CompareTag("Puzzle")){

                if(!hit.transform.GetComponent<PiecesScript>().InRighPosition){
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PiecesScript>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
                
            }
        }
        if(Input.GetMouseButtonUp(0)){
            if(SelectedPiece != null){

            SelectedPiece.GetComponent<PiecesScript>().Selected = false;
            SelectedPiece = null;
            }
        }
       if(SelectedPiece != null){
        Vector3  MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SelectedPiece.transform.position = new Vector3(MousePoint.x,MousePoint.y,0);
       }
    }
}

/*
RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);

This line of code is using the Unity Physics2D.Raycast() function to cast a 2D ray from the main camera to the mouse position in the world.
The Physics2D.Raycast() function takes two arguments:

The origin of the ray (Camera.main.ScreenToWorldPoint(Input.mousePosition)) which in this case is the position of the mouse pointer in world space, this is obtained by using the Camera.main.ScreenToWorldPoint(Input.mousePosition) function.
The direction of the ray (Vector2.zero) which in this case is set to Vector2.zero, meaning that the ray is cast in the direction of the positive Z-axis.
The function returns a RaycastHit2D object which contains information about the first collider that the ray hit, such as its position, normal, distance, and the collider itself.

In this case, the code is storing the returned RaycastHit2D object in the variable hit. This hit object can be used later in the code to check if the raycast hit a specific object and to get information about the object that was hit*/

/*if(Input.GetMouseButtonUp(0)){
            SelectedPiece = null;
        }
       if(SelectedPiece != null){
        Vector3  MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SelectedPiece.transform.position = new Vector3(MousePoint.x,MousePoint.y,0);
       }

This code is checking if the left mouse button is released by using the Input.GetMouseButtonUp(0) function. If the left mouse button is released, it sets the SelectedPiece variable to null.

Then it checks if the SelectedPiece variable is not equal to null. If it's not null, it means that a piece has been selected, it then gets the position of the mouse pointer in world space by using the Camera.main.ScreenToWorldPoint(Input.mousePosition) function and assigns it to the MousePoint variable. Finally, it updates the position of the SelectedPiece by setting its transform.position to a new Vector3 object created with the x,y and z values of the MousePoint variable, and z value is set to 0.*/

/*
if(!hit.transform.GetComponent<PiecesScript>().InRighPosition){
      SelectedPiece = hit.transform.gameObject;
      SelectedPiece.GetComponent<PiecesScript>().Selected = true;
       SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
        OIL++;
                }

This code is checking if the object that was hit by the raycast has a tag "Puzzle" using the hit.transform.CompareTag("Puzzle") function. If the object has the tag, it then checks if the object's InRighPosition property, which is likely a boolean variable in the script PiecesScript, is not set to true, by using the !hit.transform.GetComponent<PiecesScript>().InRighPosition

If the object's InRighPosition property is not true, the code is doing the following:

Assigns the object that was hit by the raycast to the SelectedPiece variable.
Sets the Selected property, which is likely a boolean variable in the script PiecesScript, to true
Assigns the object's sorting order to OIL and increment OIL by 1
This code is likely used to select puzzle pieces that are not in the correct position. The InRighPosition check is used to prevent selecting puzzle pieces that are already in the correct position. When a puzzle piece is selected, it is likely assigned the next available sorting order to ensure that it is rendered on top of other puzzle pieces.

*/
