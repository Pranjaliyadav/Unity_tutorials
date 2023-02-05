using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonState : MonoBehaviour
{
   [SerializeField] private Sprite[] buttonSprites;
   [SerializeField] private Image EyeButton;

   [SerializeField] private GameObject displayImage;

void Start(){
    displayImage.SetActive(false);
}
   public void changeSprite(){
   if(EyeButton.sprite == buttonSprites[0]){
        EyeButton.sprite = buttonSprites[1];
        displayImage.SetActive(true);

        return;
   }
   EyeButton.sprite = buttonSprites[0];
   displayImage.SetActive(false);

   }
}
