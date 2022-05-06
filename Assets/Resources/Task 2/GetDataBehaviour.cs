using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class GetDataBehaviour : MonoBehaviour
{
   
    public TextAsset textFile;
    //public int numberOfWords;
    public string startingLetter;

    public int wordLength;

    //add all the words of the file to the below list
    [HideInInspector]
    public List<string> rawWords;

    bool anyWordsFound;



    private void Awake()
    {

        

        if (textFile != null)
        {
            rawWords = textFile.text.Split().ToList();
            // textFile = Resources.Load<TextAsset>("Assets/Resources/Task 2/Text/words_alpha");
            //above line do not gives us required results.... and as we are having a placeholder in inspector to put the textfile, we are directly putting it there
        }
        else
        {
            Debug.Log("textFile is  null");
        }
    }

    private void Start()
    {
        anyWordsFound = false;


        foreach (string word in rawWords)
        {
            if (word.StartsWith( startingLetter) && word.Length == wordLength)
            {
                Debug.Log(word);
                anyWordsFound = true;
            }
        }

        if(anyWordsFound==false)
        {
            Debug.Log("no words found for the given parameters");
        }
    }

}
