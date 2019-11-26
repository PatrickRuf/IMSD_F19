using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceMovement : MonoBehaviour
{
    float timer;

    private KeywordRecognizer WordRecognizer;

    // Confidence => How ambiguous are treated. Low, med, high
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;

    //Keywords
    public string[] words = new string[] { "right", "jump", "left", "start over" };

    void Start()
    {
        timer = 0;

        //Can't convert 'string' to 'string[]'
        WordRecognizer = new KeywordRecognizer(words, confidence);
        WordRecognizer.OnPhraseRecognized += RecognizedWord;
        WordRecognizer.Start();
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        
    }

    private void RecognizedWord(PhraseRecognizedEventArgs word)
    {
        Debug.Log(word.text);

        if ( word.text == "right" )
        {

            //transform.position = Vector3.Lerp(transform.position, Vector3Int.right * 5,timer) + transform.position;
            //transform.position += new Vector3(1 * Time.deltaTime * 50, 0, 0);
            transform.position += new Vector3(1, 0, 0);
        }

        if (word.text == "left")
        {
            
            transform.position = Vector3.Lerp(transform.position, Vector3Int.left * 5, timer) + transform.position;
        }

        if (word.text == "jump")
        {
            
            transform.position = Vector3.Lerp(transform.position, Vector3Int.up * 5, timer) + transform.position;

        }

        if (word.text == "start over")
        {

            transform.position = Vector3.zero;

        }
    }
}
