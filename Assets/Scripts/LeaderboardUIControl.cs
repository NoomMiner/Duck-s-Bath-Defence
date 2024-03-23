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

     // Start is called before the first frame update
     void Start()
        {
         // pass
        }

    // Update is called once per frame
     void Update()
         {
          TMP_Text scoreTMP;

          if (scoreText.TryGetComponent<TMP_Text>(out scoreTMP))
            {
             scoreTMP.SetText("Your score was: " + score.ToString());
            }
          else
            {
             scoreTMP.SetText("Score cannot be displayed");
            }
         }

     public void submitButton()
        {
         string postScoresResult = postScores();
         TMP_Text messageTMP;

         if (showMessage && messageText.TryGetComponent<TMP_Text>(out messageTMP))
            {
             messageTMP.SetText(postScoresResult);
             messageTMP.enabled = true;
            }

          Destroy(this.gameObject);
        }

     private class GuaranteedCertificate : CertificateHandler
        {
         protected override bool ValidateCertificate(byte[] certificateData)
            {
             return true;
            }
        }

     private string postScores()
        {
         TMP_InputField nameTMP;

         if (!nameInputObject.TryGetComponent<TMP_InputField>(out nameTMP))
            {
             return "Could not read from name input.";
            }

         playerName = nameTMP.text;

         if (!validateName(playerName))
            {
             return "Invalid name";
            }

         if (!validateScore(score))
            {
             return "Invalid score";
            }

         if (!validateWave(wave))
            {
             return "Invalid wave";
            }

         if (!validateMode(mode))
            {
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
                return "Score successfully posted!";
               }
            }

         return "Request timed out, current status: " + postRequest.result.ToString();
        }

      private bool validateName(string name)
         {
          return name.Length == 3;
         }

      private bool validateScore(int score)
         {
          return score >= 0;
         }

      private bool validateWave(int wave)
         {
          return wave >= 1;
         }

      private bool validateMode(string mode)
         {
          return mode.Length > 0;
         }
    }
