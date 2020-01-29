using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureChest : Interactable {

    public Item contents;
    public Inventory playerInventory;
    public bool isOpen;
    public Signal raiseItem;
    public GameObject dialogBox;
    public Text dialogText;
    private Animator anim;

    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if(!isOpen)
            {
                // Open the chest
                OpenChest();
            }else
            {
                // Chest is already open  
                ChestAlreadyOpen();
            }
        }
    }

    public void OpenChest()
    {
        // Dialog window on
        // dialog text = contents text
        // add contents to inventory
        //Raise the signal to the player to animate
        // set the chest t opened
        //raise the context clue
    }

    public void ChestAlreadyOpen()
    {

    }
}
