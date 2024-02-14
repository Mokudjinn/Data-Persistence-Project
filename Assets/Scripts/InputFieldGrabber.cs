using TMPro;
using UnityEngine;

public class InputFieldGrabber : MonoBehaviour
{
    [Header("The value received from the 'input field'.")]
    [SerializeField] private string inputText;

    //[Header("Parse into int and float")]
    //[SerializeField] private int inputParseAsInt;
    //[SerializeField] private float inputParseAsFloat;

    [Header("Showing the reaction to the player")]
    [SerializeField] private GameObject reactionGroup;
    [SerializeField] private TMP_Text reactionTextBox;

    public void GrabFromInputField(string input)
    {
        inputText = input;

        //inputParseAsInt = int.Parse(input);
        //inputParseAsFloat = float.Parse(input);

        if (MainManager.Instance != null)
        {
        MainManager.Instance.m_playerName = input;
        }
        DisplayReactionToInput();
    }

    private void DisplayReactionToInput()
    {
        reactionTextBox.text = "\"Let's  rocks " + inputText + " !\"" ;
        reactionGroup.SetActive(true);
    }
}