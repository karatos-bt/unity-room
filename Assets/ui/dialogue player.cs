using TMPro;
using UnityEngine;

public class dialogueplayer : MonoBehaviour
{

    public Dialogueasset dialogueAsset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;

    private int dialogueLineIndex;

    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            dialogueLineIndex += 1;

            if (dialogueLineIndex < dialogueAsset.dialogue.Length) 
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false);
            }
        }
    }
}

