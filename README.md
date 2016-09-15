# AutomatedQAConnectedApp
This is reverse engineered and patched AutomatedQA.script.dll and AutomatedQA.TestComplete.CSConnectedApp.dll to run in MSVS 2015

# Usage

1. Remove from the project references to AutomatedQA.script.dll and AutomatedQA.TestComplete.CSConnectedApp.dll.
2. Add Connect.cs and var.cs files to the project
3. Replace all "](" in the code to ].Do(
4. Enjoy
 
For example if in code you have something like ["Window"]("Edit", "", 4)["Click"](78, 13) then you should replace it with
["Window"].Do("Edit", "", 4)["Click"].Do(78, 13)



