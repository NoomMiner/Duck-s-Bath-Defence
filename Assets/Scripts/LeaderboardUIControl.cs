using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LeaderboardUIControl : MonoBehaviour
    {
     // public fields
     public GameObject nameInputObject;
     public GameObject scoreText;
     public GameObject messageText;
     public string playerName;
     public int score;
     public int wave;
     public string mode;
     public bool showMessage;
     
     // private fields
     private string addScoreURL = "https://ec2-18-117-249-64.us-east-2.compute.amazonaws.com/createlbentry.php?";
     private float timeoutTime = 10;
     private InputValidation inputValidator = new InputValidation();

     // Start is called before the first frame update
     void Start()
        {
         // pass
        }

    // Update is called once per frame
     void Update()
         {
          TMP_Text scoreTMP;

          if (scoreText != null && scoreText.TryGetComponent<TMP_Text>(out scoreTMP))
            {
             scoreTMP.SetText("Your score was: " + score.ToString());
            }
         }

     public void submitButton()
        {
         bool canTryAgain;
         string postScoresResult = postScores(out canTryAgain);
         TMP_Text messageTMP;

         Debug.Log(postScoresResult);

         if (showMessage && canTryAgain && messageText != null && 
             messageText.TryGetComponent<TMP_Text>(out messageTMP))
            {
             messageTMP.SetText(postScoresResult + " - Please try again.");
             messageTMP.enabled = true;
            }
          
         if (!canTryAgain)
            {
             close();
            }
        }

     public void close()
     {
      this.gameObject.SetActive(false);
     }

     private class GuaranteedCertificate : CertificateHandler
        {
         protected override bool ValidateCertificate(byte[] certificateData)
            {
             return true;
            }
        }

     private string postScores(out bool tryAgain)
        {
         TMP_InputField nameTMP;

         if (nameInputObject == null || !nameInputObject.TryGetComponent<TMP_InputField>(out nameTMP))
            {
             tryAgain = true;
             return "Could not read from name input.";
            }

         playerName = nameTMP.text.Trim();
         mode = mode.Trim();

         if (!inputValidator.validateName(playerName))
            {
             tryAgain = true;
             return "Invalid name";
            }

         if (!inputValidator.validateScore(score))
            {
             tryAgain = true;
             return "Invalid score";
            }

         if (!inputValidator.validateWave(wave))
            {
             tryAgain = true;
             return "Invalid wave";
            }

         if (!inputValidator.validateMode(mode))
            {
             tryAgain = true;
             return "Invalid mode";
            }

         string postURL = addScoreURL +
                          "name=" + UnityWebRequest.EscapeURL(playerName) +
                          "&score=" + UnityWebRequest.EscapeURL(score.ToString()) +
                          "&wave=" + UnityWebRequest.EscapeURL(wave.ToString()) +
                          "&mode=" + UnityWebRequest.EscapeURL(mode);

         UnityWebRequest postRequest = UnityWebRequest.Post(postURL, "", "text");
         postRequest.certificateHandler = new GuaranteedCertificate();
         postRequest.SendWebRequest();

         float timeSent = Time.time;

         while (Time.time - timeSent < timeoutTime)
            {
             if (postRequest.result == UnityWebRequest.Result.Success)
               {
                tryAgain = false;
                return "Score successfully posted!";
               }
            }

         tryAgain = true;
         return "Request timed out, current status: " + postRequest.result.ToString();
        }
    }
