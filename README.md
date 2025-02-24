A. To programatically REQUEST data from this microservice, write an integer to the text file: "C:\Users\Public\CS361-MS-A\text-files\percent.txt". (The calling application will need to create this file and write to it.)
Next, call the MSA application.
Example call using C#:
Example text needed in percent.txt: 25

B. To programatically RECEIVE data from this microservice, read from the text file "C:\Users\Public\CS361-MS-A\text-files\image-path.txt" (This file is created by this microservice when it's run, as long as there is the needed "percent.txt" file in the folder and that file has an integer in it.) The format will be the full string of the file path for the image you're trying to pull.
Example call using C#:
Example text written out to image-path.txt: C:\Users\Public\CS361-MS-A\images\25.png

[UML for this project](UML.png)
