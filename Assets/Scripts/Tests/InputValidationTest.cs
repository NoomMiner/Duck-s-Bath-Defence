using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InputValidationTest
    {
     public InputValidation test = new InputValidation();

     [Test]
     public void test_validName()
        {
         // Use the Assert class to test conditions
         Assert.IsTrue( test.validateName("abc"), "This should be valid");
        }

     [Test]
     public void test_nameTooShort()
        {
         // Use the Assert class to test conditions
         Assert.IsFalse( test.validateName("a"), "This is too short");
        }

     [Test]
     public void test_nameTooLong()
        {
         // Use the Assert class to test conditions
         Assert.IsFalse( test.validateName("abcd"), "This is too long");
        }

     [Test]
     public void test_nameOnlyWhitespace()
        {
         // Use the Assert class to test conditions
         Assert.IsFalse( test.validateName(" \n\t"), "The length is correct but only whitespace");
        }

     [Test]
     public void test_validNameWithWhitespace()
        {
         // Use the Assert class to test conditions
         Assert.IsTrue( test.validateName("    abc   \n\t"), "This has whitespace but should still be valid");
        }

     [Test]
     public void test_zeroScore()
        {
         // Use the Assert class to test conditions
         Assert.IsTrue( test.validateScore(0), "0 is a valid score" );
        }

     [Test]
     public void test_negativeScore()
        {
         // Use the Assert class to test conditions
         Assert.IsFalse( test.validateScore(-1), "Score cannot be negative" );
        }

     [Test]
     public void test_positiveScore()
        {
         // Use the Assert class to test conditions
         Assert.IsTrue( test.validateScore(1), "Score can be any positive number" );
        }

     [Test]
     public void test_positiveWave()
        {
         // Use the Assert class to test conditions
         Assert.IsTrue( test.validateWave(1), "Wave can be any positive number > 0" );
        }

     [Test]
     public void test_zeroWave()
        {
         // Use the Assert class to test conditions
         Assert.IsFalse( test.validateWave(0), "Wave cannot be 0 or negative" );
        }

     [Test]
     public void test_blankMode()
        {
         // Use the Assert class to test conditions
         Assert.IsFalse( test.validateMode("  \t    \n"), "Mode string cannot be whitespace" );
        }

     [Test]
     public void test_validMode()
        {
         // Use the Assert class to test conditions
         Assert.IsTrue( test.validateMode("Test"), "Mode string cannot be whitespace" );
        }
    }
