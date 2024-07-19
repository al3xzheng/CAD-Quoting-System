This application is meant to be a quoting software for CAD files, starting off with SolidWorks projects, and then potentially adding AutoCAD, and potentially Altium Designer. 

A .NET application written in C#, this application uses COM Interop to install an Add-In in SolidWorks. Conveniently, the UI of the SolidWorks Add-In will be built as a .NET Windows Forms User Control.

Below is a demo pic of the basis of our application:
![image](https://github.com/user-attachments/assets/c147be8c-86b3-4641-bf24-d22412d0a858)

This UI allows you the select a file to be quote and will display the quoted price for such a design.

The SolidWorks API is gracefully used to access a SolidWorks file's properties (material, surface area, edges, corners, etc.) in order to accurately quote.

The basis for quoting is based on the price to do 3D-print said SolidWorks part/assembly. 
This serves as an accurate quoting software that allows for an automated client-pricing program for mechanical designers and manufacturers.

The quoting algorithm can be obtained from previous 3D-printing data and feeding the previously priced SolidWorks part/assembly into our application to get the data on how a part's properties affects the price. This data can be obtained by clients who use this application, and by test printing parts to generate data.
Then we can build an 'AI model' with regression models that accurately maps and weighs how each property affects the difficulty to 3D-print, and thus the price.

Finally with this done, we can input a SolidWorks part/assembly and get a quote! And after the part is 3D-printed we can fine-tune the model with the true 3D-printing price. Therefore making
this software improve with use.

This project is not finished and is currently in the works. Feel free to connect and message me on LinkedIn to know more about it or for a chat on anything! @ https://www.linkedin.com/in/al3xzheng/

In the future, to expand industry use, we will add the feature to quote CNC (Computer Numerical Control) manufacturing!
