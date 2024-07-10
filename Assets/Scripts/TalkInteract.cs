using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkInteract : Interactable
{
    [SerializeField] DialogueContainer dialogue;

    public override void Interact(Character character)
    {
        if (dialogue == null)
        {
            Debug.LogWarning("DialogueContainer is not assigned in TalkInteract.");
            return;
        }

        GameManager.instance.dialogueSystem.Initialize(dialogue);
    }
}
