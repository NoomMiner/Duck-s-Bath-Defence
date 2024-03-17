using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LeaderboardUIControl : MonoBehaviour
    {
     // public fields
     public GameObject nameInputObject;
     public GameObject scoreInputObject;
     public GameObject messageText;
     
     // private fields
     private string addScoreURL = "https://ec2-18-117-249-64.us-east-2.compute.amazonaws.com/createlbentry.php?";

     // Start is called before the first frame update
     void Start()
        {
         // pass
        }

    // Update is called once per frame
     void Update()
         {
          // pass
         }

     public void submitButton()
        {
         string postScoresResult = postScores();
         TMP_Text messageTMP;

         Debug.Log("THIS IS THE NEW VERSION");

         if (messageText.TryGetComponent<TMP_Text>(out messageTMP))
            {
             messageTMP.SetText(postScoresResult);
             messageTMP.enabled = true;
            }
        }

     private string postScores()
        {
         TMP_InputField nameTMP;
         TMP_InputField scoreTMP;

         if (!nameInputObject.TryGetComponent<TMP_InputField>(out nameTMP) ||
             !scoreInputObject.TryGetComponent<TMP_InputField>(out scoreTMP))
            {
             return "Could not read from text inputs.";
            }

         string postURL = addScoreURL +
                          "name=" + nameTMP.text +
                          "&score=" + scoreTMP.text +
                          "&wave=" + "1" +
                          "&mode=" + "Classic";

         UnityWebRequest postRequest = UnityWebRequest.Post(postURL, "", "text");
         postRequest.SendWebRequest();

         Debug.Log("Request sent to " + postURL);
         
         if (postRequest.error != null)
            {
             return "Error: " + postRequest.error;
            }

         return "Success!";
        }
    }
