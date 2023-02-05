using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
public class PuzzleSelector : MonoBehaviour
{
    public GameObject StartPanel;
   public void SetPuzzlePhoto(Image Photo){

//    for(int i = 0; i < 36; i++)
    for(int i = 0; i < 16; i++){
        GameObject.Find("Piece ("+i+")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
   }
   StartPanel.SetActive(false); //when puzzle actives disable the start Panel

}
public void Back(){
    // for(int i = 0; i < 16; i++){
    //     GameObject piece = GameObject.Find("Piece ("+i+")");
    //     piece.transform.position = piece.GetComponent<PiecesScript>().RightPosition;
    //     piece.GetComponent<PiecesScript>().InRighPosition = false;
    //     piece.GetComponent<PiecesScript>().Selected = false;
    //     piece.GetComponent<SortingGroup>().sortingOrder = 0;
    // }
    StartPanel.SetActive(true);
}
}

/*This code defines a public variable "StartPanel" of type "GameObject" and a public method "SetPuzzlePhoto" which takes in one parameter of type "Image".

The method is iterating through 36 iterations and in each iteration, it is using the GameObject.Find("Piece ("+i+")") method to find a game object with the name "Piece (i)" where i is the current iteration number. It then uses the transform.Find("Puzzle") method to find a child object with the name "Puzzle" of the found game object.
Finally, it is using the GetComponent<SpriteRenderer>().sprite to get the sprite renderer component of the child object and then assigns the sprite of the passed in "Photo" object to the child object's sprite renderer component.

After the for loop, it is using the StartPanel.SetActive(false) to set the "StartPanel" game object inactive, likely hiding it from the scene.

So this code is likely used to change the puzzle pieces' sprites to the one passed in the "Image" object, and also hide the "StartPanel" game object after the sprites are set.*/