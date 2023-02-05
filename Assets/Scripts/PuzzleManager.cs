using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{   
    [SerializeField] private List<PuzzleSlot> _slotPrefab;
    /* SerializeField shows fileds in unity inspector. here we creacte a list that takes puzzleSlot(class from another script PuzzleSlot) and in inspector its named slotPrefabs

    */
    [SerializeField] private PuzzlePiece _piecePrefab;
    //PuzzlePiece = class of PuzzlePiece script , piecePrefab = field name in unity inspector

    [SerializeField] private Transform _slotParent, _pieceParent;
    //Transform = used to work on properties of gameobjects such as rotations, position, scaling etc . pieceParent and slotParent takes two game objects in unity inspector
    

    void Start(){
        Spawn();
    }
    void Spawn(){
            var randomSet = _slotPrefab.OrderBy(s=>Random.value).Take(3).ToList();

            for(int i = 0; i < randomSet.Count;i++){
                var spawnedSlot = Instantiate(randomSet[i],_slotParent.GetChild(i).position, Quaternion.identity);

                var spawnedPiece = Instantiate(_piecePrefab,_pieceParent.GetChild(i).position, Quaternion.identity);
                spawnedPiece.Init(spawnedSlot);
            }
    }
}
