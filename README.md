# AutomatedQAConnectedApp
This is reverse engineered and patched AutomatedQA.script.dll and AutomatedQA.TestComplete.CSConnectedApp.dll to run in MSVS 2015

# Usage

1. Remove from the project references to AutomatedQA.script.dll and AutomatedQA.TestComplete.CSConnectedApp.dll.
2. Add Connect.cs and var.cs files to the project
3. Replace all "](" in the code to ].Do(
4. Enjoy

# Notes

It was tested to work with Testcomplete 9. I am not sure but it is possible that for greater versions of Testcomplete you should update in file Connect.cs following string "TestComplete.TestCompleteApplication.9" with appropriate version number.



