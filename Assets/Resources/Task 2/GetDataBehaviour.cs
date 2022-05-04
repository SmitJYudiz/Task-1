using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class GetDataBehaviour : MonoBehaviour
{
    //loading assets from the Resources folder using the generic Resources.Load<T>(path) method
    public TextAsset textFile;
    public int numberOfWords;
    public string startingLetter;

    //ek nae list me needed words dalo
    [HideInInspector]    
    public List<string>  rawWords;

    [HideInInspector]
    public int counter = 0;

    private void Awake()
    {



        // textFile = Resources.Load<TextAsset>("Assets/Resources/Task 2/Text/words_alpha");
        //above line do not gives us required results.... and as we are having a placeholder in inspector to put the textfile, we are directly putting it there
        rawWords = textFile.text.Split('\n').ToList();


        if (textFile != null)
        {
            foreach (string word in rawWords)
            {
                if (word.StartsWith(startingLetter))
                {
                    Debug.Log(word);
                    counter++;
                    if (counter >= numberOfWords)
                    {
                        break;
                    }
                }
            }
        
            //below while loop code just crashes unity
            //int i = 0;
            /* while (i < numberOfWords)
             {
                 if(rawWords[i].StartsWith(startingLetter))
                 {
                     Debug.Log(rawWords[i]);
                     i++;
                 }
             }*/

            
        }
        else
        {
            Debug.Log("textFile is  null");
        }
    }
}
