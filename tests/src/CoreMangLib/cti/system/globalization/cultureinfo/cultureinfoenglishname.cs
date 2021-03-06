using System;
using System.Globalization;
/// <summary>
///EnglishName
/// </summary>
public class CultureInfoEnglishName
{
    public static int Main()
    {
        CultureInfoEnglishName CultureInfoEnglishName = new CultureInfoEnglishName();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoEnglishName");
        if (CultureInfoEnglishName.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
    
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: CultureTypes.CurrentCulture");
        try
        {
             CultureInfo ci = CultureInfo.CurrentCulture;

             string inFactenglish =ci.EnglishName;
             string excepectedName= new CultureInfo(ci.Name).EnglishName;
             if (excepectedName != inFactenglish)
             {
                 TestLibrary.TestFramework.LogError("001", "the fact EnglishName is different from exceped Enginshname");
                 retVal = false;
             }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
 

}
