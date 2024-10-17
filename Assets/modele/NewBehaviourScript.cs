using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)
        {
            messageText.text = "ta mère... ECRIT... fils de pute";
            numberInput.text = "";
            return;
        }

        if(int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "Aaah sale chienne va...tu veux une medaille ?";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "plus bas...batard";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "plus HAAAUUT...pd";
            }
        }
        else
        {
            messageText.text = "DES CHIFFRES CONNARD";
            
        }
        numberInput.text = "";
    }

    public void ResetGame()
    {
        messageText.text = "Aaah sa grand mère...trouve le nombre batard";
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number; " + randomNumber);

    }


}